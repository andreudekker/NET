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

namespace WindatareaderListarProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SqlConnection cn = new SqlConnection(WindatareaderListarProductos.Properties.Settings.Default.CnNw);
        //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnNw"].ConnectionString);
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnListarProductos_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(WindatareaderListarProductos.Properties.Settings.Default.CnNw);
            SqlCommand cmd = new SqlCommand("SP_listarproductos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            SqlDataReader lector =cmd.ExecuteReader(CommandBehavior.SingleResult);
            BindingSource bs=new BindingSource();
            bs.DataSource= lector;
            dgvProductos.DataSource=lector;

            cn.Close();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
