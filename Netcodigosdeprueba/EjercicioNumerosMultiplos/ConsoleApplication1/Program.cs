using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

          ////Se requiere un programa que imprima en pantalla los números de 1 a 100, pero para los múltiplos de 3 se debe imprimir "Hola" 
          //  en lugar del número, para los múltiplos de 5 se debe escribir "Mundo" en lugar del número. Si el número es múltiplo de 3 y 5 
          //  debe escribir "HolaMundo" en lugar del número.
            
            
            
            
            
            
            
            //int numero=1;


            //while (numero <= 100)
            //{
            //    Console.WriteLine(numero);
            //    Console.WriteLine("-----");
            //    numero = numero + 1;

            //}

            //for (int i = 0, j = 0; i <= 100; i =i + 3, j =j+5)
            //{
            //    Console.WriteLine("Hola" + i + ", Mundo" + j);
            //}

            //for (int i = 0; i <= 100; i = i + 3)
            //{
            //    Console.WriteLine("Hola," + i);
            //}
            
            //int i = 0;
         
            //while (i <=100)
            //{
            //    Console.WriteLine("hola"+i);
                
            //    i= i+3;
                  
            //}
            //for (int j = 0; j <= 100; j = j + 5)
            //{
            //    Console.WriteLine("Mundo" + j);
            //}

            //for (int i = 0; i <= 100; i=i+3)
            //{
            //    Console.WriteLine("hola" + i );
            //}
            //for (int j = 0; j <= 100; j = j + 5)
            //{
            //    Console.WriteLine( "mundo" + j);
            //}
            //Console.ReadLine();

            //int numero = 1;


            //while (numero <= 1)
            //{
            //    for (int i = 0, j = 0; i <= 100; i = i + 3, j = j + 5)
            //    {
                    
            //        Console.WriteLine("Hola" + i + ", Mundo" + j);
            //        if (j<=100)
            //        {
            //            Console.WriteLine("este" + j);
            //        }
            //    }
       
                
              
            //    numero = numero + 1;

            //}


                    //int cont = 0;
                    //for (int i = 0, j = 0; i <= 100; i++, j++)
                    //{
                    //    if (i % 5 == 0)
                    //    {
                    //        Console.WriteLine("hola" + i);
                    //    }
                    //    if (j % 3 == 0)
                    //    {
                    //        Console.WriteLine("mundo" + j);
                    //    }
                    //    cont++;
                    //    //}

                        //int cont = 0;
                        //for (int i = 0, j = 0; i <= 100; i++, j++)
                        //{
                        //    if (i % 5 == 0 && j %3==0)
                        //    {
                        //        Console.WriteLine();
                        //    }

                        //    cont++;
                        //}

                        //int cont=0;
                        //for (int i = 0; i <= 100; i = i + 3)
                        //{
                        //    if (i % 5 == 0)
                        //    {
                        //        Console.WriteLine("hola"+i);
                        //    }
                        //    cont++;
                        //}

                        //for (int j = 0; j <= 100; j = j + 5)
                        //{
                        //    if (j % 3 == 0)
                        //    {
                        //        Console.WriteLine(j);
                        //    }
                        //    cont++;
                        //}
            // esto es:
                       //int  cont = 0;
                       // for (int i = 0; i < 100; i++)
                       // {
                       //     if (i % 5 == 0)
                       //     {
                       //         Console.WriteLine(i);
                       //     }
                       //     cont++;
                       // }

            //Ejerciciofinal
            int cont = 0;

            while (cont <= 100)
            {

                if (cont % 3 == 0)
                {
                    Console.WriteLine("Hola," + cont);

                }
                if (cont % 5 == 0)
                {
                    Console.WriteLine("Mundo" + cont);
                }

                if (cont % 3 == 0 && cont % 5 == 0)
                {
                    Console.WriteLine("HolaMundo");
                }
                cont++;

            }



               
                
                  
            
            Console.ReadLine();


                  
        
        }
    }
}
