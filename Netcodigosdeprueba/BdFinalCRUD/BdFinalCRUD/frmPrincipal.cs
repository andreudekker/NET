using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BdFinalCRUD
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(BdFinalCRUD.Properties.Settings.Default.NwCn);
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_mostrardatos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            SqlDataReader lector = cmd.ExecuteReader(CommandBehavior.SingleResult);
            BindingSource bs = new BindingSource();
            bs.DataSource = lector;
            dgvlistaregistros.DataSource = bs;
            cn.Close();
            btnNuevo.Click+=operacion_Click;
            btnEditar.Click+=operacion_Click;
            btnBorrar.Click += operacion_Click;

        }

        private void operacion_Click(object sender, EventArgs e)
        {
            frmedicionBD frm = new frmedicionBD();
            DataGridViewRow fila = dgvlistaregistros.CurrentRow;
            switch ((((Button)sender).Tag.ToString()))
            {
                case "Nuevo":
                                 //MessageBox.Show("Nuevo");
                                 frm.menucrud = frmedicionBD.menu.Nuevo;

                break;
                case "Editar":
                              //MessageBox.Show("Editar");
                              frm.menucrud = frmedicionBD.menu.Editar;
                              frm.codigo = Convert.ToInt32(fila.Cells["codigo"].Value);
                              frm.nombrecompleto=fila.Cells["nombrecompleto"].Value.ToString();
                              frm.descripcion = fila.Cells["descripcion"].Value.ToString();
                              frm.telefono = Convert.ToInt32(fila.Cells["telefono"].Value);
                                
                break;
                case "Borrar":
                             //MessageBox.Show("Borrar");                   
                            frm.codigo = Convert.ToInt32(fila.Cells["codigo"].Value);
                            frm.nombrecompleto = fila.Cells["nombrecompleto"].Value.ToString();
                            frm.descripcion = fila.Cells["descripcion"].Value.ToString();
                            frm.telefono = Convert.ToInt32(fila.Cells["telefono"].Value);
                             
                             frm.menucrud = frmedicionBD.menu.Borrar;
                            
                break;
      
            
            }
            //frm.ShowDialog();
            DialogResult rpta = frm.ShowDialog();
            if (rpta==System.Windows.Forms.DialogResult.OK)
            {
                frmPrincipal_Load(null, null);
            }
            else if (rpta==System.Windows.Forms.DialogResult.Cancel)
            {
                
            }
        
        }
    }
}
