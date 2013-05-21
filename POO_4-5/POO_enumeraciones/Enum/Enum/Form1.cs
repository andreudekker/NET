using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MarcaDeAutos ma = new MarcaDeAutos();
            //ma.Marca = textBox1.Text;   //validacion con el region propiedadesmarcaauto
            //ma.Marca = "";
            ////ma.vehiculodeseado(ma.Marca);
            //textBox1.Text = ma.vehiculodeseado(ma.Marca);
            
            //************************************************************************
            //label1.BackColor = Color.Azure;   // enum es: definir los datos dentro de un tipo especial de clase
            //label1.BackColor = Colores.azul;   //puedo escojer de los Colores
          //*************************************************************************
            //***********************************************************
           
            //aqui valido con el enum
            textBox1.Text= ma.vehiculodeseado(marcas.Mazda.ToString());
        
        
        
        }
     }
    
    
    //****************************************************************************
    //enum Colores    // tiene que estar fuera de la clase 
    //    verde =1,
    //    blanco=2,
    //    azul =3
    //**************************************************************************
}
