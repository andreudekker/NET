using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



namespace ASP_Griedview
{
    public partial class Griedview2 : System.Web.UI.Page
    {
        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["AdventureWorks2012ConnectionString"].ConnectionString);
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (! Page.IsPostBack)
            {
                listarregistrodeusuarios();
            }
          
        }

        public void listarregistrodeusuarios()
        {
            SqlDataAdapter dap = new SqlDataAdapter("ConsultaAdventureWorks", cnn);
            dap.SelectCommand.CommandType =CommandType.StoredProcedure;
            DataTable tblregistro = new DataTable();
            dap.Fill(tblregistro);
            GridView1registro.DataSource = tblregistro;
            GridView1registro.DataBind();


        }

        protected void GridView1registro_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView1registro.PageIndex = e.NewPageIndex; //crear indice en las paginas
        }
    }
}