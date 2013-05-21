using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDedatos_Parse_Csharp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 2;
            string x = " andreu ";                      //Diferent kind the data
            string resultado = y + x;
            string z = "8";
            int p = int.Parse(z);                   // convert data  to small data all these depends of number of caracter, I can to do this.
                                                            //but is possible lose data
            Console.WriteLine(resultado);
            Console.ReadLine();

            string a="8";
            int b=2;
            int c=3;
            int num = b * ( int.Parse(a));               //and here convert character to int
            Console.WriteLine(num);
            Console.ReadLine();


        }
    }
}
