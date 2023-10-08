using System;

namespace CalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de idade");
            Pessoa pessoa = new Pessoa();
            
            Console.WriteLine("Nome da pessoa: ");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Ano de nascimento: ");
            pessoa.AnoNascimento = Convert.ToInt32(Console.ReadLine());

            pessoa.ShowData();
        }
    }
}
