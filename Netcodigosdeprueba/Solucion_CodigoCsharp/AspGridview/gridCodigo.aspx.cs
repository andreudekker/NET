using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AspGridview
{
    public partial class gridCodigo : System.Web.UI.Page
    {

        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["AdventureWorks2012ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                listarRegistrodeUsuarios();
            }
            
        }

       public void listarRegistrodeUsuarios()
       {
          SqlDataAdapter Sqldap = new SqlDataAdapter("ConsultaAdventureWorks",cnn);
           Sqldap.SelectCommand.CommandType = CommandType.StoredProcedure;
           DataTable tblRegistro = new DataTable();
           Sqldap.Fill(tblRegistro);
           GridViewRegistro.DataSource =tblRegistro;
           GridViewRegistro.DataBind();
     }

       protected void GridViewRegistro_PageIndexChanging(object sender, GridViewPageEventArgs e)
       {
           GridViewRegistro.PageIndex = e.NewPageIndex;   //Para Paginar correctamente
           listarRegistrodeUsuarios();
       }

       protected void GridViewRegistro_RowEditing(object sender, GridViewEditEventArgs e)
       {
           GridViewRegistro.EditIndex = e.NewEditIndex;
           listarRegistrodeUsuarios();
       }


    }
}