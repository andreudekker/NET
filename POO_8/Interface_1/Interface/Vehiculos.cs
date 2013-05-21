using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1;

namespace GenericList
{
    class Vehiculos :Ireporteable
    {
        public string marca { get; set; }
        public string modelos { get; set; }
        public int fechaDeFabricacion { get; set; }

        public   string reporte()   // se debe iplementear siempre un metodo cuando se crea interface //sin override
        {
            string mensaje = string.Format("El vehiculo es{0} Modelo{1} del año{2}",marca,modelos,fechaDeFabricacion);
            return mensaje;
        
        }
    }
}
