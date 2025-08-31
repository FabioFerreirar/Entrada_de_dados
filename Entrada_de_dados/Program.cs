using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_de_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Olá  " + Nome);
            Console.WriteLine("Digite a sua idade");
            string Idade = Console.ReadLine();
            Console.WriteLine("Você tem " + Idade + " anos");
            Console.ReadKey();
        }
    }
}
