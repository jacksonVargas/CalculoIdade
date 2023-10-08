using System;
using System.Data;

namespace CalculaIdade
{
    class Pessoa
    {
        private int anoNascimento;

        public int AnoNascimento
        {
            get { return anoNascimento; }
            set { this.anoNascimento = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { this.nome = value.ToUpper(); }
        }

        public void ShowData()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Ano de Nascimento: {this.AnoNascimento}");
            int idade = this.Calc();
            Console.WriteLine($"Idade: {idade}");
        }

        private int Calc()
        {
            DateTime date = DateTime.Now;
            int ano = date.Year;
            int idade = ano - this.AnoNascimento;
            return idade;
        }
    }
}