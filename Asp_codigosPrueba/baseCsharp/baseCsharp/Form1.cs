using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baseCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Constructor
        private void button1_Click(object sender, EventArgs e)
        {
            MiClase obj = new MiClase("hola",545);
            label1.Text = obj.nombre;
            label1.Text = obj.precio.ToString();
        
        }
        #endregion
        #region arreglos
        private void button2_Click(object sender, EventArgs e)
        {
            MiClase objarreglo = new MiClase();
            listBox1.Items.Add(objarreglo.arrayEjemplo[1] = "andreu");
            listBox1.Items.Add(objarreglo.arrayEjemplo2[0] = 1000);
            listBox1.Items.Add(objarreglo.arrayEjemplo3[2]);
            listBox1.Items.Add(objarreglo.arrayEjemplo3[1]);         
            listBox1.Items.Add(objarreglo.arrayEjemplo4[3]);
        }
        #endregion
        #region RecorerArreglos, y Multidimensionales
        private void button3_Click(object sender, EventArgs e)
        {
            string[] arrayEjemplo = new String[3];
            arrayEjemplo[0] = "a";
            arrayEjemplo[1] = "b";
            arrayEjemplo[2] = "c";
            for (int i = 0; i <arrayEjemplo.Length; i++)
            {
                listBox1.Items.Add(arrayEjemplo[i]);             
            }
           //arreglos multidimencionales

           string[,] arregloMulti = { { "perro", "gato", "canario" }, { "ave", "hormiga", "avestruz" } };
            for (int i = 0; i < arregloMulti.GetLength(0); i++)  //recorre el primer arreglo
            {
                for (int j = 0; j < arregloMulti.GetLength(1); j++) //recorre el segundo arreglo i filas j columnas
                {
                    listBox1.Items.Add(arregloMulti[i, j]);
                }
            }
        #endregion
        #region Metodos
            //sintaxis modificador de  accesso<static> |<tipodatoretorno>|<nombredelmetodo>|<parametros>
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sum = Suma(2, 5);
            listBox1.Items.Add(sum);
            listBox1.Items.Add(Suma(10,10)); //llamado al metodo directamente
            
           
        }
        public static int Suma(int a, int b) //con static no tengo que crear una instancia de la clase
        {
            return a + b;
        }
        public int Multiplicacion(int c, int d)
        {
             //Suma(5,3) si quisiera llamar al metodo suma lo prodira hacer pero no viceversa
            return c * d;
        }
            #endregion
        #region SobreCargadeMetodo
        private void button5_Click(object sender, EventArgs e)
        {
            int resta = Resta(10, 2);
            listBox1.Items.Add(resta);
            listBox1.Items.Add(Resta(10,2,2));
        }
        public  static int Resta(int d, int e)
        {
            return d - e;
        }
        public static int Resta(int d, int e, int f)
        {
            return d - e - f;
        }
        
        #endregion

        private void button6_Click(object sender, EventArgs e)
        {
            Persona objConstructor = new Persona();
            listBox1.Items.Add("el numero es:"+objConstructor.edad_);
            listBox1.Items.Add("El nombre es:" + objConstructor.nombre_);
        }
      
    }
}
