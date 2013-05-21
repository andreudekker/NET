using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulacion_Poo
{
    class Carro
    {
        public int velocidad;
        
        public void Acelerar()
        {
        velocidad++;
        Console.WriteLine("Velocidad actual es:"+  velocidad.ToString());
        }
        public void Frenar()
        {
            velocidad--;
            Console.WriteLine("Velocidad actual es:" + velocidad.ToString());
        }
    }
}
