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
    public partial class FrmUsuarios : Form, IFormBase
    {
        IDbAdmin dbAdmin;

        public int? IdEditar { get; set; }

        public FrmUsuarios(IDbAdmin objetoDbAdmin)
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
            var frmAgregarEditarUsuario = new FrmAgregarEditarUsuario();
            frmAgregarEditarUsuario.ShowDialog();
            ActualizarGrilla();
            grid.CurrentCell = grid.Rows[grid.RowCount - 1].Cells[0];

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var idUsuarioSeleccionado = grid.ObtenerIdSeleccionado();
            var filaAEditar = grid.CurrentRow.Index;
            var frmAgregarEditarUsuario = new FrmAgregarEditarUsuario(idUsuarioSeleccionado);
            frmAgregarEditarUsuario.ShowDialog();
            ActualizarGrilla();
            grid.CurrentCell = grid.Rows[filaAEditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var idUsuarioSeleccionado = grid.ObtenerIdSeleccionado();
            var nombreUsuarioSeleccionado = grid.CurrentRow.Cells[1].Value.ToString();
            DialogResult respuesta = MessageBox.Show($"¿Estás seguro que desea borrar a {nombreUsuarioSeleccionado}?", "Eliminar Usuario", MessageBoxButtons
                .YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Eliminar Usuario")
            {
                dbAdmin.Eliminar(idUsuarioSeleccionado);
                ActualizarGrilla();
            }
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Restaurar Usuario")
            {
                dbAdmin.Restaurar(idUsuarioSeleccionado);
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
                BtnEliminar.Text = "Restaurar Usuario";
            else
                BtnEliminar.Text = "Eliminar Usuario";
            ActualizarGrilla();
        }
    }
}
