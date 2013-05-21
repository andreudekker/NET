using System;
namespace codigodelegado
{ 
    delegate int  midelegado(int argumentoOparametro);
    class principal 
     {
        public int delegadofuncion1(int a)
        {
            Console.WriteLine("Ejecutando funcion #1");
            return ++a;
        }
        public int delegadofuncion2(int a)
        {
            Console.WriteLine("Ejecutando funcion #2");
            return  a;
        }
    }
}