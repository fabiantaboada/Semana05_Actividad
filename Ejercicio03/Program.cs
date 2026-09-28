using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.Write("Ingrese el número de personas N: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0 || n > 100)
                    Console.WriteLine("Error: La cantidad de personas debe ser mayor a 0 y no mayor a 100.");
            } while (n <= 0 || n > 100);
            int[] edades = new int[n];
            Random rnd = new Random();
            Console.WriteLine("\nListado de edades generadas al azar:");
            for (int i = 0; i < n; i++)
            {
                edades[i] = rnd.Next(1, 100);
                Console.Write(edades[i] + " ");
            }
            Console.WriteLine();
            int menorEdad = edades[0];
            int posMenor = 0,entre30y50=0;
            for (int i = 0; i < n; i++)
            {
                if (edades[i] < menorEdad)
                {
                    menorEdad = edades[i];
                    posMenor = i;
                }

                if (edades[i] >= 30 && edades[i] <= 50)
                {
                    entre30y50++;
                }
            }
            Console.WriteLine("\nLa menor edad generada es " + menorEdad + " y se encuentra en la posición en el arreglo es " + posMenor);
            Console.WriteLine("Número de personas que tienen entre 30 y 50 años: " + entre30y50);
            for (int i = 0; i < n - 1; i++)
            {
                int indiceMenor = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (edades[j] < edades[indiceMenor])
                    {
                        indiceMenor = j;
                    }
                }
                if (indiceMenor != i)
                {
                    int temp = edades[i];
                    edades[i] = edades[indiceMenor];
                    edades[indiceMenor] = temp;
                }
            }
            Console.WriteLine("\nListado de edades ordenadas de menor a mayor:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(edades[i] + " ");
            }
            Console.WriteLine();

            Console.Write("\nIngrese una edad a buscar en el arreglo: ");
            int edadBuscar = int.Parse(Console.ReadLine());
            bool encontrada = false;
            for (int i = 0; i < n; i++)
            {
                if (edades[i] == edadBuscar)
                {
                    encontrada = true;
                }
            }
            if (encontrada)
            {
                Console.WriteLine("La edad SÍ fue encontrada en el arreglo.");
            }
            else
            {
                Console.WriteLine("La edad NO fue encontrada en el arreglo.");
            }
            Console.ReadKey();
        }
    }
}
