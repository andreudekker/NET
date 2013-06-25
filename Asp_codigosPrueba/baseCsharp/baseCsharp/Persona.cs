using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baseCsharp
{
    class Persona
    {

        #region Sobrecargadeconstructores
        public int edad_;
        public string nombre_;
        
      public  Persona()
        { 
        }
       public Persona(int edad_)
        {
            this.edad_ = edad_;
        }
       public Persona(int edad_, string nombre_)
        {
            this.edad_ = edad_;
            this.nombre_ = nombre_;          
        }
       #endregion
    }
}
