using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] pesos = new double[10];
            double sumaPesos = 0;
            int delgadas = 0;
            int medianas = 0;
            int gruesas = 0;
            Console.WriteLine("Ingrese el peso de los 10 clientes del gimnasio:");
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write("Peso del cliente " + (i + 1) + " (en kilos): ");
                    pesos[i] = double.Parse(Console.ReadLine());
                    if (pesos[i] <= 0)
                        Console.WriteLine("Error: El peso debe ser un valor positivo mayor a 0. Intente nuevamente.");

                } while (pesos[i] <= 0);
            }
            for (int i = 0; i < 10 - 1; i++)
            {
                int indiceMenor = i;

                for (int j = i + 1; j < 10; j++)
                {
                    if (pesos[j] < pesos[indiceMenor])
                        indiceMenor = j;
                }
                if (indiceMenor != i)
                {
                    double temp = pesos[i];
                    pesos[i] = pesos[indiceMenor];
                    pesos[indiceMenor] = temp;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                sumaPesos = sumaPesos + pesos[i];

                if (pesos[i] < 53)
                    delgadas++;
                else if (pesos[i] >= 53 && pesos[i] <= 60)
                    medianas++;
                else if (pesos[i] > 60)
                    gruesas++;
            }
            double promedio = sumaPesos / 10.0;
            double mayorPeso = pesos[9];
            Console.WriteLine("\n--- Resultados Estadísticos ---");
            Console.WriteLine("El peso promedio es: " + promedio + " kilos");
            Console.WriteLine("El peso de la persona que pesa más es: " + mayorPeso + " kilos");
            Console.WriteLine("Personas de contextura delgada: " + delgadas);
            Console.WriteLine("Personas de contextura mediana: " + medianas);
            Console.WriteLine("Personas de contextura gruesa: " + gruesas);
            Console.ReadKey();
        }
    }
}
