using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poo_Aggregation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Habitaciones casa1 = new Habitaciones();
            casa1.tamaño = "100mts";
            casa1.puertas = 4;
            casa1.color = "Azul";

            Habitaciones casa2 = new Habitaciones();
            casa1.tamaño = "2000mts";
            casa2.puertas = 10;
            casa2.color = "Amarillo";

            //Casas micasa = new Casas();    //llamo a habitaciones con la casa1
            //micasa.hab = casa1;

            EmsambladoresDeCasas emsamblador = new EmsambladoresDeCasas();   //otra utilidad
            Casas micasa = emsamblador.armadores("Tipo II",  casa2);
           
            
            label1.Text = micasa.hab.color.ToString();




        }
    }
}
