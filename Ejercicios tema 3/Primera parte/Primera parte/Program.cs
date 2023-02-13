using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primera_parte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;
            resultado=suma(a:4,b:5,c:6);
            System.Console.WriteLine(resultado);
        }
        static int suma(int a,int b,int c)
        {
            return a+b+c;
        }
    }
}
