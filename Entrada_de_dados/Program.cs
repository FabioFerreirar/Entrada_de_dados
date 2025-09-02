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
            int IdadeInteiro = Convert.ToInt32(Idade);
            Console.WriteLine("Pressione qualauer tecla");
            char TeclaPressionada = Console.ReadKey(true).KeyChar;
            Console.WriteLine("Você pressionou a tecla: " + TeclaPressionada);

            Console.ReadKey();  // inserção de um comando para pausar a execução do programa
            // Teste de tentativa direta da branch principal do repositório remoto protegida.
            // Segundo teste de tentativa direta da branch principal do repositório remoto protegida.
        }
    }
}
