using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace MiBaseDeDatos
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        #region conexionBD
        string conn = "Data Source=ANDREUDEKKER_\\SQLEXPRESS;Initial Catalog=Musica;Integrated Security=True";
        SqlConnection conexion;

        protected void conexionbd()
        {
            try
            {
                conexion = new SqlConnection(conn);
                conexion.Open();
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }
        #endregion


        protected void Page_Load(object sender, EventArgs e)
        {

            conexionbd();

            SqlCommand command = new SqlCommand("sp_consulta", conexion);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet data = new DataSet();
            adapter.Fill(data, "una prueba");

            GridView1.DataSource = data.Tables[0];
            GridView1.DataBind();
            conexion.Close();

       

        }
    }
}