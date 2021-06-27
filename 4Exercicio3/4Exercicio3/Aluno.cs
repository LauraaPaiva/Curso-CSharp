using System;
using System.Collections.Generic;
using System.Text;

namespace _4Exercicio3
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string Resultado()
        {
            double faltaram = 60 - NotaFinal();

            if (NotaFinal() >= 60)
            { return "APROVADO"; }
            else
            { return "REPROVADO \n" + "FALTARAM " + faltaram; };

        }


    }

}
