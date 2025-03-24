using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rpgapi.Data;
using rpgapi.models;


namespace RPGAPITREINO.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class PersonagemController :ControllerBase{
        private readonly DataContext _context;

        public PersonagemController(DataContext context)
        {
            _context = context;            
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(){
            try{
                
                List<Personagem> personagens = await _context.TB_PERSONAGENS.ToListAsync();
                
                return Ok(personagens);

            }catch(SystemException e){
                return BadRequest(e.Message);
            }
        }

        [HttpGet("GetByName/{nome}")]
        public async Task<IActionResult> GetByName(string nome){
            try{
               Personagem personagem = await _context.TB_PERSONAGENS.FirstOrDefaultAsync(p => p.Nome.ToLower() == nome.ToLower());
                return Ok(personagem);
            }catch(SystemException e){
                return BadRequest(e.Message);
            }
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetSingle(int id){
            try{
               Personagem personagem = await _context.TB_PERSONAGENS.FirstOrDefaultAsync(p => p.Id == id);
                return Ok(personagem);
            }catch(SystemException e){
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(Personagem novoPersonagem){
            try{
                if (novoPersonagem.PontosVida > 100){
                    throw new Exception("Pontos de vida não pode ser maior que 100");
                }

                await _context.TB_PERSONAGENS.AddAsync(novoPersonagem);
                int linhasAfetadas = await _context.SaveChangesAsync();  // Salva no banco e obtém o número de linhas afetadas

                 return Ok(linhasAfetadas);  // Retorna o número de linhas afetadas
            }
            catch(System.Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Personagem novoPersonagem){
            try{
                if (novoPersonagem.PontosVida > 100){
                    throw new Exception("Pontos de vida não pode ser maior que 100");
                }

                _context.TB_PERSONAGENS.Update(novoPersonagem);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch(System.Exception ex){
                return BadRequest(ex.Message);
            }
        } 


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteSingle(int id){
            try{
               Personagem personagem = await _context.TB_PERSONAGENS.FirstOrDefaultAsync(p => p.Id == id);
               _context.TB_PERSONAGENS.Remove(personagem);
               int linhasAfetadas = await _context.SaveChangesAsync();
                return Ok(linhasAfetadas);
            }catch(SystemException e){
                return BadRequest(e.Message);
            }
        }

    }
}