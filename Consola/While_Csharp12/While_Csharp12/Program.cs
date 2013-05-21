using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Csharp12
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader milector = new StreamReader("Mitexto.txt");     // I have to create Mitexto.txt with data
            
            string linea = "";
            while (linea != null)     //with an undetermined amount of numbers to use while
	        {
                    linea = milector.ReadLine();
                    if (linea != null)          // this IF without brakets
                    
                        Console.WriteLine(linea);
                   
               
            }
            milector.Close();               // and finish
            Console.ReadLine();                             //@andreudekker
        }
    }
}
