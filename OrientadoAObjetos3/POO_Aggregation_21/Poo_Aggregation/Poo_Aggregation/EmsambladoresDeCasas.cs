using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Aggregation
{
    class EmsambladoresDeCasas
    {
            
        public Casas armadores (string tipo, Habitaciones tipodehabitaciones)
    {
        Casas casanueva = new Casas();
        casanueva.modelo = tipo;
        casanueva.hab = tipodehabitaciones;

        return casanueva;

    }
    
    }
}
