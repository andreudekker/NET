using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;  //para activar el array list

namespace Collections1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList inventario = new ArrayList();        //creo el array
            Vehiculos v1 = new Vehiculos();
            v1.marca = "toyota";
            v1.modelo = "corola";
            v1.fechadefabricacion = 1998;

            Vehiculos v2 = new Vehiculos();
            v2.marca = "pegueot";
            v2.modelo = "306";
            v2.fechadefabricacion = 1998;
            Vehiculos v3 = new Vehiculos();
             v2.marca = "pegueot";
             v2.modelo = "206";
             v2.fechadefabricacion = 2000;
            
            inventario.Add(v1);
            inventario.Add(v2);
            inventario.Add(v3);
            removeragregar();
            listBox1.Items.Add("Removiendo el vehiculo v2");
            inventario.Remove(v2);
            removeragregar();

            //foreach (object  miembros  in inventario)
            //{
            //    Vehiculos carroauto = (Vehiculos)miembros;   //cast convertir un objeto ejemplo vehiculoa miembros
            //    listBox1.Items.Add(carroauto.reporte());        //foreach compacta la escritura de codigo 
            //}

        }
        public void removeragregar()
        {
            foreach (object miembros in inventario)
            {
                Vehiculos carroauto = (Vehiculos)miembros;   //cast convertir un objeto ejemplo vehiculoa miembros
                listBox1.Items.Add(carroauto.reporte());        //foreach compacta la escritura de codigo 

            }

        }
    }
}

