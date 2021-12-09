using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GamologyAPI.Models
{
    public class Juegos
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public string Desarrollador { get; set; }
        [Required]
        public string Distribuidor { get; set; }
        [Required]
        public string Fechalanzamiento { get; set; }
        [Required]
       
        public string Plataforma { get; set; }
     
   
    }
}
