using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Directorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Directorio 1.0 \n Escrito por: Andres Bernal","Acerca de");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactDBDataSet1.Gente' table. You can move, or remove it, as needed.
            this.genteTableAdapter.Fill(this.contactDBDataSet1.Gente);

        }

        private void contactDBDataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void genteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
