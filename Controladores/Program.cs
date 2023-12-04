using csi23_iloposa.Dtos;

namespace csi23_iloposa.Servicios;

/// <summary>
/// Clase principal de la aplicacion por la cual contiene el metodo Main
/// <author>ilp-041223</author>
/// </summary>
class Program
{
    /// <summary>
    /// Metodo principal de la aplicacion y por el cual se lanzara la aplicacion conteniendo los pasos de ella 
    /// <author>ilp-041223</author>
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        List<clienteDtos> listaClientes = new List<clienteDtos>();
        menuInterfaz mi = new menuImplementacion();
        operativaInterfaz op = new opertivaImplementacion();
        bool cerrarMenu = true;

        int opcionSeleccionada;

        Console.WriteLine("Este es la nueva tienda de vajillas elija una opcion ");

        while (cerrarMenu)
        {
            opcionSeleccionada = mi.mostrarMenuYSeleccion();
            Console.WriteLine(opcionSeleccionada);

            switch(opcionSeleccionada)
            {
                case 0:
                    Console.WriteLine("Se cerrara el menu");
                    cerrarMenu=false;
                    break;

                case 1:
                    Console.WriteLine("Se añadira un nuevo objeto");
                    op.darAltaObjeto(listaClientes);
                    foreach(clienteDtos clientes in listaClientes)
                    {
                        Console.WriteLine(clientes.ToString());
                    }

                    break;

                case 2:
                    Console.WriteLine("Se modificara un nuevo objeto");
                    op.modificarObjeto(listaClientes);
                    foreach (clienteDtos clientes in listaClientes)
                    {
                        Console.WriteLine(clientes.ToString());
                    }
                    break;
                default:
                    Console.WriteLine("La opcion elegida no existe ");
                    break;

            }
        }

    }
}