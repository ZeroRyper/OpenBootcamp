using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segunda_parte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro micar= new Carro();
            micar.puertascarro();
            Console.WriteLine(micar.puertas);

    }
    class Carro
        {
            public int puertas = 0;
            public void puertascarro() {
                this.puertas++;
            }
        }
    }
}
