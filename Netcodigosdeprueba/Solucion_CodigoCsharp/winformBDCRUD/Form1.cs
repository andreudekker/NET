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

namespace winformBDCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQL2008"].ConnectionString);
        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
 
            SqlDataAdapter dap = new SqlDataAdapter("listarCategorias", cnn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tblCategorias = new DataTable();
            dap.Fill(tblCategorias);
            CboCategorias.DataSource = tblCategorias;
            CboCategorias.DisplayMember = "ProductName"; //Campo
            CboCategorias.ValueMember = "CategoryID";    //Primarykey
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
