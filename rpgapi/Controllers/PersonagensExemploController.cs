using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rpgapi.models;
using rpgapi.Models.Enums;

namespace rpgapi.Controllers
{
    [ApiController]
    [Route("[controller]")] 

    public class PersonagensExemploController : ControllerBase
    {
        private static List<Personagem> personagens = new List<Personagem>()
        {
            new Personagem() { Id = 1, Nome = "Frodo", PontosVida=100, Forca=17, Defesa=23, Inteligencia=33, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=100, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=100, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago }
        };

        // a) Feito por Matheus Pinter e Paulo Sergio 
            [HttpGet("GetByNome/{nome}")]
            public IActionResult GetByNome(string nome)
            {
                // Pode ter mais que um com o mesmo nome
                var personagem = personagens.Where(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase)).ToList();

                return personagem.Count != 0? Ok(personagem):NotFound($"Personagem '{nome}' não encontrado.");
            }
       // b)
            [HttpGet("GetClerigoMago")]
            public IActionResult GetClerigoMago(){
                // Considerando que só tenham as 3 classes feitas em aula
                var listaCM = personagens.Where(p => p.Classe != ClasseEnum.Cavaleiro).OrderByDescending(p => p.PontosVida).ToList();

                // Caso contrario (surgiimento de mais classes) -> var listaCM = personagens.Where(p => p.Classe == ClasseEnum.Clerigo || p.Classe == ClasseEnum.Mago).OrderByDescending(p => p.PontosVida).ToList();

                return listaCM.Count != 0? Ok(listaCM): NotFound("Não foi encontrado nenhum Clerigo ou Mago");
            }
        // c)
            [HttpGet("GetEstatisticas")]
            public IActionResult GetEstatisticas(){
                return Ok(new {ContagemPersonagens = personagens.Count,
                        SomaInteligencia = personagens.Sum(p => p.Inteligencia)
                        });
            }
        // d)
            [HttpPost("PostValidacao")]
            public IActionResult PostValidacao(Personagem novoPersonagem){
                if (novoPersonagem.Inteligencia<=30 && novoPersonagem.Defesa>=10){
                    personagens.Add(novoPersonagem);
                    return Ok(new { Mensagem = "Personagem Adicionado", Lista = personagens });

                }
                return BadRequest("Informações inválidas");
            }
        // e)
            [HttpPost("PostValidacaoMago")]
            public IActionResult PostValidacaoMago(Personagem novoPersonagem){
                if (novoPersonagem.Classe == ClasseEnum.Mago && novoPersonagem.Inteligencia<=35){
                    personagens.Add(novoPersonagem);
                    return Ok(new { Mensagem = "Personagem Adicionado", Lista = personagens });

                }
                return BadRequest("Informações inválidas");
            }
        // f)
            [HttpGet("GetByClasse/{id}")]
            public IActionResult GetByClasse(int id)
            {
                if (!Enum.IsDefined(typeof(ClasseEnum), id))
                {
                    return BadRequest("Insira um ID válido.");
                }

                ClasseEnum enumDigitado = (ClasseEnum)id;
                List<Personagem> listabusca = personagens.FindAll(p => p.Classe == enumDigitado).ToList();
                return Ok(listabusca);
            }

        }
}
