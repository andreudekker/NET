using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulacion_Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro suVelocidad  = new Carro();
            suVelocidad.velocidad = 0;
            suVelocidad.Acelerar();
            suVelocidad.Acelerar();
            suVelocidad.Acelerar();
            suVelocidad.Acelerar();
            suVelocidad.Acelerar();
            suVelocidad.Frenar();
            suVelocidad.Frenar();
            suVelocidad.Frenar();
            Console.ReadLine();

        }
    }
}
