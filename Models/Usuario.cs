using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BiblioDesktop.Models
{
   public class Usuario : ModeloBase
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string User { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public TipoUsuarioEnum TipoUsuario { get; set; }
        public override string  ToString() { return (Nombre); }
    }
}
