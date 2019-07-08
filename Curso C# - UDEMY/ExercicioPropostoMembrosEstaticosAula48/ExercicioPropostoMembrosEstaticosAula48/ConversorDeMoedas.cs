using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropostoMembrosEstaticosAula48
{
    class ConversorDeMoedas
    {
        public static double Conversor(double cot, double qtd)
        {
            return cot * qtd + ((cot * qtd / 100)*6);
        }
    }
}
