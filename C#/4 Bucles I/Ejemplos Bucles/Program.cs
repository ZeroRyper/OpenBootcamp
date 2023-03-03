using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos_Bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sumar los 100 primeros numeros enteros
            int i = 0;
            int suma= 0;
            for (i=0;i<=100; i++)
            {
                 suma += i;
            }
            Console.WriteLine(suma);
            //Expandimos el codigo para que el usuario indique un numero hasta donde vamos a sumar
            int j = 0;
            int resultado = 0;
            int limt= 0;
            Console.WriteLine("Introduce el limite");
            limt = (Convert.ToInt32(Console.ReadLine()));
            for (j = 0; j <= limt ; j++)
            {
                resultado += j;
            }
            Console.WriteLine($"Resultado es : {resultado}");

            //Escribir todo los elemetos de una array

            int[] arr=new int[4];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            Console.WriteLine("FOR");
            for (i=0;i<arr.Length;i++) {
                Console.WriteLine(arr[i]+" ");
            }
            Console.WriteLine("Foreach");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("While");
            i = 0;
            while (i<arr.Length)
            {
                Console.WriteLine(arr[i]+ " ");
                i++;
            }
        }
    }
}
