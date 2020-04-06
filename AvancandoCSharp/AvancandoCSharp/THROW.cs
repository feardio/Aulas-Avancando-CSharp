using System;
using static System.Console;

namespace AvancandoCSharp
{
    class Pessoa
    {
        private string _nome;
        public string Nome { get; set; }

        private int _idade;
        public int Idade
        {
            get => _idade;
            set => _idade = value < 0 || value > 120 ? throw new Exception("Idade Inválida") : value;
        }
    }
    class THROW
    {
        public void Throw(string[] args)
        {
            try
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Nome = "Vinicius Valencise";
                pessoa.Idade = 20;
                WriteLine($"{ pessoa.Nome} - {pessoa.Idade}");
                //throw new Exception("Deu erro em alguma coisa");

            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
            ReadLine();
        }
    }
}
