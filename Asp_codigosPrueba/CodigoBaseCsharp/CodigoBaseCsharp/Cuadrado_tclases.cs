using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodigoBaseCsharp
{
    class Cuadrado_tclases :Figura_tclases
    {
        private double _lado;
        public Cuadrado_tclases( double lado)   //constructor
        {
            this._lado = lado;
            
        }
        
      public override void Dibujar() // con la palabra reservada new: estoy escondiendo la clase base  con su metodo virtual
        {
             //base.Dibujar();  //  la palabara base: hace referencia a un miembro o  metodo de la clase base
             Console.WriteLine("Dibujando cuadrado");
        }
        
        public override double Area()
        {
            return Math.Pow(this._lado,2);
        }
    }
}
