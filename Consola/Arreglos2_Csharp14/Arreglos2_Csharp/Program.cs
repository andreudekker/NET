using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos2_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int []numeros={ 1,2,5,6}; This I can use just change numeros
            string[] Colores = { "verde", "amarillo", "rojo" };
            for (int i = 0; i <Colores.Length; i++)
            {
                Console.WriteLine(Colores[i].ToString());
            }
                Console.ReadLine();
        }
    }
}
