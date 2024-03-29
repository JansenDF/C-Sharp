﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropostoAula136.Entities
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAnual { get; protected set; }

        public Pessoa()
        {
        }
        public Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Imposto();
    }
}
