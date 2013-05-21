using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro Elcarro = new Carro();
            {
                Elcarro.Velocidad = 0;
                Elcarro.Marca = "Peugeot";
                Elcarro.Modelo = "306";
                Elcarro.Año = 1999;
                Elcarro.Kilometros = 31000;

                Console.WriteLine(Elcarro.Marca+" "+ Elcarro.Modelo);
                Elcarro.Acelerar();
                Elcarro.Acelerar();
                Elcarro.Acelerar();
                Elcarro.Acelerar();
                Elcarro.Acelerar();
                Elcarro.Frenar();
                Elcarro.Frenar();
                Elcarro.Frenar();
                Elcarro.Acelerar();
                Console.WriteLine("La velocidad actual es:"+"  " + Elcarro.Velocidad);
                Console.ReadLine();

            }

        }
    }
}
