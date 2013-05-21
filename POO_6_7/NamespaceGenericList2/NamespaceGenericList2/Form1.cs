using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace NamespaceGenericList2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ArrayList inventario = new ArrayList();
            //List<Vehiculos> inventario = new List<Vehiculos>();
            List<Productos> inventario = new List<Productos>();
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

            Peliculas pe = new Peliculas();
            pe.Nombre = "andres";
            pe.Protagonista = "larisa";
            pe.Genero = "drama-comedia";

            inventario.Add(v1);
            inventario.Add(v2);
            inventario.Add(pe);

            listBox1.Items.Add("Cantidad disponible de vehiculos");
            foreach (Productos producto in inventario)
            {
                listBox1.Items.Add(producto.reporte());
            }
        }
    }
}
