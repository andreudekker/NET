using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorNew2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cometa micometa;
            Cometa miotracometa;
            micometa = new Cometa();
            miotracometa = micometa;
            
        }
    }
}
