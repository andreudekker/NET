using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Polimorfismo_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculos ConP = new Vehiculos();        //Con parametros
            ConP.miVehiculo("Negro", 4, 5);
            ConP.miVehiculo();

            Console.ReadLine();
   
         
        
        }
    }
}
