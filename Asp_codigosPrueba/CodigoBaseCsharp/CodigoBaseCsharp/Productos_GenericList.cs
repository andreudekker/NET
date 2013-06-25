using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodigoBaseCsharp
{
    class Productos_GenericList
    {
        public  int id { get; set; }
        public virtual string reporte()
        {
            string mensaje = String.Format("El id es:{0}");
            return mensaje;
        }

    }
}
