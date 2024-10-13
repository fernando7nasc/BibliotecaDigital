﻿using System.Text.Json.Serialization;

namespace BibliotecaDigital.Models
{
    public class AutorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        [JsonIgnore]
        public ICollection<LivroModel> Livros { get; set; } //um autor pode ter varios livros, por isso incluido essa lista

        

    }
}
