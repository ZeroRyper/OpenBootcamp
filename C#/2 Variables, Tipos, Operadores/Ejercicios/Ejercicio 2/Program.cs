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
            /*
             Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:

            Coche: puertas, ruedas, marca, ITV vigente

            Mesa: peso, largo, material, color

            Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar 
            los datos en los tipos más adecuados.
             */
            int puertas = 4;int ruedas=4;
            string marca = "Ferrari";string ITV="MA34J";
            float peso = 54.4f;float largo = 24.1f;string material = "Metal"; string color = "Negro";
            Console.WriteLine("Puerta "+puertas+" ruedas "+ruedas+" marca "+marca+" ITV "+ITV+" peso "+peso+" largo "+largo+" material "+material+
                " Color "+color);

        }
    }
}
