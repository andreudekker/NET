using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;    //añadir

namespace POO_namespaceGenericlist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList inventario = new ArrayList();
            Vehiculos v1 = new Vehiculos();
            v1.marca = "Toyota";
            v1.modelo = "Corola";
            v1.fechadefabricacion = 2009;

            Vehiculos v2 = new Vehiculos();
            v2.marca = "pegueot";
            v2.modelo = "206";
            v2.fechadefabricacion = 2005;

            Vehiculos v3 = new Vehiculos();
            v3.marca = "mazda";
            v3.modelo = "asahi";
            v3.fechadefabricacion = 2001;

            Peliculas pe= new Peliculas();
            pe.Nombre = "andres";
            pe.Protagonista = "larisa";
            pe.Genero = "drama-comedia";

            inventario.Add(v1);
            inventario.Add(v2);

            listBox1.Items.Add("Cantidad disponible de vehiculos");
            foreach (object items in inventario)
            {
                Vehiculos carro = (Vehiculos)items;
                //Peliculas carroa = (Peliculas)items;
                listBox1.Items.Add(carro.reporte());
            }

        }
    }
}
