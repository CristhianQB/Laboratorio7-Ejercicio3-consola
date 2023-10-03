using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7_Ejercicio3_consola1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los años bisiestos desde el año 1900 son :");

            for (int i = 1900; i <= 2023; i++)
            {
                Console.Write(i +", ") ;
                i = i + 3 ;
            }

            Console.ReadKey();
        }
    }
}
