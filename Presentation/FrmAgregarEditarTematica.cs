using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using BiblioDesktop.Models;
using System.Linq;
using BiblioDesktop.AdminData;
using BiblioDesktop.ExtensionMethods;

namespace BiblioDesktop.Presentation
{
    public partial class FrmAgregarEditarTematica : Form
    {
        DbAdminTematicas dbAdmin = new DbAdminTematicas();
        public int? IdEditar { get; set; }
        Tematica tematica = new Tematica();

        public FrmAgregarEditarTematica()
        {
            InitializeComponent();
        }
        public FrmAgregarEditarTematica(int? idTematicaSeleccionada = null)
        {
            InitializeComponent();
            IdEditar = idTematicaSeleccionada;
            CargarDatosDeLaTematica();
        }

        private void CargarDatosDeLaTematica()
        {
            using var db = new BiblioDesktopContext();
            tematica = db.Tematicas.Find(IdEditar);
            TxtNombre.Text = tematica.Nombre;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new BiblioDesktopContext())
            {
                tematica.Nombre = TxtNombre.Text;
                if (IdEditar == null)
                    dbAdmin.Agregar(tematica);
                else
                {
                    dbAdmin.Actualizar(tematica);
                }

                db.SaveChanges();
            }
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (tematica.Id == 0)
            {
                if (TxtNombre.Text.Length == 0)
                    this.Close();
                else
                {
                    this.MensajeAdvertenciaDeSalida();
                }
            }
            else
            {
                if (CompararDatosFormularioConLosDeBBDD())
                {
                    this.Close();
                }
                else
                {
                    this.MensajeAdvertenciaDeSalida();
                }
            }
        }

        private bool CompararDatosFormularioConLosDeBBDD()
        {
            return (tematica.Nombre == TxtNombre.Text);
        }
    }
}
