using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; // agregado para listar la unidades

namespace Winforms_imagen
{
    public partial class frmvisualizar : Form
    {
        public frmvisualizar()
        {
            InitializeComponent();
        }

        private void frmvisualizar_Load(object sender, EventArgs e)
        {
            DriveInfo[] unidades = DriveInfo.GetDrives();
            foreach (DriveInfo item in unidades)
            {
                cboUnidad.Items.Add(item.Name);
            }
            cboUnidad.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = cboUnidad.Text;
       
            if (fbd.ShowDialog()==System.Windows.Forms.DialogResult.OK)  //ventana de imagenes con ShowDialog..
            {
                txtDirectorio.Text = fbd.SelectedPath;
                mostrarArchivos();
            }
        }

        private void mostrarArchivos()
        {
            DirectoryInfo df = new DirectoryInfo(txtDirectorio.Text);
            FileInfo[]archivos= df.GetFiles("*.jpg", SearchOption.AllDirectories); //tipodearchivos
            foreach (FileInfo item in archivos)
	        {
		         lstArchivos.Items.Add(item.FullName);
	        }
        }

        private void lstArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            PicFoto.Image = Image.FromFile(lstArchivos.Text);
        }
    }
}
