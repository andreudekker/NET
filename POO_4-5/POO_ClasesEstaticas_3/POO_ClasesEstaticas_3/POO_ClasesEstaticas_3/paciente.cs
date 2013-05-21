using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ClasesEstaticas_3
{
     static class  Paciente
    {
        private static string nombre;

        public static string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private static string apellido;

        public static string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        
        public static string informacion (string valor1 , string valor2)
        {
                string mensaje="Su nombre es"+ valor1 + "y su diagnostico es"+valor2;
                return mensaje;
        }

    }
}
