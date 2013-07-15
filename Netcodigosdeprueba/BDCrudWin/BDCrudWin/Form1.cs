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

namespace BDCrudWin
{
    public partial class frmActualizarProductos : Form
    {
        public frmActualizarProductos()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(BDCrudWin.Properties.Settings.Default.SQL2008); //Linea de conexion por  setting
        //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQL2008"].ConnectionString);

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("listarCategorias", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tblCategorias = new DataTable();
            dap.Fill(tblCategorias);
            cboCategorias.DataSource = tblCategorias;
            cboCategorias.DisplayMember = "CategoryName";// llama a tabla categorias
            cboCategorias.ValueMember = "CategoryID"; //primary key categorias

        }
        
        
        
        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("registrarProducto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nombre", txtProducto.Text);
            cmd.Parameters.AddWithValue("Categoria", cboCategorias.SelectedValue);
            cmd.Parameters.AddWithValue("Stock", txtStock.Text);
            cmd.Parameters.AddWithValue("Precio", txtPrecio.Text);
            cmd.Parameters.AddWithValue("Codigo", 0); //Parametros de salidas de datos

            cmd.Parameters["codigo"].Direction = ParameterDirection.Output;
            cn.Open();
            int fila = cmd.ExecuteNonQuery();
            cn.Close();
            if (fila!=0)
            {
                MessageBox.Show("El producto se ha registrado correctamente");
                txtCodigo.Text = cmd.Parameters["Codigo"].Value.ToString();//devuelve el valor del registro

            }

            txtProducto.Text = String.Empty;
            txtStock.Text = String.Empty;
            txtPrecio.Text = String.Empty;
            cboCategorias.SelectedIndex=0;



        }

        private void BtnActualizarRegistros_Click(object sender, EventArgs e)
        {
            ActualizarRegistros cambioFormulario = new ActualizarRegistros();
            cambioFormulario.Show();
        }

       
    }
}
