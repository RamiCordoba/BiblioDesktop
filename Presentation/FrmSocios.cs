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
using BiblioDesktop.Interfaces;
using BiblioDesktop.ExtensionMethods;

namespace BiblioDesktop.Presentation
{
    public partial class FrmSocios : Form, IFormBase
    {
        IDbAdmin dbAdmin;

        public int? IdEditar { get; set; }

        public FrmSocios(IDbAdmin objetoDbAdmin)
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
                grid.DataSource = dbAdmin.ObtenerTodos();
                grid.OcultarColumnas();
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            grid.DataSource = dbAdmin.ObtenerTodos(TxtBusqueda.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var frmAgregarEditarSocio = new FrmAgregarEditarSocio();
            frmAgregarEditarSocio.ShowDialog();
            ActualizarGrilla();
            grid.CurrentCell = grid.Rows[grid.RowCount - 1].Cells[0];

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var idSocioSeleccionado = grid.ObtenerIdSeleccionado();
            var filaAEditar = grid.CurrentRow.Index;
            var frmAgregarEditarSocio = new FrmAgregarEditarSocio(idSocioSeleccionado);
            frmAgregarEditarSocio.ShowDialog();
            ActualizarGrilla();
            grid.CurrentCell = grid.Rows[filaAEditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var idSocioSeleccionado = grid.ObtenerIdSeleccionado();
            var nombreSocioSeleccionado = grid.CurrentRow.Cells[1].Value.ToString() + " " + grid.CurrentRow.Cells[2].Value.ToString();
            DialogResult respuesta = MessageBox.Show($"¿Estás seguro que desea borrar a {nombreSocioSeleccionado}?", "Eliminar Socio", MessageBoxButtons
                .YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Eliminar Socio")
            {
                dbAdmin.Eliminar(idSocioSeleccionado);
                ActualizarGrilla();
            }
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Restaurar Socio")
            {
                dbAdmin.Restaurar(idSocioSeleccionado);
                ActualizarGrilla();
            }
        }

        private void BtnListadoSocios_Click(object sender, EventArgs e)
        {
            var frmListaSocios = new FrmListaSocios();
            frmListaSocios.ShowDialog();
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
                BtnEliminar.Text = "Restaurar Socio";
            else
                BtnEliminar.Text = "Eliminar Socio";
            ActualizarGrilla();
        }
    }
}
