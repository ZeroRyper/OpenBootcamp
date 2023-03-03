using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Introduce el numero");
            int num=Convert.ToInt32(Console.ReadLine());
            while (i<11)
            {
                Console.WriteLine(num + "x"+i+"="+i*num);
                i++;
            }
        }
    }
}
