using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores_Csharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 2;
            int x = a / b;

            if ((a == b) && (x >= a))
            {
                Console.WriteLine("Es igual");
            }
            else 
            {
                Console.WriteLine("No es igual");
            }
            Console.ReadLine();

            string test = "a";
            string valor = "b";
            string resultado = (test == valor) ? "a" : "b";   //this line work like a IF
       
        }
    }
}
