using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colores = { "Azul", "Verde", "Rojo", "Negro" };
            foreach (string Color in colores)                   //does it count in a data collection
            {
                Console.WriteLine("El color es:" +Color);
            }
                Console.ReadLine();
        }
    }
}
