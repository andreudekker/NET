using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodigoBaseCsharp
{
   public abstract class   Figura_tclases 
    {
        public string  Nombre { get; set; }
       public virtual void Dibujar() // con virtual puedo agregar al cuerpo procedimientos
        { 
            Console.WriteLine("Dibujando X figura");
        }
       public abstract double Area(); //creacion clases abstractas
       

    }
}
