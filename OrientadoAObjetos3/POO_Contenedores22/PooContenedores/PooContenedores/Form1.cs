using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PooContenedores
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
            casa1.tamaño = "560 mts";
            casa1.puertas = 2;
            casa1.color = "Verde";
            Habitaciones casa2 = new Habitaciones();
            casa2.tamaño = "123 mts";
            casa2.puertas = 3;
            casa2.color = "Morado";
            Habitaciones casa3 = new Habitaciones();
            casa3.tamaño = "953mts";
            casa3.puertas = 4;
            casa3.color = "Cafe";
           
            Casas micasa = new Casas();
            micasa.cliente.nombre = "Carlos";
            micasa.cliente.telefono = "216541532";
            micasa.cliente.fechadecompra = DateTime.Now;

            label1.Text = micasa.cliente.nombre.ToString();

        }
    }
}
