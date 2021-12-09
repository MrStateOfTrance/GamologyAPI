using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamologyAPI.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) :base(options)
        {
            
        }
        public DbSet<Juegos> Games { get; set; }
        public DbSet<Contacto> Contactos { get; set; }



    }
}
