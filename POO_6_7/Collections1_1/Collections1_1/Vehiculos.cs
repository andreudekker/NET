using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections1_1
{
    class Vehiculos
    {

        public string marca { get; set; }
        public string modelo { get; set; }
        public int fechadefabricacion { get; set; }

        public string reporte()
        { 
        string mensaje = string.Format("elvehiculo es:{0} modelo{1} del año {2}",marca,modelo,fechadefabricacion);
            return mensaje;
        }
}

    }

