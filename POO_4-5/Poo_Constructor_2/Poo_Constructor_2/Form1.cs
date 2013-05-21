using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poo_Constructor_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModificaConstructor boton = new ModificaConstructor();
            boton.Puertas = 4;

            label1.Text = "numero de puertas es:" + boton.Puertas;
         

        }
    }
}
