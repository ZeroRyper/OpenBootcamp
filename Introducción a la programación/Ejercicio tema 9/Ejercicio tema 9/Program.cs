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
            Console.WriteLine("Edad "+cliente.edad);
            cliente.nombre="Erick";
            Console.WriteLine("Nombre "+cliente.nombre);
            cliente.numero = 1234567891;
            Console.WriteLine("Numero "+cliente.numero);
            cliente.setcredito(50);
            Console.WriteLine("Credito "+cliente.getcredito());
            Trabajador trabajador= new Trabajador();
            trabajador.setsalario(500);
            Console.WriteLine("Salario "+trabajador.getsalario());
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
