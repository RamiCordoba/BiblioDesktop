using BiblioDesktop.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BiblioDesktop.ExtensionMethods;
using BiblioDesktop.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BiblioDesktop.Presentation
{
    public partial class FrmLibros : Form, IFormBase
    {
        IDbAdmin dbAdmin;

        public int? IdEditar { get; set; }

        public FrmLibros(IDbAdmin objetoDbAdmin)
        {
            InitializeComponent();
            dbAdmin = objetoDbAdmin;
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            if (ChkVerEliminados.Checked)
            {
                using (var db = new BiblioDesktopContext())
                {
                    var librosAListar = from libro in db.Libros
                                        select new
                                        {
                                            Id = libro.Id,
                                            Nombre = libro.Titulo,
                                            Autor = libro.Autor,
                                            Editorial = libro.Editorial,
                                            Tematica = libro.Tematica.Nombre,
                                            Eliminado = libro.Eliminado
                                        };
                    grid.DataSource = librosAListar.IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
                    grid.DataSource = dbAdmin.ObtenerEliminados();
                    grid.OcultarColumnas(ocultarMostrar: false);
                }
            }
            else
            {
                using (var db = new BiblioDesktopContext())
                {
                    var librosAListar = from libro in db.Libros
                                        select new
                                        {
                                            Id = libro.Id,
                                            Nombre = libro.Titulo,
                                            Autor = libro.Autor,
                                            Editorial = libro.Editorial,
                                            Tematica = libro.Tematica.Nombre,
                                            Eliminado = libro.Eliminado
                                        };
                    grid.DataSource = librosAListar.IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
                    grid.OcultarColumnas();
                }
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var frmAgregarLibro = new FrmAgregarEditarLibro();
            frmAgregarLibro.ShowDialog();
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
            var idLibroSeleccionado = grid.ObtenerIdSeleccionado();
            var filaAEditar = grid.CurrentRow.Index;
            var frmEditarLibro = new FrmAgregarEditarLibro(idLibroSeleccionado);
            frmEditarLibro.ShowDialog();
            ActualizarGrilla();
            grid.CurrentCell = grid.Rows[filaAEditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var idLibroSeleccionado = grid.ObtenerIdSeleccionado();
            var tituloLibroSeleccionado = grid.CurrentRow.Cells[1].Value.ToString();
            DialogResult respuesta = MessageBox.Show($"¿Estás seguro que desea borrar {tituloLibroSeleccionado}?", "Eliminar Libro", MessageBoxButtons
                .YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Eliminar Libro")
            {
                dbAdmin.Eliminar(idLibroSeleccionado);
                ActualizarGrilla();
            }
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Restaurar Libro")
            {
                dbAdmin.Restaurar(idLibroSeleccionado);
                ActualizarGrilla();
            }
        }

        private void BtnListaLibros_Click(object sender, EventArgs e)
        {
            var frmListaLibros = new FrmListaLibros();
            frmListaLibros.ShowDialog();
            ActualizarGrilla();
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
                BtnEliminar.Text = "Restaurar Libro";
            else
                BtnEliminar.Text = "Eliminar Libro";
            ActualizarGrilla();
        }
    }
}
