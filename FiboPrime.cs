using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiboPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prime;
            int a = 0;
            int b = 1;
            int aux = 1;

            Console.WriteLine("Ingrese la cantidad de num:");
            int lim = int.Parse(Console.ReadLine());

            for (int j = 0; j < lim; j++)
            {
                aux = a + b;
                a = b;
                b = aux;
               

                for ( j = 2; j < lim; j++)
                {
                    if (b % j == 0)
                    { 
                    prime = false;
                    }
                }
                if (prime = false)
                {
                    Console.WriteLine(b + " No es primo");
                   
                }
                else
                {
                     Console.WriteLine(b + " Es primo");
                }

                if (b % 2 == 0)
                {
                    Console.WriteLine(b + " Es par");
                }
                else
                {
                    Console.WriteLine(b + " Es impar");
                }
            }
        }
    }
}
