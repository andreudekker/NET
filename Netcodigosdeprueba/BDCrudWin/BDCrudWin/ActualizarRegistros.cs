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

namespace BDCrudWin
{
    public partial class ActualizarRegistros : Form
    {
        public ActualizarRegistros()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(BDCrudWin.Properties.Settings.Default.SQL2008);  //Conexion setting
        //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQL2008"].ConnectionString);
       public void ActualizarRegistros_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("SP_listarproductos", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tblProductos = new DataTable();
            dap.Fill(tblProductos);

            dgvProductos.DataSource = tblProductos;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SP_actualizarregistros",cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codigo", txtCodigo.Text);
            cmd.Parameters.AddWithValue("nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("precio",txtPrecio.Text);
            cmd.Parameters.AddWithValue("stock", txtStock.Text);
            //cmd.Connection.Open();  //opcional para abrir conexion
            cmd.Connection.Open();
            //cn.Open();

            int filas = cmd.ExecuteNonQuery();
            cn.Close();
            if (filas!=0)
            {
                MessageBox.Show("El producto fue actualizado correctamente");
                limpiarControles();
                //txtCodigo.Text = String.Empty; codigo para limpiar textbox 1*1
                //txtNombre.Text = String.Empty;
                //txtPrecio.Text = String.Empty;
                //txtStock.Text = String.Empty;
            }
            ActualizarRegistros_Load(null, null); ///actualiza los registros del datagrid
            dgvProductos.FirstDisplayedScrollingColumnIndex = posicion; //organizar el datagrid view al momento de guardar los datos                                       ///
        }

        public int posicion = 0; //posicion de la tabla en el formulario
        
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = e.RowIndex;   //asigno la posicion
            DataGridViewRow fila = dgvProductos.Rows[posicion];
            txtCodigo.Text = fila.Cells[0].Value.ToString();
            txtNombre.Text = fila.Cells[1].Value.ToString();//desplazarme con el mouse por las celdas
            txtPrecio.Text = fila.Cells[2].Value.ToString();
            txtStock.Text = fila.Cells[3].Value.ToString();
        }

        //Limpiar todos los textbox's de un form
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
