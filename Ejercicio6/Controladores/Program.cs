/*Enunciado:
* La aplicación se desarrollará con la arquitectura vista en clase.

Desarrolla una aplicación que muestre un menú con tres opciones: cerrar menú, dar de alta nuevo cliente y ordenar 
lista clientes.

El dto cliente contendrá los siguientes campos:
- idCliente int64
- nombreCliente texto
- apellidosCliente texto
- nombreCompletoCliente texto
- edad int32

Al dar de alta un nuevo cliente, se solicitará al usuario los campos: id, nombre, apellidos y edad. Dentro del 
constructor del dto cliente se informará el campo nombreCompletoCliente concatenando los campos nombre y apellidos.

Al seleccionar la opción ordenar, antes de ejecutar la lógica correspondiente, deberá verificarse que existen un 
mínimo de tres clientes en la lista. Si no es así, se mostrará un mensaje informando de que son necesarios más 
clientes. 
Si en la lista hay tres o más clientes, se imprimirán en consola los campos nombreCompletoCliente y edad de cada 
cliente de la lista; después se ordenará la lista según el campo edad de forma descendente utilizando el algoritmo
Burbuja; y se volverá a imprimir los campos nombreCompletoCliente y edad de cada cliente de la lista ya ordenada.
*/

using Ejercicio6.Dto;
using Ejercicio6.Servicios;

namespace Ejercicio6.Controladores
{
    /// <summary>
    /// David Rodriguez Alonso
    /// 09/01/2024
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            InterfazMenu menuInterfaz = new ImplMenu();
            InterfazDarAlta cliente = new ImplDarAlta();

            List<ClienteDto> listaCliente = new List<ClienteDto>();

            bool cerrarMenu = false;

            int opcionSeleccionada;

            menuInterfaz.mensajeBienvenida();

            while (!cerrarMenu)
            {
                opcionSeleccionada = menuInterfaz.mostrarMenu();
                Console.Clear();


                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("\n\tHas seleccionado la opcion para salir");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("\n\tDar de alta nuevo cliente");
                        cliente.darAltaCliente(listaCliente);
                        break;

                    case 2:
                        Console.WriteLine("\n\tOrdenar lista clientes");
                        cliente.comproClientes(listaCliente);
                        break;

                    default:
                        Console.WriteLine("\n\t!!Opcion seleccionada incorrecta!!");
                        break;


                }
            }

        }
    }
}
