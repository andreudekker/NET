using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace AspCrud
{
    public partial class productos : System.Web.UI.Page
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NwCn"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
          
            SqlDataAdapter dap = new SqlDataAdapter("sp_listarproductosASP", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tblProducto = new DataTable();
            dap.Fill(tblProducto);
            gvProductos.DataSource = tblProducto;
            gvProductos.DataBind();
        }
    }
}