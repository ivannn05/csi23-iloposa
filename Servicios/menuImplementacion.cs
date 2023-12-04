using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi23_iloposa.Servicios
{
    /// <summary>
    /// Clase la cual contiene toda la logica de los metodos del menu principal 
    /// <author>ilp-041223</author>
    /// </summary>
    internal class menuImplementacion : menuInterfaz
    {

        public int mostrarMenuYSeleccion()
        {
            int opcionSeleccionada;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("0.Cerrar Menu");
            Console.WriteLine("1.Añadir un elemento nuevo a la vajilla ");
            Console.WriteLine("2.Modificar los datos de la vajilla");
            Console.WriteLine("-------------------------------------------");
            opcionSeleccionada=Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;
        }
    }
}
