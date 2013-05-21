using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_Csharp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uno de estos valores 1,2,3");
            string datoUsuario = Console.ReadLine();
            string mensaje="";
            
            switch (datoUsuario)
            {
                case "1":
                    mensaje = "el uno es una buena opcion";
                    break;
               
                case "2":
                    mensaje = "el dos es par";
                    break;
                
                case "3":
                    mensaje = " el 3 de treboles";
                    break;
                
                default:
                    mensaje = "no es una opcion valida";
                    break;
            }

            Console.ReadLine();
        }
    }
}
