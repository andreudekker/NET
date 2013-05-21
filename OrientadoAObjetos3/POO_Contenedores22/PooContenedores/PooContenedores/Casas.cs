using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooContenedores
{
    class Casas
    {
        public string modelo;
        public string numero;
        public Habitaciones hab;

        public Comprador cliente = new Comprador();
        public class Comprador
        {
            public string nombre;
            public string telefono;
            public DateTime fechadecompra;
        
        }
    }
}
