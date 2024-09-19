using System;

namespace exercicioPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno douglas = new Aluno();
            douglas.nome = "Douglas";
            douglas.nota1 = 8;
            douglas.nota2 = 10;

            douglas.exibeMensagem();
        }
    }
}