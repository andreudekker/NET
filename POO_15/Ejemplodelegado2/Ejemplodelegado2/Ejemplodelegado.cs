using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplodelegado2
 {
    
    class Ejemplodelegado
    {
        public delegate string mimetododelegate(int miInt);
       public class miclasesimple
       {
                public string mistringmetodo(int miInt)
                {
                    if (miInt > 0)         
                        return ("positivo");
                    if (miInt < 0)
                        return ("Negativo");
                    return ("cero");
                }

                public static String mysignMethod(int miInt)
                {
                    if (miInt > 0)

                        return ("+");
                    if (miInt < 0)
                        return ("-");
                    return ("");
                }    
        }
    }
}
