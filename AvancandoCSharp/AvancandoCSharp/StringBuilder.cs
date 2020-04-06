using System;
using System.Text;
using static System.Console;

namespace AvancandoCSharp
{
    class StrinBuilder
    {
        public void Builder(string[] args)
        {
            //var frase = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            //frase += "Phasellus tincidunt non nibh sed tincidunt. Integer porta feugia";
            //frase += "lacus ac porttitor. Nunc et cursus nulla. Cras maximus, arcu nec volutpat tempus,";
            //frase += "arcu neque commodo nulla, et fringilla enim eros id tellus.";
            //frase += "Curabitur id nunc efficitur, dapibus risus sit amet, aliquam enim.";

            StringBuilder builder = new StringBuilder("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
            builder.Append("Phasellus tincidunt non nibh sed tincidunt. Integer porta feugia");
            builder.AppendLine("lacus ac porttitor. Nunc et cursus nulla. Cras maximus, arcu nec volutpat tempus,");
            builder.Append("arcu neque commodo nulla, et fringilla enim eros id tellus.");
            builder.Append("Curabitur id nunc efficitur, dapibus risus sit amet, aliquam enim.");

            string nome = "Vinicius Valencise";
            int idade = 19;
            double rendimento = 1500.00;
            DateTime dataCadastro = new DateTime(2015, 05, 20);

            StringBuilder frase = new StringBuilder("\n \nO cliente {0} tem {1} anos de idade e tem rendimento de {2:c}");
            frase.Append(" e é cliente desde {3:dd/MM/yyyy}");

            builder.AppendFormat(frase.ToString(), nome, idade, rendimento, dataCadastro);



            WriteLine(builder);

            ReadLine();
        }
    }
}
