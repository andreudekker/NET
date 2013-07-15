using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BDcompletaCRUD_winform
{
    public partial class frmActualizarRegistros : Form
    {
        public frmActualizarRegistros()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(BDcompletaCRUD_winform.Properties.Settings.Default.CnNw);
        //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnNw"].ConnectionString)
        private void frmActualizarRegistros_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("SP_listarproductos", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tblProductos = new DataTable();
            dap.Fill(tblProductos);

            dgvProductos.DataSource= tblProductos;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SP_actualizarregistros", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codigo", txtCodigo.Text);
            cmd.Parameters.AddWithValue("nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("precio",txtPrecio.Text);
            cmd.Parameters.AddWithValue("stock",txtStock.Text);
            cmd.Connection.Open();

            int filas = cmd.ExecuteNonQuery();
            if (filas !=0)
            {
                MessageBox.Show("El producto fue actualizado correctamente");
                limpiarControles();
            }
            frmActualizarRegistros_Load(null, null);
           
                
             
                       
        }
        public int posicion = 0;

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dgvProductos.FirstDisplayedScrollingColumnIndex = posicion;
            posicion = e.RowIndex;

            DataGridViewRow fila = dgvProductos.Rows[posicion];
            txtCodigo.Text = fila.Cells[0].Value.ToString();
            txtNombre.Text = fila.Cells[1].Value.ToString();//desplazarme con el mouse por las celdas
            txtPrecio.Text = fila.Cells[2].Value.ToString();
            txtStock.Text = fila.Cells[3].Value.ToString();
        }

        public void limpiarControles()
        {
            foreach (Control ctrl in this.Controls)      //this hace referencia al formulario--recorremos los controles del formulario
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = String.Empty;
                }
            }
        }

       
    
 
    
    }
}
