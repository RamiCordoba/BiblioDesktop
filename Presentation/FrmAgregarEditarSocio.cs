using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BiblioDesktop.Models;
using BiblioDesktop.Core;
using BiblioDesktop.AdminData;
using BiblioDesktop.ExtensionMethods;

namespace BiblioDesktop.Presentation
{
    public partial class FrmAgregarEditarSocio : Form
    {
        DbAdminSocios dbAdmin = new DbAdminSocios();
        public int? IdEditar { get; set; }
        Socio socio = new Socio();
        WebCam webcam;

        public FrmAgregarEditarSocio()
        {
            InitializeComponent();
            webcam = new WebCam(this, AutoActivate: false, PbxFoto);
        }
        public FrmAgregarEditarSocio(int? idSocioSeleccionado = null)
        {
            InitializeComponent();
            IdEditar = idSocioSeleccionado;
            CargarDatosDelSocioEnPantalla();
            webcam = new WebCam(this, AutoActivate: false, PbxFoto);
        }

        private void CargarDatosDelSocioEnPantalla()
        {
            using var db = new BiblioDesktopContext();
            socio = db.Socios.Find(IdEditar);
            TxtNombre.Text = socio.Nombre;
            TxtApellido.Text = socio.Apellido;
            TxtDomicilio.Text = socio.Domicilio;
            NudDni.Value = socio.Dni;
            NudTelefono.Value = (decimal)socio.Telefono;
            if (socio.Imagen != null)
                PbxFoto.Image = Helper.convertirBytesAImagen(socio.Imagen);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new BiblioDesktopContext())
            {
                socio.Nombre = TxtNombre.Text;
                socio.Apellido = TxtApellido.Text;
                socio.Dni = (int)NudDni.Value;
                socio.FechaNacimiento = DtpNacimiento.Value.Date;
                socio.Domicilio = TxtDomicilio.Text;
                socio.Telefono = (double)NudTelefono.Value;
                if (PbxFoto.Image != null)
                {
                    socio.Imagen = Helper.convertirImagenABytes(PbxFoto.Image);
                    BtnCapturarFoto.Enabled = true;
                }
                else
                    BtnCapturarFoto.Enabled = false;

                if (IdEditar == null)
                    dbAdmin.Agregar(socio);
                else
                {
                    dbAdmin.Actualizar(socio);
                }

                db.SaveChanges();
            }
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (socio.Id == 0)
            {
                if (TxtApellido.Text.Length == 0 && TxtNombre.Text.Length == 0 && TxtDomicilio.Text.Length == 0 && NudTelefono.Value == 0 && NudDni.Value == 0)
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
            return (socio.Nombre == TxtNombre.Text && socio.Apellido == TxtApellido.Text && socio.Dni == (int)NudDni.Value && socio.FechaNacimiento == DtpNacimiento.Value.Date && socio.Domicilio == TxtDomicilio.Text && socio.Telefono == (double)NudTelefono.Value);
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

