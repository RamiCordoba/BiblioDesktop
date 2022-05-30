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
    public partial class FrmTematicas : Form, IFormBase
    {
        IDbAdmin dbAdmin;

        public int? IdEditar{get; set;}

        public FrmTematicas(IDbAdmin objetoDbAdmin)
        {
            InitializeComponent();
            dbAdmin = objetoDbAdmin;
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            if (ChkVerEliminadas.Checked)
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
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var frmAgregarTematica = new FrmAgregarEditarTematica();
            frmAgregarTematica.ShowDialog();
            ActualizarGrilla();
            grid.CurrentCell = grid.Rows[grid.RowCount - 1].Cells[0];

        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            grid.DataSource = dbAdmin.ObtenerTodos(TxtBusqueda.Text);
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var idTematicaSeleccionada = grid.ObtenerIdSeleccionado();
            var filaAEditar = grid.CurrentRow.Index;
            var frmAgregarEditarTematica = new FrmAgregarEditarTematica(idTematicaSeleccionada);
            frmAgregarEditarTematica.ShowDialog();
            ActualizarGrilla();
            grid.CurrentCell = grid.Rows[filaAEditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var idTematicaSeleccionada = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
            var tituloNombreTematica= grid.CurrentRow.Cells[1].Value.ToString();
            DialogResult respuesta = MessageBox.Show($"¿Estás seguro que desea borrar {tituloNombreTematica}?", "Eliminar Temática", MessageBoxButtons
                .YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Eliminar Temática")
            {
                dbAdmin.Eliminar(idTematicaSeleccionada);
                ActualizarGrilla();
            }
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Restaurar Temática")
            {
                dbAdmin.Restaurar(idTematicaSeleccionada);
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

        private void ChkVerEliminadas_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVerEliminadas.Checked)
                BtnEliminar.Text = "Restaurar Temática";
            else
                BtnEliminar.Text = "Eliminar Temática";
            ActualizarGrilla();
        }
    }
}
