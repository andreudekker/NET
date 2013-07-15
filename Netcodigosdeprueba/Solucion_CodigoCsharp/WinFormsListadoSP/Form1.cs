using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WinFormsListadoSP
{
    public partial class FrmLIstadeproductos : Form
    {
        public FrmLIstadeproductos()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLSERVER"].ConnectionString);

        private void btnListar_Click(object sender, EventArgs e)
        {
            listarconsp();
          
        }
    
        public void listarconsp()
    
        {
            SqlDataAdapter dap = new SqlDataAdapter("sp_listarproductos", cnn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tblProducto = new DataTable();
            dap.Fill(tblProducto);
            gvListar.DataSource=tblProducto;
        }
    
    }
}
