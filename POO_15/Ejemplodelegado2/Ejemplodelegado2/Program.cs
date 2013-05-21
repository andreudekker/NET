using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplodelegado2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejemplodelegado.miclasesimple miCS = new Ejemplodelegado.miclasesimple();       //instancia de la clase
            Ejemplodelegado.mimetododelegate miD1 = new Ejemplodelegado.mimetododelegate(miCS.mistringmetodo);//creo instancia del delegado,creo instancia de la clase
            Ejemplodelegado.mimetododelegate miD2 = new Ejemplodelegado.mimetododelegate(Ejemplodelegado.miclasesimple.mysignMethod); //llamo el methodo estatico
            Console.WriteLine("{0} es {1}; usa el signo{2}", 5, miD1(5), miD2(5));
            Console.WriteLine("{0} es {1}; usa el signo{2}", -3, miD1(-3), miD2(-3));
            Console.WriteLine("{0} es {1}; no usa signo{2}", 0, miD1(0), miD2(0));
            Console.ReadLine();
        }
    }
}
