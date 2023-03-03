using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese ancho, alto y si el rectángulo está relleno (1: sí, 0: no), separados por comas:");
            string[] input = Console.ReadLine().Split(',');
            int ancho = int.Parse(input[0]);
            int alto = int.Parse(input[1]);
            bool relleno = int.Parse(input[2]) == 1;

            // Si ancho y alto son iguales, dibujar cuadrado
            if (ancho == alto)
            {
                for (int i = 0; i < alto; i++)
                {
                    for (int j = 0; j < ancho; j++)
                    {
                        if (relleno || i == 0 || j == 0 || i == alto - 1 || j == ancho - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < alto; i++)
                {
                    for (int j = 0; j < ancho; j++)
                    {
                        if (relleno || i == 0 || j == 0 || i == alto - 1 || j == ancho - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        

    }
    }
}
