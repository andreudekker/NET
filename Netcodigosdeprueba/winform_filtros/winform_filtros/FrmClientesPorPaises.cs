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

namespace winform_filtros
{
    public partial class FrmClientesPorPaises : Form
    {
        public FrmClientesPorPaises()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(winform_filtros.Properties.Settings.Default.CnNw);
        //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnNw"].ConnectionString);
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("SP_Paises", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tbl = new DataTable();
            dap.Fill(tbl);
            cboPais.DataSource = tbl;
            cboPais.DisplayMember = "Country";
            cboPais.ValueMember = "country"; //valor que deseo mostrar
            //dgvClientes.DataSource = tbl;


           
        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_clienteporpais", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Pais", cboPais.Text);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            dap.Fill(tbl);
            dgvClientes.DataSource = tbl;
            lblRegistro.Text = String.Format("Se encontraron {0} Clientes",tbl.Rows.Count); //numero de clientes encontrados

        }
    }
}
