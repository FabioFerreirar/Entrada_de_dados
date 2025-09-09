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
            Console.WriteLine("Digite seu nome:");
            string Nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            UInt16 Idade = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Digite o número do seu documento");
            string Documento = Console.ReadLine();

            Console.WriteLine("Digite o nome da sua rua: ");
            string NomeDaRua = Console.ReadLine();

            Console.WriteLine("Digite o número da sua casa: ");
            UInt32 NumeroDaCasa = Convert.ToUInt32(Console.ReadLine());
            
            string Genero = "";

            while (Genero != "M" && Genero != "F")
            {
                Console.WriteLine("Informe seu gênero. Pressione F para feminino e M para mascuilino");
                Genero = Console.ReadKey(true).KeyChar.ToString().ToUpper();
                
                if (Genero != "M" && Genero != "F")
                {
                    Console.WriteLine("\nEntrada inválida. Você digitou " + Genero + " Tente novamente.\n");
                }
            }
            


            Console.WriteLine("Olá, " + Nome + "! Você tem " + Idade + " anos, seu documento é " + Documento + ", você mora na rua " + NomeDaRua + ", número " + NumeroDaCasa + " e seu gênero é " + Genero);
        }
    }
}
