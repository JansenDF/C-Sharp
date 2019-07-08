using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropostoAula136.Entities
{
    class Juridica : Pessoa
    {
        public int NumeroFuncionarios { get; set; }

        public Juridica()
        {
        }
        public Juridica(string nome, double rendaAnual, int numeroFuncionarios) : base (nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }
        public override double Imposto()
        {
            if(NumeroFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
