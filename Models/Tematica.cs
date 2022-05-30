using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BiblioDesktop.Models
{
    public class Tematica : ModeloBase
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Falta agregar el Nombre de la Temática")]
        public string Nombre { get; set; }
    }

}
