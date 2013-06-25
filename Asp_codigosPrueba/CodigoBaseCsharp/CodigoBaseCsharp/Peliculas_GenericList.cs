using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodigoBaseCsharp
{
    class Peliculas_GenericList :Productos_GenericList
    {
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Protagonista { get; set; }
       
        public override string reporte()
        {
            string mensaje = string.Format("El articulo es de nombre:{0} y es de {1} su protagonista", Nombre, Genero, Protagonista);
            return mensaje;
        }
    }
}
