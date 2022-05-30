using BiblioDesktop.AdminData;
using BiblioDesktop.Core;
using BiblioDesktop.Interfaces;
using BiblioDesktop.Models;
using BiblioDesktop.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioDesktop
{
    public partial class FrmMenuPrincipal : Form
    {
        public static Usuario Usuario;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            BackgroundImage = Helper.RecuperarImagenDeArchivoDeRecursos("fondoSistema");
        }

        private void PictureBoxLibros_Click(object sender, EventArgs e)
        {
            var frmLibros = new FrmLibros(new DbAdminLibros());
            frmLibros.ShowDialog();
        }

        private void LblLibros_Click(object sender, EventArgs e)
        {
            var frmLibros = new FrmLibros(new DbAdminLibros());
            frmLibros.ShowDialog();
        }

        private void PictureBoxSocios_Click(object sender, EventArgs e)
        {
            var frmSocios = new FrmSocios(new DbAdminSocios());
            frmSocios.ShowDialog();
        }

        private void LblSocios_Click(object sender, EventArgs e)
        {
            var frmSocios = new FrmSocios(new DbAdminSocios());
            frmSocios.ShowDialog();
        }

        private void PictureBoxPrestamos_Click(object sender, EventArgs e)
        {
            var frmPrestamos = new FrmPrestamos(new DbAdminPrestamos());
            frmPrestamos.ShowDialog();
        }

        private void LabelPrestamos_Click(object sender, EventArgs e)
        {
            var frmPrestamos = new FrmPrestamos(new DbAdminPrestamos());
            frmPrestamos.ShowDialog();
        }

        private void PictureBoxTematicas_Click(object sender, EventArgs e)
        {
            var frmTematicas = new FrmTematicas(new DbAdminTematicas());
            frmTematicas.ShowDialog();
        }

        private void LblTematicas_Click(object sender, EventArgs e)
        {
            var frmTematicas = new FrmTematicas(new DbAdminTematicas());
            frmTematicas.ShowDialog();
        }

        private void PictureBoxConfig_Click(object sender, EventArgs e)
        {
            var frmParametros = new FrmParámetros(this);
            frmParametros.Show();
        }

        private void PictureBoxSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show($"Estás seguro que deseas salir?", "Cerrar Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            if (Usuario == null)
            {
                //si no hay nadie logeado, entonces mostramos el formulario de Login
                var frmLogin = new FrmLogin(this);
                frmLogin.ShowDialog();
                if (Usuario != null)
                {
                    //dependiendo el tipo de usuario, habilitamos los distintos menues para que tengan acceso
                    PbxUsuarios.Visible = Usuario.TipoUsuario == TipoUsuarioEnum.Empleado ? false : true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void PbxUsuarios_Click(object sender, EventArgs e)
        {
            var frmUsuarios = new FrmUsuarios(new DbAdminUsuarios());
            frmUsuarios.Show();
        }
    }
}
