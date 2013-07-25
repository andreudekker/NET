using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinCrudFinal
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(WinCrudFinal.Properties.Settings.Default.CnNw);
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SP_listarproductos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            SqlDataReader lector = cmd.ExecuteReader(CommandBehavior.SingleResult);
            BindingSource bs = new BindingSource();
            bs.DataSource = lector;
            dgvProductos.DataSource = bs;
            cn.Close();
            btnNuevo.Click += Operacion_Click;
            btnEditar.Click += Operacion_Click;
            btnEliminar.Click += Operacion_Click;
        }

        #region Nofunciona
        //void btnEditar_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
        #endregion
        
        
        void Operacion_Click(object sender, EventArgs e)
        {

            frmMantenimiento frm = new frmMantenimiento();
            DataGridViewRow fila = dgvProductos.CurrentRow;
            switch ((((Button)sender).Tag.ToString()))  //cast al text
            {
                case "Nuevo":
                    //MessageBox.Show("Nuevo");
                    frm.operacion = frmMantenimiento.Operacion.Nuevo;
                    break;
                case "Editar":
                    //MessageBox.Show("Editar");
                    frm.operacion = frmMantenimiento.Operacion.Editar;
                    frm.ProductID =  Convert.ToInt32( fila.Cells["ProductID"].Value);
                    frm.ProductName=fila.Cells["ProductName"].Value.ToString();
                    frm.UnitPrice= Convert.ToDecimal(fila.Cells["UnitPrice"].Value);
                    frm.UnitsInStock= Convert.ToInt16(fila.Cells["UnitsInStock"].Value);
                    break;
                case "Eliminar":
                    //MessageBox.Show("Eliminar");
                    frm.ProductID=Convert.ToInt32(fila.Cells["ProductID"].Value);
                    frm.ProductName= fila.Cells["ProductName"].Value.ToString();
                    frm.UnitPrice=Convert.ToDecimal(fila.Cells["UnitPrice"].Value);
                    frm.UnitsInStock = Convert.ToInt16(fila.Cells["UnitsInStock"].Value);
                    frm.operacion = frmMantenimiento.Operacion.Eliminar;
                    break;
            }
          DialogResult rpta=  frm.ShowDialog(); //para Actualizar el dgv
          if (rpta==System.Windows.Forms.DialogResult.OK)
          {
             //FrmProductos_(null,null); //llenar el dgv
             // frm
             
              //FrmProductos_Load(null,null)//linea que se deberia activar
          }
          else if (rpta==System.Windows.Forms.DialogResult.Cancel)
          {
              
          }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
