using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplicationPrueba
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        #region Conexion a la base de datos
        String connection = "Data Source=ANDREUDEKKER_\\SQLEXPRESS;Initial Catalog=Prueba;Integrated Security=True";
        SqlConnection conn;
        protected void conectar()
        {
            try
            {
                conn = new SqlConnection(connection);
                conn.Open();
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }
#endregion
       
        protected void Page_Load(object sender, EventArgs e)
        {
            conectar();
            SqlCommand command = new SqlCommand("SP_ConsultarClientes", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet datas = new DataSet();
            adapter.Fill(datas, "clientes");

            GridView1.DataSource = datas.Tables[0];
            GridView1.DataBind();
            conn.Close();
            
        }
        
    }
}