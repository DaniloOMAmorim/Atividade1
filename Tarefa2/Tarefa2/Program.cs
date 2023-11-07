using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe qual conversor voce deseja utilizar.");
            Console.Write("[C] Fahrenheit para Celsius  [F] Celsius para Fahrenheit: ");
            char menu = Convert.ToChar(Console.ReadLine());

            if (menu == 'C' || menu == 'c')
            {
                Console.Write("Informe a temperatura em Fahrenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = (fahrenheit - 32) / 1.8;
                Console.WriteLine("A temperatura informada é de " + celsius + "°C.");
            }
            else if (menu == 'F' || menu == 'f')
            {
                Console.Write("Informe a temperatura em Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine("A temperatura informada é de " + fahrenheit + "°F.");
            }

            Console.ReadKey();
        }
    }
}
