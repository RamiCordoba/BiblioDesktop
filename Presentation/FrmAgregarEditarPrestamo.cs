using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Windows.Forms;
using BiblioDesktop.Models;
using System.Linq;
using System.Collections.Generic;

namespace BiblioDesktop.Presentation
{
    public partial class FrmAgregarEditarPrestamo : Form
    {
        public int? IdEditar { get; set; }
        Prestamo prestamo = new Prestamo();
        public FrmAgregarEditarPrestamo()
        {
            InitializeComponent();
            LlenarCboSocios();
            LlenarCboLibros();
            LblLibroDevuelto.Visible = false;
            CheckBoxLibroDevuelto.Visible = false;
        }
        public FrmAgregarEditarPrestamo(int? idPrestamoSeleccionado = null)
        {
            InitializeComponent();
            LlenarCboLibros();
            LlenarCboSocios();
            IdEditar = idPrestamoSeleccionado;
            CargarDatosDelPrestamoEnPantalla();
        }
        private void CargarDatosDelPrestamoEnPantalla()
        {
            using var db = new BiblioDesktopContext();
            prestamo = db.Prestamos.Find(IdEditar);
            CboSocios.SelectedValue = prestamo.SocioId;
            CboLibros.SelectedValue = prestamo.IdLibro;
            DtpFechaRetiro.Value = prestamo.FechaRetiro;
            DtpFechaEntrega.Value = prestamo.FechaEntrega;
            CheckBoxLibroDevuelto.Checked = prestamo.LibroDevuelto;
        }

        private void LlenarCboLibros()
        {
            using var db = new BiblioDesktopContext();
            var listaLibros = from libro in db.Libros
                              select new { id = libro.Id, nombre = libro.Titulo };
            CboLibros.DataSource = listaLibros.ToList();
            CboLibros.DisplayMember = "nombre";
            CboLibros.ValueMember = "id";
            CboLibros.SelectedIndex = -1;
        }
        private void LlenarCboSocios()
        {
            using var db = new BiblioDesktopContext();
            var listaSocios = from socio in db.Socios
                              select new { id = socio.Id, nombre =  (socio.Nombre+ " " + socio.Apellido)};
            CboSocios.DataSource = listaSocios.ToList();
            CboSocios.DisplayMember = "nombre";
            CboSocios.ValueMember = "id";
            CboSocios.SelectedIndex = -1;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new BiblioDesktopContext())
            {
                prestamo.SocioId = (int)CboSocios.SelectedValue;
                prestamo.IdLibro = (int)CboLibros.SelectedValue;
                prestamo.FechaRetiro = DtpFechaRetiro.Value.Date;
                prestamo.FechaEntrega = DtpFechaEntrega.Value.Date;
                prestamo.LibroDevuelto = CheckBoxLibroDevuelto.Checked;
                if (IdEditar == null)
                    db.Prestamos.Add(prestamo);
                else
                {
                    db.Entry(prestamo).State = EntityState.Modified;
                }

                db.SaveChanges();
            }
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (prestamo.Id == 0)
            {
                if (CboLibros.Text.Length == 0 && CboSocios.Text.Length == 0 && DtpFechaEntrega.Text.Length == 0 && DtpFechaRetiro.Text.Length == 0)
                    this.Close();
                else
                {
                    PreguntarSiSaleSinGuardar();
                }
            }
            else
            {
                if (CompararDatosForumarioConLosDeBBDD())
                {
                    this.Close();
                }
                else
                {
                    PreguntarSiSaleSinGuardar();
                }
            }
        }
        private void PreguntarSiSaleSinGuardar()
        {
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea salir del formulario sin guardar los datos?", "Datos sin Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private bool CompararDatosForumarioConLosDeBBDD()
        {
            return (prestamo.Libro == CboLibros.SelectedValue && prestamo.Socio == CboSocios.SelectedValue && prestamo.FechaEntrega == DtpFechaEntrega.Value.Date && prestamo.FechaRetiro == DtpFechaRetiro.Value.Date);
        }
    }
}
