using System;
using static System.Console;

namespace AvancandoCSharp
{

    public struct Cliente
    {
        public int matricula;
        public string nome;
        public string email;


        public void digaoi()
        {
            WriteLine($"oi {this.nome}");
        }
    }

    class STRUCTS
    {
        static void structs(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.matricula = 123;
            cliente.nome = "Vinicius Valencise";
            cliente.email = "vinicius@email.com";

            cliente.digaoi();

            ReadLine();
        }
    }
}
