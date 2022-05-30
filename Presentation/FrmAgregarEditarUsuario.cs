using BiblioDesktop.AdminData;
using BiblioDesktop.Core;
using BiblioDesktop.ExtensionMethods;
using BiblioDesktop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BiblioDesktop.Presentation
{
    public partial class FrmAgregarEditarUsuario : Form
    {
        DbAdminUsuarios dbAdmin = new DbAdminUsuarios();
        public int? IdEditar { get; set; }
        Usuario usuario = new Usuario();
        public FrmAgregarEditarUsuario()
        {
            InitializeComponent();
            LlenarComboTipoUsuario();                
        }
        public FrmAgregarEditarUsuario(int idSeleccionado)
        {
            InitializeComponent();
            LlenarComboTipoUsuario();
            if (idSeleccionado != 0)
            {
                IdEditar = idSeleccionado;
                CargarDatosDelUsuario();
                TxtContraseña.Enabled = false;
            }
        }

        private void CargarDatosDelUsuario()
        {
            using (var db = new BiblioDesktopContext())
            {
                usuario = db.Usuarios.Find(IdEditar);
                TxtNombreCompleto.Text = usuario.Nombre;
                TxtUsuario.Text = usuario.User;
                CboTipoUsuario.SelectedItem =usuario.TipoUsuario;
            }
        }

        private void LlenarComboTipoUsuario()
        {
           CboTipoUsuario.DataSource = Enum.GetValues(typeof(TipoUsuarioEnum));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new BiblioDesktopContext())
            {
                usuario.Nombre = TxtNombreCompleto.Text;
                usuario.User = TxtUsuario.Text;
                usuario.TipoUsuario = (TipoUsuarioEnum)CboTipoUsuario.SelectedValue;
                if (IdEditar == null)
                { 
                    usuario.Password = Helper.ObtenerHashSha256(TxtContraseña.Text);
                    dbAdmin.Agregar(usuario);
                    MessageBox.Show("Usuario " + usuario.Nombre + " cargado con exito");
                }
                else 
                {
                    dbAdmin.Actualizar(usuario);
                    MessageBox.Show("Usuario " + usuario.Nombre + " modificado con exito");
                }
                db.SaveChanges();
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.MensajeAdvertenciaDeSalida();
        }
    }
}
