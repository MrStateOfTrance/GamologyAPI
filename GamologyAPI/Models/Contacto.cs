using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GamologyAPI.Models
{
    public class Contacto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Telefono { get; set; }
       



    }
}
