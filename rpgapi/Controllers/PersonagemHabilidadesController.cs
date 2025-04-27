using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RpgApi.Data;
using RpgApi.Models;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonagemHabilidadesController : ControllerBase
    {
        private readonly DataContext _context;

        public PersonagemHabilidadesController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddPersonagemHabilidadeAsync(PersonagemHabilidade novoPersonagemHabilidade)
        {
            try
            {
                Personagem personagem = await _context.TB_PERSONAGENS
                    .Include(p => p.Arma)
                    .Include(p => p.personagemHabilidade).ThenInclude(ps => ps.Habilidade)
                    .FirstOrDefaultAsync(personagem => personagem.Id == novoPersonagemHabilidade.PersonagemId);

                Habilidade habilidade = await _context.TB_HABILIDADES
                    .FirstOrDefaultAsync(h => h.Id == novoPersonagemHabilidade.HabilidadeId);

                if (habilidade == null)
                    throw new Exception("Habilidade não encontrada.");

                PersonagemHabilidade ph = new PersonagemHabilidade
                {
                    Personagem = personagem,
                    Habilidade = habilidade
                };
                await _context.TB_PERSONAGENS_HABILIDADES.AddAsync(ph);
                await _context.SaveChangesAsync();

                return Ok(ph);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Personagem p = await _context.TB_PERSONAGENS
                    .Include(ar => ar.Arma)
                    .Include(ph => ph.personagemHabilidade)
                        .ThenInclude(h => h.Habilidade)
                    .FirstOrDefaultAsync(pBusca => pBusca.Id == id);

                if (p == null)
                    return NotFound("Personagem não encontrado.");

                return Ok(p);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetHabilidadesPersonagem/{idPersonagem}")]
        public async Task<IActionResult> GetHabilidadesPersonagem(int idPersonagem)
        {
            try
            {
                List<PersonagemHabilidade> habilidades = await _context.TB_PERSONAGENS_HABILIDADES
                    .Include(ph => ph.Habilidade)
                    .Where(ph => ph.Personagem.Id == idPersonagem)
                    .ToListAsync();

                return Ok(new{IdPersonagem = idPersonagem, Habilidades = habilidades});
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetHabilidades")]
        public async Task<IActionResult> GetHabilidades()
        {
            try
            {
                List<Habilidade> habilidades = await _context.TB_HABILIDADES.ToListAsync();
                return Ok(habilidades);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("DeletePersonagemHabilidade")]
        public async Task<IActionResult> DeletePersonagemHabilidade(PersonagemHabilidade ph)
        {
            try
            {
                var phRemover = await _context.TB_PERSONAGENS_HABILIDADES
                    .FirstOrDefaultAsync(p => p.PersonagemId == ph.PersonagemId && p.HabilidadeId == ph.HabilidadeId);

                if (phRemover == null)
                    return NotFound("PersonagemHabilidade não encontrado.");

                _context.TB_PERSONAGENS_HABILIDADES.Remove(phRemover);
                await _context.SaveChangesAsync();

                return Ok("PersonagemHabilidade removido com sucesso.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
