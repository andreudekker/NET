using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Polimorfismo_17
{
    class Vehiculos
    {
        public string color;
        public int ruedas;
        public int puertas;

        public void miVehiculo(string color, int ruedas, int puertas)
        {
            Console.WriteLine("Metodo con parametros:");
            Console.WriteLine("Color" + color + "Cantidad de ruedas" + ruedas + "Cantidad de puertas" + puertas);
          
        }
      
        public void miVehiculo()
        {
            color = "Azul";
            ruedas = 4;
            puertas = 4;
            Console.WriteLine("Metodo sin parametros:");
            Console.WriteLine("Color" + color + "Cantidad de ruedas" + ruedas + "Cantidad de puertas" + puertas);

        }


    }
}
