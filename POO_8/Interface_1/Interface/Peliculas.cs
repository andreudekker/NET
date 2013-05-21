using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1;

namespace GenericList
{
    class Peliculas : Ireporteable
    {

        public string Nombre { get; set; }
        public string genero { get; set; }
        public string protagonista { get; set; }

        public string reporte() 
        {
            string mensaje = string.Format("El articulo es de nombre:{0}  y es de{1} su protagonista es{2} ",Nombre,genero,protagonista);
            return mensaje;
        }
    }
}
