using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_de_Datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coords miscoordenadas= new Coords(0,12,5);
            Console.WriteLine(miscoordenadas.X);
            Console.WriteLine(miscoordenadas.Y);
            Console.WriteLine(miscoordenadas.Z);

            //Coords miscoordenadas2 = miscoordenadas with { X = 3 };
        }
        public struct Coords
        {
            public Coords(double x, double y,double z)
            {
                X = x;
                Y = y;
                Z = z;
            }
            public double X { get; }
            public double Y { get; }
            public double Z { get; }
            public override string ToString() => $"({X},{Y},{Z})";//Cuando lo escriba lo cambia a string para poder imprimirlo 
 
        }
    }
}
