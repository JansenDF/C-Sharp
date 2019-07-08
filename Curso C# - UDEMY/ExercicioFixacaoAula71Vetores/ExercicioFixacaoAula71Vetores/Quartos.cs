﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoAula71Vetores
{
    class Room
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Room(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Nome}, {Email}";
        }
    }
}
