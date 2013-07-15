using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Aplicacion_FastandFood_ASP
{
    public partial class _default : System.Web.UI.Page
    {

        #region Conexionalabd
        string cnn = "Data Source=ANDREUDEKKER_\\SQLEXPRESS;Initial Catalog=Musica;Integrated Security=True";
        SqlConnection conexion;

        private void conexionalabd()
        {
            try
            {
                conexion = new SqlConnection(cnn);
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
            conexionalabd();
            SqlCommand command = new SqlCommand("SP_consultaRegistro", conexion);
            command.CommandType = System.Data.CommandType.StoredProcedure;
          
           
        }

    }
}