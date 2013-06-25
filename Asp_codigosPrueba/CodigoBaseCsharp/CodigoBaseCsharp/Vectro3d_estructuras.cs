using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodigoBaseCsharp
{
  public struct Vector3d_estructuras
    {
      public int x;
      public int y;
      public int z;
   
      
      public Vector3d_estructuras(int xx) 
      {
          x = 0;        //es Obligatorio inicializar las variables deben ser estaticas o constantes en los constructores o genera error
                            //No se pueden crear destructores
          y = 0;
          z = 0;

      }


    }
}
