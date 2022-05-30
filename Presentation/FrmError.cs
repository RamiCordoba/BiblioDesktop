using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BiblioDesktop.Presentation
{
    public partial class FrmError : Form
    {
        public FrmError(Exception exception)
        {
            InitializeComponent();
            TxtNumeroError.Text = exception.HResult.ToString();
            TxtMensajeError.Text = exception.Message;
            TxtCodigo.Text = exception.Source;
            TxtPilaDeLlamada.Text = exception.StackTrace;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
