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
            /*
             Ejercicio 3

            Operadores Determina los operadores para verificar las siguientes condiciones:

            Un número es mayor o igual a 18

            Un char es ‘a’

            Se cumplen dos conciones a la vez (ambas verdaderas)

            Se cumple una de dos condiciones a la vez (una true y otra false)

            Nota: puedes escribir estos datos por consola si prefieres verlos. 
            La idea del ejercicio es almacenar los datos en los tipos más adecuados.
                */
            int a = 10;
            int b = 5;
            char c= 'a';
            Console.WriteLine(a>=18);
            Console.WriteLine((c=='a'));
            Console.WriteLine(a >9 && b>4);
            Console.WriteLine(a > 9 || b > 6);

        }
    }
}
