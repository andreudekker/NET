using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodigoBaseCsharp
{
    class Vehiculos_GenericList :Productos_GenericList
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public int fechaDeFabricacion { get; set; }
        
        public override string reporte()
        {
            string mensaje = string.Format("El vehiculo es{0} modelo{1}del año{2}", marca, modelo, fechaDeFabricacion);
            return mensaje;
        }
    }
}
