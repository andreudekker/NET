using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitar_Datos_Csharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los datos y presione la tecla enter");                         //request data
            string  datosDeUsuario;                                                                                     //variable of user
            datosDeUsuario = Console.ReadLine();                                            
            Console.WriteLine("Usted escribio lo siguiente:"+" " + datosDeUsuario);           //data show that user wrote
            Console.ReadLine();
        }
    }
}
