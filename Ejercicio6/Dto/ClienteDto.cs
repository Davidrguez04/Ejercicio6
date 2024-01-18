using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.Dto
{
    internal class ClienteDto
    {
        //Atributos
        long idCLiente;
        string nombreCliente;
        string apellidosCliente;
        string nombreCompletoCliente;
        int edad;

        //Getters y setters
        public long IdCLiente { get => idCLiente; set => idCLiente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int Edad { get => edad; set => edad = value; }

        //Controladores
        public ClienteDto()
        {
        }

        public ClienteDto(long idCLiente, string nombreCliente, string apellidosCliente, string nombreCompletoCliente, int edad)
        {
            this.idCLiente = idCLiente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.nombreCompletoCliente = nombreCompletoCliente;
            this.edad = edad;
        }

        //Método ToString
        override
            public string ToString()
        {
            string cliente = "Id Cliente: " + this.idCLiente +
                "\nNombre Cliente: "  + nombreCliente +
                "\nApellidos Cliente: " + this.apellidosCliente +
                "\nNombre Completo: " + this.nombreCompletoCliente +
                "\nEdad: " + this.edad;

            return cliente;
        }
    }
}
