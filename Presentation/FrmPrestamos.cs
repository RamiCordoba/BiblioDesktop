using BiblioDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BiblioDesktop.Presentation;
using BiblioDesktop.ExtensionMethods;
using BiblioDesktop.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BiblioDesktop.Presentation
{
    public partial class FrmPrestamos : Form, IFormBase
    {
        IDbAdmin dbAdmin;

        public int? IdEditar { get; set; }

        public FrmPrestamos(IDbAdmin objetoDbAdmin)
        {
            InitializeComponent();
            dbAdmin = objetoDbAdmin;
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            if (ChkVerEliminados.Checked)
            {
                grid.DataSource = dbAdmin.ObtenerEliminados();
                grid.OcultarColumnas(ocultarMostrar: false);
            }
            else
            {
                using (var db = new BiblioDesktopContext())
                {
                    var prestamosAListar = from prestamo in db.Prestamos
                                           select new
                                           {
                                               Id = prestamo.Id,
                                               Nombre = prestamo.Socio.Nombre + " " + prestamo.Socio.Apellido,
                                               NombreLibro = prestamo.Libro.Titulo,
                                               FechaRetiro = prestamo.FechaRetiro,
                                               FechaEntrega = prestamo.FechaEntrega,
                                               LibroDevuelto = prestamo.LibroDevuelto,
                                               Eliminado = prestamo.Eliminado
                                           };
                    grid.DataSource = prestamosAListar.IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
                    grid.OcultarColumnas();
                }
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var frmNuevoPrestamo = new FrmAgregarEditarPrestamo();
            frmNuevoPrestamo.ShowDialog();
            ActualizarGrilla();
            grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells[0];
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            grid.DataSource = dbAdmin.ObtenerTodos(TxtBusqueda.Text);
            grid.OcultarColumnas();
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var idPrestamoSeleccionado = grid.ObtenerIdSeleccionado();
            var filaAEditar = grid.CurrentRow.Index;
            var frmAgregarEditarPrestamo = new FrmAgregarEditarPrestamo(idPrestamoSeleccionado);
            frmAgregarEditarPrestamo.ShowDialog();
            ActualizarGrilla();
            grid.CurrentCell = grid.Rows[filaAEditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var idPrestamoSeleccionado = grid.ObtenerIdSeleccionado();
            DialogResult respuesta = MessageBox.Show($"¿Estás seguro que desea borrar el prestamo?", "Eliminar Prestamo", MessageBoxButtons
                .YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Eliminar Prestamo")
            {
                dbAdmin.Eliminar(idPrestamoSeleccionado);
                ActualizarGrilla();
            }
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Restaurar Prestamo")
            {
                dbAdmin.Restaurar(idPrestamoSeleccionado);
                ActualizarGrilla();
            }
        }

        public void CargarDatosEnPantalla()
        {
            throw new NotImplementedException();
        }

        public void LimpiarDatosDeLaPantalla()
        {
            throw new NotImplementedException();
        }

        private void ChkVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVerEliminados.Checked)
                BtnEliminar.Text = "Restaurar Prestamo";
            else
                BtnEliminar.Text = "Eliminar Prestamo";
            ActualizarGrilla();
        }
    }
}
