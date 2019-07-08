using System;
using System.Globalization;

namespace Exercicio3ClassesAtributosEMetodos
{
    class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;
        public double NotaFinal;

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }
        public override string ToString()
        {
            if (CalcularNotaFinal() >= 60) {
                return "APROVADO";
            }
            else
            {
                double falta = 60 - CalcularNotaFinal();
                return $"REPROVADO FALTARAM {falta.ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
            }
        }

    }
}
