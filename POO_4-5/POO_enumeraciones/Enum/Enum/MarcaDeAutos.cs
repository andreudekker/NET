using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class MarcaDeAutos
    {
        #region propiedadesdeMarcaAuto
        private string marca;

        public string Marca
        {
            get { return marca; }                   //validar los campos o informacion con get o set
            set {
                        switch (value)
                        {
                            case "Honda":
                                marca = value;
                                break;
                            case "Mazda":
                                marca = value;
                                break;
                            default:
                                throw new Exception("Las marcas validas son Honda y Mazda");
                         }       
                 }    
       }
        #endregion

       
        //Enumeracion aplicada
        private marcas marcar;

        public marcas Marcas
        {
            get { return marcar; }
            set { marcar = value; }
        }
        
        
        
        public string vehiculodeseado (string modelo)
                {
                  string mensaje="Le gustan los vehiculos:" + modelo;
                  return mensaje;
                }
        }
   
    //el enum debe colocarse fuera de la clase
    enum marcas
    { 
        Honda,
        Mazda
    }
  
}

