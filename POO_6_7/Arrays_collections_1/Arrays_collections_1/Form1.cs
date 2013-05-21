using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays_collections_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehiculos[] inventario = new Vehiculos[2]; //segundo parentesis defino el tamano del arreglo
            Vehiculos v1 = new Vehiculos();
            v1.marca = "toyota";
            v1.modelo= "corola";
            v1.fechadefabricacion = 1998;

            Vehiculos v2 = new Vehiculos();
            v2.marca = "pegueot";
            v2.modelo = "306";
            v2.fechadefabricacion = 1998;

            inventario[0] = v1;
            inventario[1] = v2;

            listBox1.Items.Add("Mensaje Inicial.....");
            for (int i = 0; i < 2; i++)         //recorre inventario
            {
                listBox1.Items.Add(inventario[i].reporte());
            }


        }
    }
}
