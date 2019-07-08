using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropostoAula136.Entities
{
    class Fisica : Pessoa
    {
        public double DespesaSaude { get; set; }

        public Fisica()
        {
        }

        public Fisica(string nome, double rendaAnual, double despesaSaude) : base(nome, rendaAnual)
        {
            DespesaSaude = despesaSaude;
        }
        public override double Imposto()
        {
            if (RendaAnual <= 20000)
            {
                if(DespesaSaude > 0)
                {
                    double x = DespesaSaude / 2;
                    return RendaAnual * 0.15 - x;
                }
                return RendaAnual * 0.15;
            }
            else
            {
                if (DespesaSaude > 0)
                {
                    double x = DespesaSaude / 2;
                    return RendaAnual * 0.25 - x;
                }
                return RendaAnual * 0.25;
            }
        }
    }
}
