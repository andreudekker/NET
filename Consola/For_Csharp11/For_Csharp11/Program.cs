using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Csharp11
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine(i);
                if (i == 10)
                {
                    Console.WriteLine("El valor actual es igual a 10");
                    break;
                }
            }
                Console.ReadLine();
        }
    }
}
