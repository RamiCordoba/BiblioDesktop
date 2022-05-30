using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BiblioDesktop.Models
{
    public class Socio : ModeloBase
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Falta agregar Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Falta agregar Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Falta agregar DNI")]
        public int Dni { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Falta agregar Domicilio")]
        public string Domicilio { get; set; }

        [Required(ErrorMessage = "Falta agregar Teléfono")]
        public double Telefono { get; set; }

        public byte[] Imagen { get; set; }
        public ICollection<Prestamo> Prestamos { get; set; }

    }
}
