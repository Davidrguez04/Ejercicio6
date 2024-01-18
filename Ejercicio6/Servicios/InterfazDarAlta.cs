using Ejercicio6.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.Servicios
{
    internal interface InterfazDarAlta
    {
        public void darAltaCliente(List<ClienteDto> listaClientes);

        public void comproClientes(List<ClienteDto> listaClientes);

    }

}
