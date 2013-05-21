using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using codigodelegado;   //añadir para hacer uso del delegate

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            principal instancia = new principal();
            midelegado variabledelegadouno = new midelegado(instancia.delegadofuncion1);
            int a = variabledelegadouno(6);
            Console.WriteLine("El resultado obtenido es = a {0}", a);
            Console.ReadLine();

            //metodo header                     //siempre usar 
            //    bool tuedad (int edad)
            //metodo signature
            //    bool tuedad(int)
        }
    }
}
