using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodigoBaseCsharp
{
   public class Circulo_tclases : Figura_tclases
    {
       private double _radio;

       public Circulo_tclases(double radio )     //Constructor
       {
           this._radio = radio;
       }
       
       public override void Dibujar()
       {
         Console.WriteLine("Dibujando Circulo..");
       }

       public override double Area()
       {
           return Math.PI * Math.Pow(this._radio, 2);
       }
    }
}
