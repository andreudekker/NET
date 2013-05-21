using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herencia_Inheritance
{
    class Carro
    {
        private int puerta;

        public int Puertas
        {
            get { return puerta; }
            set { puerta = value; }
        }

        private string colores;

        public string Color
        {
            get { return colores; }
            set { colores = value; }
        }
        private string marcas;

        public string Marca
        {
            get { return marcas; }
            set { marcas = value; }
        }

        private string modelos;

        public string Modelo
        {
            get { return modelos; }
            set { modelos = value; }
        }

        public virtual string iniciandoencendido()                              //overwrite 
        {
            string mensaje = "Iniciando el vehiculo...........";
            return mensaje;
        
        }
        
        

    }
}
