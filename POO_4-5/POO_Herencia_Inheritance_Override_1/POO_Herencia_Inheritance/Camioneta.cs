using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herencia_Inheritance
{
    class Camioneta : Carro         //forma de heredar en C#
    {
        public string capacidaddecarga()
        {
            string mensaje = iniciandoencendido() +  "1500 libras";
            return mensaje;
        }

        public override string iniciandoencendido()
        {
            string mensaje = "iniciando el override";
            return mensaje;
        }

    }
}
