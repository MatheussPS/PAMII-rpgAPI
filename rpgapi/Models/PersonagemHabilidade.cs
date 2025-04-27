using System.Text.Json.Serialization;

namespace RpgApi.Models
{
    public class PersonagemHabilidade
    {
        public int PersonagemId { get; set; }
        [JsonIgnore]
        public Personagem? Personagem { get; set; }

        public int HabilidadeId { get; set; }
        [JsonIgnore]
        public Habilidade? Habilidade { get; set; }

        public static implicit operator List<object>(PersonagemHabilidade? v)
        {
            throw new NotImplementedException();
        }
    }
}
