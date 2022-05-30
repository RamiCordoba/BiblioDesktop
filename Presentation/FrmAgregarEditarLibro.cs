using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using BiblioDesktop.Models;
using System.Linq;
using BiblioDesktop.Core;
using System.Drawing;
using BiblioDesktop.Interfaces;
using BiblioDesktop.AdminData;
using BiblioDesktop.ExtensionMethods;

namespace BiblioDesktop.Presentation
{
    public partial class FrmAgregarEditarLibro : Form
    {
        DbAdminLibros dbAdmin = new DbAdminLibros();
        public int? IdEditar { get; set; }
        Libro libro = new Libro();
        WebCam webcam;

        public FrmAgregarEditarLibro()
        {
            InitializeComponent();
            LlenarCboTematica();
            webcam = new WebCam(this, AutoActivate: false, PbxFoto);
        }
        public FrmAgregarEditarLibro(int idLibroSeleccionado)
        {
            InitializeComponent();
            LlenarCboTematica();
            webcam = new WebCam(this, AutoActivate: false, PbxFoto);
            if (IdEditar != 0)
            {
                IdEditar = idLibroSeleccionado;
                CargarDatosDelLibro();
            }
        }

        private void CargarDatosDelLibro()
        {
            using var db = new BiblioDesktopContext();
            {
                libro = db.Libros.Find(IdEditar);
                TxtTitulo.Text = libro.Titulo;
                TxtEditorial.Text = libro.Editorial;
                TxtAutor.Text = libro.Autor;
                CboTematica.SelectedValue = libro.TematicaId;
                if (libro.Imagen != null)
                    PbxFoto.Image = Helper.convertirBytesAImagen(libro.Imagen);
            }
        }

        private void LlenarCboTematica()
        {
            using var db = new BiblioDesktopContext();
            var listaTematica = from tematica in db.Tematicas
                                select new
                                {
                                    id = tematica.Id,
                                    nombre = tematica.Nombre
                                };
            CboTematica.DataSource = listaTematica.ToList();
            CboTematica.DisplayMember = "nombre";
            CboTematica.ValueMember = "Id";
            CboTematica.SelectedIndex = -1;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new BiblioDesktopContext())
            {
                libro.Titulo = TxtTitulo.Text;
                libro.Autor = TxtAutor.Text;
                libro.Editorial = TxtEditorial.Text;
                libro.TematicaId = (int)CboTematica.SelectedValue;
                if (PbxFoto.Image != null)
                {
                    libro.Imagen = Helper.convertirImagenABytes(PbxFoto.Image);
                    BtnCapturarFoto.Enabled = true;
                }
                else
                    BtnCapturarFoto.Enabled = false;

                if (IdEditar == null)
                    dbAdmin.Agregar(libro);
                else
                {
                    dbAdmin.Actualizar(libro);
                }

                db.SaveChanges();
            }
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (libro.Id == 0)
            {
                if (TxtTitulo.Text.Length == 0 && TxtEditorial.Text.Length == 0 && TxtAutor.Text.Length == 0)
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
            this.Close();
        }

        private bool CompararDatosFormularioConLosDeBBDD()
        {
            return (libro.Titulo == TxtTitulo.Text && libro.Editorial == TxtEditorial.Text && libro.Autor == TxtAutor.Text);
        }
        private void BtnIniciarDetenerCamara_Click(object sender, EventArgs e)
        {
            if (BtnIniciarDetenerCamara.Text == "Iniciar Cámara")
            {
                InicializarCamara();
            }
            else
            {
                DetenerCamara();
            }
        }
        private void InicializarCamara()
        {
            webcam.Initalize();
            BtnIniciarDetenerCamara.Text = "Detener Cámara";
            BtnCapturarFoto.Text = "Capturar Foto";
            BtnCapturarFoto.Enabled = true;
        }
        private void DetenerCamara()
        {
            webcam.Deinitalize();
            BtnIniciarDetenerCamara.Text = "Iniciar Cámara";
            BtnCapturarFoto.Text = "Borrar Foto";
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAbrirArchivo = new OpenFileDialog();
            string filtro = "Todas las imágenes|*.jpg;*.gif;*.png;*.bmp;*.jpeg";
            filtro += "|JPG (*.jpg)|*.jpg";
            filtro += "|JPEG (*.jpeg)|*.jpeg";
            filtro += "|GIF (*.gif)|*.gif";
            filtro += "|PNG (*.png)|*.png";
            filtro += "|BMP (*.bmp)|*.bmp";

            ofdAbrirArchivo.Filter = filtro;
            ofdAbrirArchivo.ShowDialog();

            if (ofdAbrirArchivo.FileName != "")
            {
                PbxFoto.Image = new Bitmap(ofdAbrirArchivo.FileName);
            }
        }

        private void BtnCapturarFoto_Click(object sender, EventArgs e)
        {
            if (BtnCapturarFoto.Text == "Borrar Foto")
            {
                PbxFoto.Image = null;
                BtnCapturarFoto.Enabled = false;
            }
            else
                DetenerCamara();
        }
    }
}
