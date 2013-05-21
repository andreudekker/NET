using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericList
{
    class productos             // funcion abstracta - pertenese a una clase que solo se forma con miembros abstractos
                                        // son de tipo referencia no se puede crear objetos . mas bien de custom type
    {
        public int id { get; set; }
        public  string reporte()   
        {
            string mensaje = string.Format("el id es;{0}", id);
            return mensaje;
        }
    }
}
