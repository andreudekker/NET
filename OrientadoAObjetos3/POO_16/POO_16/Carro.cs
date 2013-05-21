using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_16
{
    class Carro
    {
        public string Color;
        public string Modelo;
        public string Marca;
        public int Año;
        public int Kilometros;
        public int Velocidad;

        public void Acelerar()
        {
            Velocidad++;
            Console.WriteLine("La velocidad es igual" + " " +Velocidad.ToString());
        }

        public void Frenar()
        {
            Velocidad--;
            Console.WriteLine("La velocidad es igual(frenando)" +" "+ Velocidad.ToString());
        }
    
            


    }
}
