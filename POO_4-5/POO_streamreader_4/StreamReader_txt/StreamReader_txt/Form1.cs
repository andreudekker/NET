using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StreamReader_txt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Select();   // inicializa el constructor   permite que titile el cursor
                                        // el caractercasing todo el textbox queda en mayuscula 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("almacenador.txt");
            sw.WriteLine(textBox1.Text + "." + textBox2.Text + "." + textBox3.Text);
            sw.Close();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                textBox2.Focus();
            }
            //*******************************************************************************
            //if (e.KeyChar ==(char)Keys.Enter)    //funciona igual con esta linea de codigo para ver las teclas
            //{
            //    MessageBox.Show("Correcto");
            //}
            //********************************************************************************
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)13)
            {
                textBox3.Focus();
            }
      
        
        
        
        
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                button1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader miLector = new StreamReader("almacenador.txt");
            string line = "";
            while (line!=null)
            {
                line = miLector.ReadLine();
                if (line !=null)
                {
                    string lineas = line.ToString();
                    listBox1.Items.Add(lineas.ToString());
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)  //puedo ver el numero del char
        {                                                                                                          // con anotar en el textbox
            int intvalue;
            intvalue = e.KeyChar;
            {
                listBox1.Items.Add(intvalue.ToString());
            }
        }
    }
}
