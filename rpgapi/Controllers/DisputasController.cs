using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RpgApi.Data;
using RpgApi.Models;

namespace rpgapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DisputasController : ControllerBase
    {
        private readonly DataContext _context;

        public DisputasController(DataContext context){
            _context = context;
        }

        [HttpPost("Arma")]

        public async Task<IActionResult> AtaqueComArmaAsync(Disputa d){
            try{
                Personagem? atacante = await _context.TB_PERSONAGENS.
                Include(p => p.Arma).
                FirstOrDefaultAsync(p =>p.Id == d.AtacanteId);

                Personagem? oponente = await _context.TB_PERSONAGENS.FirstOrDefaultAsync(p => p.Id == d.OponenteId);

                return Ok(d);
            }catch(Exception e){
                return BadRequest(e.Message);
            }
        }
    }
}