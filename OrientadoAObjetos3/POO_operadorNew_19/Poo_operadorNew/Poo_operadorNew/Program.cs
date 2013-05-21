using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_operadorNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Cometa micometa;
            micometa = new Cometa();

            micometa.color = "azul y rojo";
            micometa = new Cometa();

           
        }
    }
}
