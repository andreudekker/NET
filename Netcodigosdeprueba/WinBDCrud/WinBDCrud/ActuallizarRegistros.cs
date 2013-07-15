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

namespace WinBDCrud
{
    public partial class ActuallizarRegistros : Form
    {
        public ActuallizarRegistros()
        {
            InitializeComponent();
        }
        #region SP_storeprocedure
        //*********SP_LISTARPRODUCTOS**********************//
        //create procedure SP_listarproductos
        //as 
        //select ProductID,ProductName,UnitPrice,UnitsInStock from Products
        //go   
        //********SP_ACTUALIZAR REGISTROS*******************//
        //create proc SP_actualizarregistros
        //@codigo int,
        //@nombre varchar(40),
        //@precio money,
        //@stock  smallint
        //as

        //update Products set ProductName=@nombre,
        //                    UnitPrice=@precio,
        //                    UnitsInStock=@stock
        //                  where 
        //                  ProductID=@codigo   
        /// //********************************************************//
               #endregion

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQL2008"].ConnectionString);
        private void ActuallizarRegistros_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("SP_listarproductos", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tblproductos = new DataTable();
            dap.Fill(tblproductos);
            dgvProductos.DataSource = tblproductos;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            
            SqlCommand cmd = new SqlCommand("SP_actualizarregistros");
   
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codigo", txtCodigo.Text);
            cmd.Parameters.AddWithValue("nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("precio", TxtPrecio.Text);
            cmd.Parameters.AddWithValue("stock", TxtStock);
            //cmd.Connection.Open();  //opcional para abrir conexion
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQL2008"].ConnectionString);
            cn.Open();

            
            int filas= cmd.ExecuteNonQuery();//numero de filas afectadas
            cn.Close();
            //cmd.Connection.Close();
            if (filas!=0)
            {
                MessageBox.Show("El producto fue actualizado correctamente");
                txtCodigo.Text = string.Empty;
                txtNombre.Text= string.Empty;
                TxtPrecio.Text= string.Empty;
                TxtStock.Text = string.Empty;
            }

            ActuallizarRegistros_Load(null, null); //actualizar los registros en el datagrid
        }


        #region nofunciona
        //private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //} No funciona creadopor erron
        #endregion

        private void dgvProductos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
            txtCodigo.Text = fila.Cells[0].Value.ToString();
            txtNombre.Text=fila.Cells[1].Value.ToString(); //desplazarme con el mouse por las celdas
            TxtPrecio.Text = fila.Cells[2].Value.ToString();
            TxtStock.Text = fila.Cells[3].Value.ToString();
        }
    }
}
