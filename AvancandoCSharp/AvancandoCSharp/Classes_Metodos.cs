using System;
using System.Text;
using static System.Console;

namespace AvancandoCSharp
{

    class Carro
    {
        private string marca;
        public string Marca
        {
            get => marca;
            set => marca = value.Equals("Fusca") ? "OUTRO CARRO" : value;
        }
        private string anofrabricacao;
        public string AnoFabricacao
        {
            get => anofrabricacao;
            set => anofrabricacao = value;
        }

        public void buzinar()
        {
            WriteLine("Biii biiii!");
        }

        public void virar(string direcao)
        {
            if (direcao.Equals("D"))
            {
                WriteLine("Virando a direita!");
            }
            else
            {
                WriteLine("Virando a Esquerda!");
            }
        }
    }
    class Classes_Metodos
    {
        public void classes(string[] args)
        {
            Carro carro = new Carro();
            carro.Marca = "Civic";
            carro.AnoFabricacao = "1978";

            WriteLine($"Eu tehho um {carro.Marca} fabricado em {carro.AnoFabricacao}");

            carro.buzinar();
            carro.virar("D");
            carro.virar("E");
            ReadLine();
        }
    }
}
