using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodigoBaseCsharp
{
    class Polimorfismo
    {
        public string color;
        public string ruedas;
        public string  puertas;
      
        public string miVehiculo(string color, string ruedas, string puertas)
        {
            
            Console.WriteLine("Metodo con parametros");
            Console.WriteLine("Color"+ color + "Cantidad de ruedas" + ruedas + "Numero de puertas" + puertas);
            return color + ruedas + puertas;
        }
        public string miVehiculo()
        {
            color = "Azul";
            ruedas = "4";
            puertas = "4";
            Console.WriteLine("Metodo sin parametros");
            Console.WriteLine("Color" + color + "Cantidad de ruedas" + ruedas + "Numero de puertas" + puertas);
            return color+ruedas+puertas;
        }

        
    
    }
}
