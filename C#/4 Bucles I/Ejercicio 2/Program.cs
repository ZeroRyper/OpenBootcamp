using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int numn = 0;
            int i = 0;
            int nump = 0;
            do
            {
                Console.WriteLine("Introduce el numero");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    nump += 1;
                    i++;
                }
                else
                {
                    numn += 1;
                    i++;
                }
            } while (i < 3);
            Console.WriteLine("Positivos "+nump);
            Console.WriteLine("Negativos " +numn);

        }
    }
}
