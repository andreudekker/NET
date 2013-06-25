using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoBD
{
    public partial class winApp : Form
    {
        public winApp()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola"+ ' ' + txtFname.Text + ' '+ txtLname.Text+ ' ' + 
           "Bienvenido a una aplicacion windows", "Bienvenido", MessageBoxButtons.OKCancel,
           MessageBoxIcon.Information);
           
            userInfo formulario = new userInfo(); 
            formulario.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    
    }
}
