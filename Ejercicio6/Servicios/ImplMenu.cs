using Ejercicio6.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.Servicios
{
    internal class ImplMenu : InterfazMenu
    {
        public void mensajeBienvenida()
        {
            string mensaje = "Bienvenido a mi programa";
            Console.WriteLine("\n\t" + mensaje);

        }

        public int mostrarMenu()
        {
            int opcion;

            Console.WriteLine("\n\tMenu:");
            Console.WriteLine("\n\t1.-Dar de alta nuevo cliente");
            Console.WriteLine("\n\t2.-Ordenar lista clientes");
            Console.WriteLine("\n\t0.-Salir del programa");
            Console.WriteLine("\n\tSeleccione una opción: ");

            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }
    }
}
