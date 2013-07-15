using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;  //para modificar el registro

namespace WInformsRecuperaRegistro
{
    public partial class FrmLeerValoresRecWin : Form
    {
        public FrmLeerValoresRecWin()
        {
            InitializeComponent();
        }
        string strRuta = "HKEY_CURRENT_USER\\Software\\Microsoft\\DeveloperNET";
        private void btnRegistroWindows_Click(object sender, EventArgs e)
        {
            
            object valor=Registry.GetValue(strRuta,"titulo",null);
            txtValor.Text = valor.ToString();
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            Registry.SetValue(strRuta,"titulo", txtValor.Text);
         DialogResult resul=  MessageBox.Show("Se actualizo el registro correctamente","Developer.Net",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
         
            if (resul= System.Windows.Forms.DialogResult.No)
         {
             e.Cancel = true;
         }
        }
    }
}
