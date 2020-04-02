using System.Globalization;
using static System.Console;
namespace AvancandoCSharp
{
    class funcoes_string
    {
        public void funcoes_strings(string[] args)
        {

            string frase = "Hoje à noite, sem luz, decidi xeretar a quinta gaveta de vovô: achei lingüiça, pão e fubá";

            //string frase_trocada = frase.Replace("vovô", "mamãe");
            string frase_trocada = frase.Replace("VOVô", "mamãe", true, CultureInfo.CurrentCulture);

            WriteLine(frase_trocada);



            //WriteLine(frase.ToUpper());
            //WriteLine(frase.ToLower());


            //string subFrase = "achei";
            //int posInicial = frase.IndexOf(subFrase);
            //int posFinal = 10;

            //string sub = frase.Substring(posInicial);

            //WriteLine(sub);


            //int pos = frase.IndexOf(subFrase);
            //WriteLine(pos);





            //var achou = frase.Contains(subFrase);
            //WriteLine(achou);

            //WriteLine(frase.Length); //Contar quantos caracteres

            //string[] partes = frase.Split(",");

            //for (var i = 0; i < partes.Length; i++)
            //{
            //  WriteLine(partes[i].Trim());
            //}



        }
    }
}
