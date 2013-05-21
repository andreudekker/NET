using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceGenericList2
{
    class Productos 
    {
        public int id { get; set; }
        public virtual string reporte() 
        {
            string mensaje = string.Format("El id es:{0}", id);
            return mensaje;
        }
    }
}
