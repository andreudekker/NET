using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodigoBaseCsharp
{
    class Constructor
    {
        #region Constructor
        public string nombre;//variable nivel clase
        public int precio;
        public Constructor()
        {
            precio = 200;
        }
        public Constructor(string nombre, int precio) //sus variables a nivel constructor
        {
            this.nombre = nombre;  //this: distingue la variable a nivel clase
            this.precio = precio;
        }
        #endregion
    }
}
