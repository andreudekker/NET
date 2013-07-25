using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AspCrud
{
    public partial class ClientesporPais : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NwCn"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlDataAdapter dap = new SqlDataAdapter("sp_listarpaisesASP", cn);
            //dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (!IsPostBack)
            {
                SqlCommand cmd = new SqlCommand("sp_listarpaisesASP",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                DataTable tblPaises= new DataTable();
                dap.Fill(tblPaises);
                ddPaises.DataSource=tblPaises;
                ddPaises.DataTextField="Country";
                ddPaises.DataValueField="Country";
                ddPaises.DataBind();
                
            
            

            }

        }

        protected void ddPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strPais = ddPaises.SelectedItem.Text;
            SqlCommand cmd = new SqlCommand("sp_clienteporpaisASP", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pais", strPais);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable tblclientes = new DataTable();
            dap.Fill(tblclientes);
            gvPaises.DataSource = tblclientes;
            gvPaises.DataBind();
        }
    }
}