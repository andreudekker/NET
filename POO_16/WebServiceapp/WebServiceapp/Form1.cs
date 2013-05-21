using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebServiceapp  //recordar añadri en reference servicereference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.IgetNumbersClient Numerodeloteria = new ServiceReference1.IgetNumbersClient();
            int minimo = int.Parse(textBox1.Text);
            int maximo = int.Parse(textBox2.Text);
            int cantidad = int.Parse(textBox3.Text);
            int repeti = int.Parse(textBox4.Text);
            textBox5.Text = Numerodeloteria.getLottoNumbers(minimo, maximo, cantidad, repeti);

        }
    }
}
