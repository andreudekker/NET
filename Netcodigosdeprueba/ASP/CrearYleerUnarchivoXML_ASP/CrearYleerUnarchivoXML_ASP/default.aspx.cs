using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CrearYleerUnarchivoXML_ASP
{
    public partial class _default : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Nwcn"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
        }
    }
}