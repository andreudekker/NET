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

namespace WinFormBDSQLusandoelObjetoSqlDataReader
{
    public partial class FrmListarProductos : Form
    {
        public FrmListarProductos()
        {
            InitializeComponent();
        }

     
        //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnNw"].ConnectionString);
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(WinFormBDSQLusandoelObjetoSqlDataReader.Properties.Settings.Default.CnNw);
            SqlCommand cmd = new SqlCommand("SP_listarproductos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            SqlDataReader lector = cmd.ExecuteReader(CommandBehavior.SingleResult);
            BindingSource bs = new BindingSource();
            bs.DataSource = lector;
            dgvProductos.DataSource = bs;
            cn.Close();


        }
    }
}
