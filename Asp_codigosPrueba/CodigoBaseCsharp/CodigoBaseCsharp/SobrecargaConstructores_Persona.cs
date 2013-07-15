using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodigoBaseCsharp
{
    class SobrecargaConstructores_Persona
    {
        public int edad=10;  //variable por defecto es O
        public string nombre="andreu"; //variables cadena vacia
        public SobrecargaConstructores_Persona()    //los constructores no tienen ripo de dato de retorno
        { 
        }
        public SobrecargaConstructores_Persona(int edad)
        {
            this.edad = edad;       //1.sobrecargaconstructor,luego el parametro
        }
        public SobrecargaConstructores_Persona(int edad, int nombre)
        {
            this.edad = edad;
        }
    }
}
