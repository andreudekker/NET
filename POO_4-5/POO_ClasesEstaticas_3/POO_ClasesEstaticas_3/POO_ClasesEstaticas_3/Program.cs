using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ClasesEstaticas_3
{
    class Program
    {
        static void Main(string[] args)    //stactic todos los miembros son static
        {
            Paciente usuariopaciente = new Paciente();
            string  nombre = "Andres";
            string diagnostico = "Gripe";
            
            Console.WriteLine("Mensaje Inicial");
            Console.WriteLine( Paciente.informacion(nombre,diagnostico));
            Console.ReadLine();

        }
    }
}
