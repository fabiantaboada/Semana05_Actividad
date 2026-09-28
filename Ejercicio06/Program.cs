using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Program
    {
        static public int[] generar_datos(int n, int valmin, int valmax)
        {
            int[] N = new int[n];
            Random var_random = new Random();
            for (int i = 0; i < n; i++)
            {
                N[i] = var_random.Next(valmin, valmax + 1);
            }
            return N;
        }
        static public void ordenar_seleccion(int[] N)
        {
            int aux;
            for (int i = 0; i < N.Length - 1; i++)
            {
                int minimo = i;
                for (int j = i + 1; j < N.Length; j++)
                {
                    if (N[j] < N[minimo])
                        minimo = j;
                }
                aux = N[i];
                N[i] = N[minimo];
                N[minimo] = aux;
            }
        }
        static public void imprimir(int[] N)
        {
            for (int i = 0; i < N.Length; i++)
            {
                Console.Write("[" + N[i] + "]\t");
            }
            Console.WriteLine();
        }
        static public void contar_rango(int[] N)
        {
            int c = 0;
            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] >= 100 && N[i] <= 300)
                    c++;
            }
            Console.WriteLine("Personas que gastaron entre 100 y 300 son: " + c);
        }
        static public void impar(int[] N)
        {
            int c = 0;
            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] % 2 != 0)
                    c++;
            }
            Console.WriteLine("Cantidad de montos impares: " + c);
        }
        static void Main(string[] args)
        {
            int d;
            bool esValido;
            do
            {
                Console.Write("Ingresar el número de personas: ");
                esValido = int.TryParse(Console.ReadLine(), out d);
                if (esValido == false || d <= 0 || d > 200)
                {
                    Console.WriteLine("Error: Por favor ingrese un número válido entre 1 y 200.\n");
                    esValido = false;
                }
            } while (esValido == false);
            int[] montos = generar_datos(d, 25, 500);
            Console.WriteLine("Lista de Arreglo");
            imprimir(montos);
            Console.WriteLine("\nLista Ordenada ascendentemente");
            ordenar_seleccion(montos);
            imprimir(montos);
            contar_rango(montos);
            impar(montos);
            Console.ReadKey();
        }
    }
}
