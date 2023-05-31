using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int dia, mes, ano, idade;

            Console.Clear();
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Olá " + nome);

            Console.WriteLine("Digite o seu dia de nascimento:");
            dia = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o seu mês de nascimento:");
            mes = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o seu ano de nascimento:");
            ano = Convert.ToInt16(Console.ReadLine());
            
            Console.Clear();

            idade = 2021 - ano;

            if (idade >= 18)
            {
                Console.WriteLine("Senha sugerida: " + idade + nome);
            }
            else
            {
                Console.WriteLine("Senha sugerida: " + nome + idade);
            }
        }
    }
}
