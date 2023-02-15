using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_tema_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.setedad(22);
            Console.WriteLine(persona.getedad());
            persona.setnombre("Erick");
            Console.WriteLine(persona.getnombre());
            persona.settelefono(1234567891);
            Console.WriteLine(persona.gettelefono());
        }
    }
    class Persona
    {
        private int edad;
        private string nombre;
        private int telefono;

        public void setedad(int edad)
        {
            this.edad = edad;
        }
        public void setnombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void settelefono(int telefono)
        {
            this.telefono = telefono;
        }
        public int getedad()
        {
            return this.edad;
        }
        public string getnombre()
        {
            return this.nombre;
        }
        public int gettelefono()
        {
            return this.telefono;
        }
    }
}
