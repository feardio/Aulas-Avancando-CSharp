using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace AvancandoCSharp
{

    class Veiculo
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

    }
        class Program
        {
            static void Main(string[] args)
            {
                ArrayList arrayList = new ArrayList();
                arrayList.Add("Vinicius");
                arrayList.Add(20);
                arrayList.Add(new object());


                List<string> dias = new List<string>();
                dias.Add("Dom");
                dias.Add("Seg");
                dias.Add("Ter");
                dias.Add("Qua");
                dias.Add("Qui");
                dias.Add("Sex");
                dias.Add("Sab");


                // foreach(string dia in dias)
                // {
                //    WriteLine(dia);         
                //}

                List<Veiculo> veiculos = new List<Veiculo>();

                Veiculo carro = new Veiculo();
                carro.Marca = "Civic";
                carro.AnoFabricacao = "2007";
                veiculos.Add(carro);

                Veiculo carro1 = new Veiculo();
                carro1.Marca = "Fusca";
                carro1.AnoFabricacao = "1978";
                veiculos.Add(carro1);
                Veiculo carro2 = new Veiculo();
                carro2.Marca = "Gol";
                carro2.AnoFabricacao = "1980";
                veiculos.Add(carro2);

                foreach (Veiculo veiculo in veiculos)
                {
                    WriteLine($"Eu tehho um {veiculo.Marca} fabricado em {veiculo.AnoFabricacao}");
                }

                ReadLine();
            }
        }
    }
