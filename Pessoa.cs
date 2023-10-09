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

        private int idade;
        public int Idade
        {
            get { this.Calc(); return this.idade; }
        }
        

        public void ShowData()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Ano de Nascimento: {this.AnoNascimento}");
            this.Calc();
            Console.WriteLine($"Idade: {this.Idade} anos");
        }

        private void Calc()
        {
            DateTime date = DateTime.Now;
            int ano = date.Year;
            this.idade = ano - this.AnoNascimento;
        }
    }
}