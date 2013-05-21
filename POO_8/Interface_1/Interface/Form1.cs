using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace GenericList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            //ArrayList inventario = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {

            List<Ireporteable> inventario = new List<Ireporteable>();
            
            Vehiculos v1 = new Vehiculos();
            v1.marca = "toyota";
            v1.modelos = "corolla";
            v1.fechaDeFabricacion = 1965;

            Vehiculos v2 = new Vehiculos();
            v2.marca = "pegueot";
            v2.modelos = "206";
            v2.fechaDeFabricacion = 1996;

            Vehiculos v3 = new Vehiculos();
            v3.marca = "mazda";
            v3.modelos = "626";
            v3.fechaDeFabricacion = 1970;

            Peliculas peli = new Peliculas();
            peli.Nombre = "Alicia en el pais de las maravillas";
            peli.protagonista = "Alicia keys";
            peli.genero = "drama-comedia";

            inventario.Add(v1);
            inventario.Add(v2);
            inventario.Add(peli);

           
            foreach (var item in inventario)
            {
                
                listBox1.Items.Add(item.reporte());
            }
        
        }
    }
}
