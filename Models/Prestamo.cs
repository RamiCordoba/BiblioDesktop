using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BiblioDesktop.Models
{
    public class Prestamo : ModeloBase
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Falta agregar Fecha Retiro")]
        public DateTime FechaRetiro { get; set; }

        [Required(ErrorMessage = "Falta agregar Fecha Entrega")]
        public DateTime FechaEntrega { get; set; }

        public int SocioId { get; set; }

        [Required(ErrorMessage = "Falta agregar Socio")]
        public Socio Socio { get; set; }

        public int IdLibro { get; set; }
        public Libro Libro { get; set; }
        public Boolean LibroDevuelto { get; set; }

    }
}
