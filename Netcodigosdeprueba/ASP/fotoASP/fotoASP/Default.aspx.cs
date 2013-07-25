using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace fotoASP
{

    public partial class Default : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NwCn"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
	            {
                    SqlDataAdapter dap = new SqlDataAdapter("sp_listarpaisesASPFoto", cn);
                    dap.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable tblEmpleado = new DataTable();
                    dap.Fill(tblEmpleado);
                    ddlEmpleado.DataSource = tblEmpleado;
                    ddlEmpleado.DataTextField = "LastName";
                    ddlEmpleado.DataValueField = "EmployeeID";
                    ddlEmpleado.DataBind();

	            }
        }

        protected void ddlEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgEmpleado.ImageUrl = "ProcesarFoto2.ashx?Codigo" + ddlEmpleado.SelectedValue.ToString();
        }
    }
}