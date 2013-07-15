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

namespace WinBDCrud
{
    public partial class InsertarRegistros : Form
    {
        public InsertarRegistros()
        {
            InitializeComponent();
        }

        #region StoredProcedure
        //******** SP_LISTAR CATEGORIAS******
        //create  proc listarCategorias
        //as 
        //select CategoryID,CategoryName from Categories
        //*************************************/
        //***********SP_REGISTRARPRODUCTO******
                //ALTER proc [dbo].[registrarProducto]
                //@nombre nvarchar(40),
                //@categoria int,
                //@precio money,
                //@stock smallint,
                //@codigo int output/*parametrodesalida*/
                //as
                //insert into Products
                //(ProductName,CategoryID,UnitPrice,UnitsInStock)
                // values 
                // (@nombre,@categoria,@precio,@stock)
                //  set @codigo = @@IDENTITY  /*Devuelve el codigo autogenerado despues del insert into
                // go
        //*********************************************



        #endregion

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQL2008"].ConnectionString);
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("listarCategorias", cn); //listoTabla categorias
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tblCategorias = new DataTable();
            dap.Fill(tblCategorias);
            cboCategorias.DataSource = tblCategorias;
            cboCategorias.DisplayMember = "CategoryName";// llama a tabla categorias
            cboCategorias.ValueMember = "CategoryID"; //primary key categorias
            
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("registrarProducto",cn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nombre",txtProductos.Text);
            cmd.Parameters.AddWithValue("Categoria", cboCategorias.SelectedValue);
            cmd.Parameters.AddWithValue("Stock", txtStock.Text);
            cmd.Parameters.AddWithValue("Precio", txtPrecio.Text);
            cmd.Parameters.AddWithValue("codigo", 0);  //Parametros de salidas de datos

            cmd.Parameters["codigo"].Direction = ParameterDirection.Output;
            cn.Open();
             int fila=cmd.ExecuteNonQuery();
             cn.Close();
             if (fila!=0)
             {
                 MessageBox.Show("El producto se registro correctamente");
                 txtCodigo.Text = cmd.Parameters["codigo"].Value.ToString();  //devuelve el valor del registro
             }

                     txtProductos.Text = string.Empty;
                     txtStock.Text = string.Empty;
                     txtPrecio.Text = string.Empty;
                     cboCategorias.SelectedIndex = 0;




        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            ActuallizarRegistros CambioFormulario= new ActuallizarRegistros();
             CambioFormulario.Show();
        }
    }
}
