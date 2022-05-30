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
    public partial class FrmListaLibros : Form
    {
        private readonly ReportViewer reporte;
        public FrmListaLibros()
        {
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        private void FrmListaSocios_Load(object sender, EventArgs e)
        {
            using var fs = new FileStream(@"C:\BiblioDesktop\BiblioDesktop\Reportes\ReporteLibros.rdlc", FileMode.Open);
            reporte.LocalReport.LoadReportDefinition(fs);
            using var db = new BiblioDesktopContext();
            var listaLibros = from libro in db.Libros
                              join tematica in db.Tematicas
                              on libro.Tematica.Nombre equals tematica.Nombre
                              select new
                              {
                                  Titulo = libro.Titulo,
                                  Autor = libro.Autor,
                                  Editorial = libro.Editorial,
                                  Tematica = libro.Tematica.Nombre
                              };
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSLibros", listaLibros.ToList()));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.RefreshReport();
        }
    }
}
