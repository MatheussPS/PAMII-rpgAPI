using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RpgApi.Models.Enuns;
using System.Text.Json.Serialization;

namespace RpgApi.Models
{
    public class Personagem
    {
        
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int PontosVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Inteligencia { get; set; } 
        public ClasseEnum Classe { get; set; }

        [JsonIgnore]
        public Usuario? Usuario {get; set;}
        public int? UsuarioId { get; set; }

        [JsonIgnore]
        public List<Arma> Arma { get; set; } = new List<Arma>();


        public int Disputas {get; set;}
        public int Vitorias {get; set;}
        public int Derrotas {get; set;}

        public PersonagemHabilidade personagemHabilidade;
    }
}