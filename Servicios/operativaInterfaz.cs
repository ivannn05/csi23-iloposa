using csi23_iloposa.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi23_iloposa.Servicios
{
    /// <summary>
    /// Interfaz que contendra el encabezado de los metodos de la operativa de los clientes
    /// <author>ilp-041223</author>
    /// </summary>
    internal interface operativaInterfaz
    {
        /// <summary>
        /// Metodo que se encargara de crear el nuevo usuario con su objeto
        /// <author>ilp-041223</author>
        /// </summary>
        /// <param name="listaClientes"></param>
        public void darAltaObjeto(List<clienteDtos> listaClientes);

        /// <summary>
        /// Metodo por el cual pedira el codigo al usuario para la identificacion de la vajilla 
        /// <author>ilp-041223</author>
        /// </summary>
        /// <returns></returns>
        public string pedirCodigo();

        /// <summary>
        /// Metodo que se encarga de modificar la cantidad de objetos
        ///  <author>ilp-041223</author>
        /// </summary>
        /// <param name="listaClientes"></param>
        public void modificarObjeto(List<clienteDtos> listaClientes);
    }
}
