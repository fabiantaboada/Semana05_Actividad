using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[6];
            double suma = 0;
            Console.WriteLine("Ingrese las 6 notas del alumno (entre 0 y 20):");
            for (int i = 0; i < 6; i++)
            {
                do
                {
                    Console.Write("Nota " + (i + 1) + ": ");
                    notas[i] = double.Parse(Console.ReadLine());

                    if (notas[i] < 0 || notas[i] > 20)
                    {
                        Console.WriteLine("Error: La nota debe estar entre 0 y 20. Intente nuevamente.");
                    }

                } while (notas[i] < 0 || notas[i] > 20);
            }
            for (int i = 0; i < 6 - 1; i++)
            {
                for (int j = 0; j < 6 - i - 1; j++)
                {
                    if (notas[j] > notas[j + 1])
                    {
                        double temp = notas[j];
                        notas[j] = notas[j + 1];
                        notas[j + 1] = temp;
                    }
                }
            }
            for (int i = 1; i < 6; i++)
            {
                suma = suma + notas[i];
            }
            double promedio = suma / 5.0;
            Console.WriteLine("La nota eliminada es: " + notas[0]);
            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadKey();
        }
    }
}
