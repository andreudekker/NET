using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericList
{
    interface Ireporteable                                  // la sintaxis correcta es InombreABle,   la I de interfaces nombredela clase  y el ABLE que esta disponible 
    {
                                                                        //uso de las interface como las clases solo pueden  heredar una sola vez pero  se pueden implementar multiples interfaces
        string reporte();                                              // para que sea funcional se debe crear un metodo en este ejemplo se debe tener en cuenta solo el header no el body del metodo
    }
}


//una interfaz: un conjunto de metodos para los cuales no se da una implementacion se les define como los metodos abstractos. una clase que solo cuenta con miembros abstractos  son de tipo referncia no se pueden crear objetos solo tipos que deriven de ellas. como los custom types 