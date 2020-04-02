using System;
using static System.Console;

namespace AvancandoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome = "Vinicius Valencise";
            int idade = 19;
            double rendimento = 1500.00;
            DateTime dataCadastro = new DateTime(2015, 05, 20);

          string str = "O cliente {0} tem {1} anos de idade e tem rendimento de {2:c}";
            str += " e é cliente desde {3:dd/MM/yyyy}";
            string frase = String.Format(str, nome, idade, rendimento, dataCadastro);

            WriteLine(frase);

        }
    }
}
