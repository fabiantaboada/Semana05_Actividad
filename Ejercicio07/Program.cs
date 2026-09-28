using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numAlumnos;
            do
            {
                Console.Write("Ingrese la cantidad de alumnos: ");
                numAlumnos = int.Parse(Console.ReadLine());
                if (numAlumnos <= 0)
                    Console.WriteLine("Error: La cantidad de alumnos debe ser mayor a 0.");
            } while (numAlumnos <= 0);
            int[] notas = new int[numAlumnos];
            int[] frecuencias = new int[21];
            Console.WriteLine("\nIngrese las notas (valores enteros de 0 a 20):");
            for (int i = 0; i < numAlumnos; i++)
            {
                do
                {
                    Console.Write("Nota del alumno " + (i + 1) + ": ");
                    notas[i] = int.Parse(Console.ReadLine());
                    if (notas[i] < 0 || notas[i] > 20)
                        Console.WriteLine("Error: La nota debe estar entre 0 y 20.");
                } while (notas[i] < 0 || notas[i] > 20);
                frecuencias[notas[i]]++;
            }
            int notaMasRepetida = 0;
            int maxFrecuencia = 0;
            Console.WriteLine("\nFrecuencia de notas:");
            for (int i = 0; i <= 20; i++)
            {
                if (frecuencias[i] > 0)
                    Console.WriteLine("Nota " + i + ": " + frecuencias[i] + " veces");
                if (frecuencias[i] > maxFrecuencia)
                    maxFrecuencia = frecuencias[i];
                    notaMasRepetida = i;
            }
            Console.WriteLine("\nLa nota que más se repitió fue: " + notaMasRepetida + " (con " + maxFrecuencia + " repeticiones).");
            Console.ReadKey();
        }
    }
}
