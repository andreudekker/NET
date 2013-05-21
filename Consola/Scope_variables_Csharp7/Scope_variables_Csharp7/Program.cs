using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope_variables_Csharp7
{
    class Program
    {
        static void Main(string[] args)
        {

            int  y = 5;
            int b = 0;
            if (y == 5)
            {
                b = 2;
            }
            Console.WriteLine(b);
            Console.ReadLine();

        }
    }
}
