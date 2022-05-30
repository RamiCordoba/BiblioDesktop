using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BiblioDesktop.Models;
using Microsoft.Reporting.WinForms;

namespace BiblioDesktop.Presentation
{
    public partial class FrmListaSocios : Form
    {
        private readonly ReportViewer reporte;
        public FrmListaSocios()
        {
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        private void FrmListadoSocios_Load(object sender, EventArgs e)
        {
            using var fs = new FileStream(@"C:\BiblioDesktop\BiblioDesktop\Reportes\ReporteSocios.rdlc", FileMode.Open);
            reporte.LocalReport.LoadReportDefinition(fs);
            using var db = new BiblioDesktopContext();
            var listaSocios = from socio in db.Socios
                              select new
                              {
                                  ID = socio.Id,
                                  Apellido = socio.Apellido,
                                  Nombre = socio.Nombre,
                                  Dni = socio.Dni,
                                  FechaNacimiento = socio.FechaNacimiento,
                                  Domicilio = socio.Domicilio,
                                  Telefono = socio.Telefono,
                              };
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSSocios", listaSocios.ToList()));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.RefreshReport();
        }
    }
}
