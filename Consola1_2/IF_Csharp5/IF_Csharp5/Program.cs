using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_Csharp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escoja un valor de estos 1,2,3 ");
            string datosDeusuario = Console.ReadLine();
            
            
            if (datosDeusuario == "1")
            {
                Console.WriteLine("Este es su numero de la suerte");
                Console.ReadLine();
            }
            else   if (datosDeusuario == "2")
            {
                Console.WriteLine("Buen Numero");
                Console.ReadLine();
            }
             else   if (datosDeusuario == "3")
                {
                    Console.WriteLine("Bien ganaste");
                    Console.ReadLine();
                }
           else
            {
                Console.WriteLine("Usted no siguio los pasos");
                Console.ReadLine();
            }
          }
    }
}
