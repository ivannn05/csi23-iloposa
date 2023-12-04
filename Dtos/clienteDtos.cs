using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi23_iloposa.Dtos
{
    /// <summary>
    /// Clase tipo dtos la cual contiene la informacion ,gets , sets y constructores de la vajilla 
    /// <author>ilp-041223</author>
    /// </summary>
    internal class clienteDtos
    {
       

        //Atributos
        long idElemento=0 ;

        string nombreElemento = "aaaa";
        string descripcionElemento = "aaaa";
        int cantidadElemento = 0;


        string codigoElemento = "aaaa";

        public clienteDtos()
        {
        }

        //Constructores
        public clienteDtos(long idElemento, string nombreElemento, string descripcionElemento, int cantidadElemento, string codigoElemento)
        {
            this.idElemento = idElemento;
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
            this.codigoElemento = codigoElemento;
        }
        //Geters y Seters
        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }


        override

            /// <summary>
            /// Clase la cual muestra el nombre y la cantidad de la vajilla 
            /// <author>ilp-041223</author>
            /// </summary>


            public string ToString()
        {
            string datos = "nombre=" + this.nombreElemento +""+
                "cantidad=" + this.cantidadElemento;

            return datos;
        }
    }
}
