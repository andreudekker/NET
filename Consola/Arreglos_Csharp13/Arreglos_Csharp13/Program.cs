using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_Csharp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];                         //how to create arrays is like this in C #
            numeros[0]=  3;
            numeros[1]=  2;
            numeros[2]=  1;
            numeros[3] = 4;
            Console.WriteLine(numeros[1].ToString());
            for (int i = 0;  i < numeros.Length;  i++)
            {
                Console.WriteLine(numeros[i].ToString());
            }
               Console.ReadLine();
        }
    }
}
