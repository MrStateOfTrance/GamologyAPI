using GamologyAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamologyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly Models.AppDBContext _contextobd;


        public GamesController(Models.AppDBContext applicationDbContext)
        {
            _contextobd = applicationDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Models.Juegos>>> Get()
        {
            var response = await _contextobd.Games.ToListAsync();
            if (response == null)
            {
                return NotFound();
            }            
            else
            {
                return response;
            }
                
        }

        [HttpPost]
        public async Task<ActionResult<Models.Contacto>> Post(Contacto contacto)
        {
            _contextobd.Contactos.Add(contacto);
            await _contextobd.SaveChangesAsync();
            return contacto;
        }

    }
}
