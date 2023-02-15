using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_tema_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.edad = 22;
            cliente.nombre="Erick";
            cliente.numero = 1234567891;
            cliente.setcredito(50);
            Console.WriteLine("Edad " + cliente.edad+ " Nombre " + cliente.nombre + " Numero " + cliente.numero +" Credito " +cliente.getcredito());
            Trabajador trabajador= new Trabajador();
            trabajador.edad = 22;
            trabajador.nombre = "Erick";
            trabajador.numero = 1234567891;
            trabajador.setsalario(500);
            Console.WriteLine("Edad " + trabajador.edad + " Nombre " + trabajador.nombre + " Numero " + trabajador.numero + " Salario " +trabajador.getsalario());
        }
    }
    class Persona
    {
        public int edad;
        public string nombre;
        public int numero;
    }
    class Cliente : Persona
    {
        private int credito;
        public void setcredito(int credito)
        {
            this.credito = credito;
        }
        public int getcredito()
        {
            return this.credito;
        }
    }
    class Trabajador : Persona
    {
        private double salario;
        public void setsalario(double salario)
        {
            this.salario = salario;
        }
        public double getsalario()
        {
            return this.salario;
        }
    }
}
