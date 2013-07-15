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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(BDcompletaCRUD_winform.Properties.Settings.Default.CnNw);
        //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnNw"].ConnectionString);
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("listarCategorias", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tblCategorias = new DataTable();
            dap.Fill(tblCategorias);
            cboCategorias.DataSource = tblCategorias;
            cboCategorias.DisplayMember = "CategoryName";
            cboCategorias.ValueMember = "CategoryID";

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("registrarProducto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nombre", txtProducto.Text);
            cmd.Parameters.AddWithValue("Categoria", cboCategorias.SelectedValue);
            cmd.Parameters.AddWithValue("Stock", txtStock.Text);
            cmd.Parameters.AddWithValue("Precio", txtPrecio.Text);
            cmd.Parameters.AddWithValue("Codigo", 0);

            cmd.Parameters["codigo"].Direction = ParameterDirection.Output;
            cn.Open();
            int fila = cmd.ExecuteNonQuery();
            cn.Close();
            if (fila!=0)
            {
                MessageBox.Show("Se ha registrado correctamente");
                txtCodigo.Text = cmd.Parameters["Codigo"].Value.ToString();
            }
            
            txtProducto.Text = String.Empty;
            txtStock.Text = String.Empty;
            txtPrecio.Text = String.Empty;
            cboCategorias.SelectedIndex = 0;


        }

        private void BtnIrActualizar_Click(object sender, EventArgs e)
        {
            frmActualizarRegistros frmActualizar = new frmActualizarRegistros();
            frmActualizar.Show();
        }
    }
}
