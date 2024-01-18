using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio6.Dto;


namespace Ejercicio6.Servicios
{
    internal class ImplDarAlta : InterfazDarAlta
    {
        public void darAltaCliente(List<ClienteDto> listaClientes)
        {
            ClienteDto nuevoCliente = crearNuevoCliente();

            //Esto es para controlar si el Id que introduce el cliente ya esta en uso
            foreach (ClienteDto cliente2 in listaClientes)
            {
                if (cliente2.IdCLiente.Equals(nuevoCliente.IdCLiente))
                {

                    Console.WriteLine("Introduzca otro id ya que este ya esta en uso: ");
                    nuevoCliente.IdCLiente = Convert.ToInt64(Console.ReadLine());


                    break;
                }
                else
                {
                    break;
                }
            }

            listaClientes.Add(nuevoCliente);
        }

        private ClienteDto crearNuevoCliente()
        {
            ClienteDto nuevoCliente = new ClienteDto();

            /*Console.WriteLine("Intoduzca el id: ");
            nuevoCliente.Id = Convert.ToInt64(Console.ReadLine());
            */


            Console.WriteLine("Introduzca el id:");
            nuevoCliente.IdCLiente = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca nombre:");
            nuevoCliente.NombreCliente = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca sus apellidos:");
            nuevoCliente.ApellidosCliente = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca su edad:");
            nuevoCliente.Edad = Convert.ToInt32(Console.ReadLine());

            return nuevoCliente;
        }

        public void comproClientes(List<ClienteDto> listaClientes)
        {
            ClienteDto cliente = new ClienteDto();

            if (listaClientes.Count < 3)
            {
                Console.WriteLine("Se necesitan al menos tres clientes para ordenar la lista.");
                return;
            }

            foreach (ClienteDto cliente2 in listaClientes)
            {
                

                

                    // Ordenar la lista utilizando el algoritmo de Burbuja
                    for (int i = 0; i < listaClientes.Count - 1; i++)
                    {
                        for (int j = 0; j < listaClientes.Count - 1 - i; j++)
                        {
                            if (listaClientes[j].Edad < listaClientes[j + 1].Edad)
                            {
                                // Intercambiar elementos si están en el orden incorrecto
                                ClienteDto temp = listaClientes[j];
                                listaClientes[j] = listaClientes[j + 1];
                                listaClientes[j + 1] = temp;
                            }
                        }
                    }

                    Console.WriteLine("\nLista de clientes después de ordenar:\n");
                    Console.WriteLine(cliente2);
                

               

            }

        }

    }
}
