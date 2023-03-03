using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles_I
{
    internal class Program
    {
        static void Main(string[] args)
        {//Bucles

            //While - Mientras
            Console.WriteLine("While");
            int i = 1;
            while (i < 10) {

                //Codigo que se ejecuta mientras "True"
                Console.Write(i+" ");
                i++;//i=i+1;
            }
            Console.WriteLine("Despues del while i=: "+i);//i vale 11
            //Do...While - Hacer..Mientras
            Console.Write("Do...While ");
            i = 5;
            do { 
            Console.Write(i+" ");
                i +=5;
                i++;
            }while(i < 10);

            //For - Para / Por

            Console.Write("\nFOR:");
            for (int j=1; j < 10; j++)
            {
                Console.Write(j+" ");
            }

            //Foreach - Para/Por Cada
            Console.WriteLine("\nForeach");
            var lista=new List<string> {"Pepe","Juan","Cesar","Ana"};
            foreach(var elemento in lista)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
