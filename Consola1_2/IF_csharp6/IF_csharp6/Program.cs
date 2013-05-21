using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_csharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escoja una de las siguientes opciones 1,2,3");
            string datosUsuario = Console.ReadLine();
            string mensaje = "";
           
            if (datosUsuario == "1")
            {
                mensaje = "opcion valida '1' ";
       
            }
            else if (datosUsuario == "2")
            {
                mensaje = "opcion valida '2' ";
            }
            else if (datosUsuario == "3")
            {
                mensaje = "opcion valida '3' ";
            }

            else
            {
                mensaje = "opcion invalida";
            }
        }
    }
}
