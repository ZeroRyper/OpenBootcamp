using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_tema_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIf = -2;
            int numeroWhile = 0;
            Console.WriteLine("Usando un if");
            if (numeroIf>0)
            {
                Console.WriteLine(numeroIf+" Es positivo");
            }
            else if(numeroIf<0)
            {
                Console.WriteLine(numeroIf + " Es negativo");

            }
            else
            {
                Console.WriteLine(numeroIf+" Es zero");

            }
            ///
            Console.WriteLine("Crea un bucle While");

            while (numeroWhile < 3)
            {
                Console.WriteLine(numeroWhile);
                numeroWhile++;

            }
            ///Para el bucle Do While 
            Console.WriteLine("Crea un bucle While");
            do
            {
                Console.WriteLine(numeroWhile);
                numeroWhile++;

            } while (numeroWhile < 3);
            ///Para el bucle For
            Console.WriteLine("Para el bucle For");
            for (int numeroFor=0; numeroFor<=3; numeroFor++)
            {
                Console.WriteLine(numeroFor);
            }
            //Switch
            Console.WriteLine("Switch");
            String estacion = "Invierno";
            switch (estacion)
            {
                case "Verano":
                    Console.WriteLine("Verano");
                    break;
                case "Invierno":
                    Console.WriteLine("Invierno");
                    break;
                case "Otoño":
                    Console.WriteLine("Otoño");
                    break;
                case "Primavera":
                    Console.WriteLine("Primavera");
                    break;
                default: 
                    Console.WriteLine(estacion);
                    break;
            }
        }
    }
}
