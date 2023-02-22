using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {/*
    Crea una estructura de datos para un cliente con estos campos:
    Nombre completo
    Teléfono
    Dirección
    Email
    Si es nuevo cliente
    Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
      */
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Erick",12343456,"Sierra Ai 543","erick100520@gmail.com","Si");
            Console.WriteLine(cliente.Nombre);
            Console.WriteLine(cliente.Telefono);
            Console.WriteLine(cliente.Direccion);
            Console.WriteLine(cliente.Email);
            Console.WriteLine(cliente.Escliente);
        }
        public struct Cliente {
            public Cliente(string nombre,int telefono,string direccion,string email,string escliente) { 
                Nombre=nombre;
                Telefono = telefono;
                Direccion = direccion;
                Email = email;
                Escliente = escliente;


            }
            public string Nombre { get; }
            public int Telefono { get; }
            public string Direccion { get; }
            public string Email { get; }
            public string Escliente { get; }
            public override string ToString() => $"({Telefono})";//Cuando lo escriba lo cambia a string para poder imprimirlo 

        }
    }
}
