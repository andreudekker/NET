using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodigoBaseCsharp
{
    class ClassGET_SET
    {
        private string _nick;       //Variable

        public string Nickname //Propiedad
        {
            get 
            {
                return this._nick; 
            }
            set 
            {
                if (value.Length < 5)
                {
                
                    this._nick = "Sin Informacion";
                }
                else
                {
                    this._nick = value;
                }
            }
        }
        
    }
}
