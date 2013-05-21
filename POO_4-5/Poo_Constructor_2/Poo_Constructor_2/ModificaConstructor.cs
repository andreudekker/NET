using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //para iniciar el messageBox

namespace Poo_Constructor_2
{
    class ModificaConstructor  //para iniciar el constructor con el mismo nombre de la clase
    {
       
       public  ModificaConstructor()
        {
            MessageBox.Show("hola salgo de un constructor");
        }
        private int puerta;

        public int Puertas
        {
            get { return puerta; }
            set { puerta = value; }
        }
        

    }
}
