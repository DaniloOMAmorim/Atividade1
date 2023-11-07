using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe uma senha: ");
            string senha = Console.ReadLine();
            bool valida = true;

            if (senha.Length < 8)
            {
                Console.WriteLine("A senha tem que ter mais de 8 digitos.");
                valida = false;
            }

            if (!senha.Any(char.IsUpper))
            {
                Console.WriteLine("A senha tem que ter letra maiúscula");
                valida = false;
            }

            if (!senha.Any(char.IsLower))
            {
                Console.WriteLine("A senha tem que ter letra minúscula");
                valida = false;
            }

            if (!senha.Any(char.IsNumber))
            {
                Console.WriteLine("A senha tem que ter um numero");
                valida = false;
            }

            if (valida)
            {
                Console.WriteLine("Senha é valida!");
            }
            else
            {
                Console.WriteLine("Senha não é valida!");
            }

            Console.ReadKey();

        }
    }
}
