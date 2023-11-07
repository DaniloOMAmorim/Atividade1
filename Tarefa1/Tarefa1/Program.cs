using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o ano que você nasceu: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            int idade = DateTime.Now.Year - ano;

            if (idade > 18)
            {
                Console.WriteLine("Maior de idade");
            }
            else
            {
                Console.WriteLine("Menor de idade");
            }

            Console.ReadKey();
        }
    }
}
