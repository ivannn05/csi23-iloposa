using csi23_iloposa.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi23_iloposa.Servicios
{
    /// <summary>
    /// Implementacion la cual contendra la logica de los metodos de la operativa del cliente 
    /// <author>ilp-041223</author>
    /// </summary>
    internal class opertivaImplementacion : operativaInterfaz
    {
        public void darAltaObjeto(List<clienteDtos>listaClientes)
        {
            clienteDtos cliente = crearVajillaNueva();
            listaClientes.Add(cliente);
        }

   

        /// <summary>
        /// Metodo privado el cual acompaña a darAltaCliente para la inscripcion de un usuario 
        /// <author>ilp-041223</author>
        /// </summary>
        /// <returns></returns>
        private clienteDtos crearVajillaNueva()
        {
            clienteDtos cliente = new clienteDtos();

            Console.WriteLine("Introduzca la id del objeto");
            cliente.IdElemento=Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca el nombre del objeto");
            cliente.NombreElemento = Console.ReadLine();

            Console.WriteLine("Introduzca la descripcion del objeto");
            cliente.DescripcionElemento = Console.ReadLine();

            Console.WriteLine("Introduzca la cantidad del objeto");
            cliente.CantidadElemento = Convert.ToInt32(Console.ReadLine());

            cliente.CodigoElemento= cliente.IdElemento+cliente.NombreElemento;
            return cliente;


        }



        public string pedirCodigo()
        {
            clienteDtos cliente = new clienteDtos();

            string buscarCodigo;
            Console.WriteLine("Escriba el codigo con el que va a cambiar (Primero id y seguido nombre)");
           buscarCodigo = Console.ReadLine();

           
            return buscarCodigo;

        }

        public void modificarObjeto(List<clienteDtos> listaClientes)
        {
            operativaInterfaz op = new opertivaImplementacion();
            clienteDtos clienteAModificar = new clienteDtos();

            string CodigoABuscar = op.pedirCodigo();

            foreach(clienteDtos cliente in listaClientes)
            {
                if (cliente.CodigoElemento.Equals(CodigoABuscar))
                {
                    clienteAModificar = cliente;

                    int opcionSeleccionada;
                   
                    Console.WriteLine("Introduzca cuanta vajilla quiere disminuir ");

                    opcionSeleccionada=Convert.ToInt32(Console.ReadLine());

                    cliente.CantidadElemento= clienteAModificar.CantidadElemento - opcionSeleccionada ;




                }
            }


        }
    }
}
