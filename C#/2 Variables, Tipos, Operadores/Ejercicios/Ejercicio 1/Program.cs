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
            /*
            Ejercicio 1

           Variables Escribe un programa que reciba datos de una persona y genera un mensaje, 
           usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, 
           sabe programar, etc.
            */
            string nombre = null;
            string apellido = null;
            string programa = null;
            Console.WriteLine("Escribe tu edad : ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe tu nombre : ");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu apellido : ");
            apellido = Console.ReadLine();
            Console.WriteLine("Programa? : ");
            programa = Console.ReadLine();
            

            Console.Write(" Nombre " + nombre + " Apellido " + apellido + " Edad " + edad + " Programa " + programa);
        }
    }
}
