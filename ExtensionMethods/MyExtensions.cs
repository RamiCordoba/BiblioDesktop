using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BiblioDesktop.ExtensionMethods
{
    public static class MyExtensions
    {
        public static void HabilitarDeshabilitarTextBox(this Form form, bool valor)
        {
            foreach (Object obj in form.Controls)
            {
                if (obj.GetType().Name == "TextBox")
                {
                    TextBox o = (TextBox)obj;
                    o.Enabled = valor;
                }
            }
        }
        /// <summary>
        /// Fecha: 30/09/2021
        /// Creamos un método genérico que pregunte (en formularios y momentos especiales)
        /// si está seguro que desea salir
        /// </summary>
        /// <param name="form"></param>
        public static void MensajeAdvertenciaDeSalida (this Form form)
        {
            var respuesta = MessageBox.Show($"¿Está seguro que desea salir del formulario {form.Text}","Atención",MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
                form.Close();
        }
        /// <summary>
        /// Método que oculta las columnas con información de eliminación, para utilizar en
        /// todas las grillas
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="ocultarMostrar"></param>
        public static void OcultarColumnas(this DataGridView grid, bool ocultarMostrar = false)
        {
            if (grid.Columns["UsuarioId"] != null)
                grid.Columns["UsuarioId"].Visible = false;
            if (grid.Columns["FechaHoraEliminacion"] != null)
                grid.Columns["FechaHoraEliminacion"].Visible = false;
            if (grid.Columns["SocioId"] != null)
                grid.Columns["SocioId"].Visible = false;
            if (grid.Columns["Prestamos"] != null)
                grid.Columns["Prestamos"].Visible = false;
            if (grid.Columns["TematicaId"] != null)
                grid.Columns["TematicaId"].Visible = false;
            if (grid.Columns["Usuario"] != null)
                grid.Columns["Usuario"].Visible = false;
            if (grid.Columns["Eliminado"] != null)
                grid.Columns["Eliminado"].Visible = false;
            if (grid.Columns["Imagen"] != null)
                grid.Columns["Imagen"].Visible = false;
            if (grid.Columns["Password"] != null)
                grid.Columns["Password"].Visible = false;
            if (grid.Columns["Socio"] != null)
                grid.Columns["Socio"].Visible = false;
        }
        public static int ObtenerIdSeleccionado(this DataGridView grid)
        {
            return int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
