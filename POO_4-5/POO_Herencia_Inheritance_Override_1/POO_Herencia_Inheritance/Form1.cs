using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Herencia_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Camioneta todoterreno = new Camioneta();
            todoterreno.Color = "Rojo";
            todoterreno.Marca = "Peugeout";
            todoterreno.Puertas = 4;
            todoterreno.capacidaddecarga();

            label1.Text = "Mi vehiculo es:" + todoterreno.Marca + ", y puede cargar:" + todoterreno.capacidaddecarga();

            List<string> items = new List<string>();
            items.Add(todoterreno.capacidaddecarga());
            items.Add(todoterreno.capacidaddecarga());
            items.Add(todoterreno.capacidaddecarga());
            listBox1.DataSource = items;
        }
    }
}
