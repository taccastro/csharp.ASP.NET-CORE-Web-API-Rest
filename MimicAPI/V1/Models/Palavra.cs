﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MimicAPI.V1.Models
{
    public class Palavra
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }
        [Required]
        public int Pontuacao { get; set; }
        public bool Ativo { get; set; }
        public DateTime Criado { get; set; }
        public DateTime? Atualizado { get; set; }
    }
}
