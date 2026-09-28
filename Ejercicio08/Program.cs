using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class Program
    {
        static int SUMADIG(int numero)
        {
            int suma = 0;
            int temp = numero;

            while (temp > 0)
            {
                suma = suma + (temp % 10);
                temp = temp / 10;
            }

            return suma;
        }
        static void Main()
        {
            int[] numeros = new int[10];
            Random rnd = new Random();
            int divisiblesEntre3 = 0;
            Console.Write("Datos del Vector: ");
            for (int i = 0; i < 10; i++)
            {
                numeros[i] = rnd.Next(1, 200);
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                int sumaDigitos = SUMADIG(numeros[i]);
                if (sumaDigitos % 3 == 0)
                    divisiblesEntre3++;
            }
            Console.WriteLine("Hay " + divisiblesEntre3 + " datos divisibles entre 3.");
            Console.ReadKey();
        }
    }
}
