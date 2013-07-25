using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace fotoASP
{
    /// <summary>
    /// Summary description for ProcesarFoto2
    /// </summary>
    public class ProcesarFoto2 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            #region storeprocedurefoto
                       //create proc sp_mostrarfotoempleado
                        //@codigo int
                        //as
                        //select Photo from Employees
                        //where EmployeeID= @codigo
            #endregion

            int codigoempleado = int.Parse(context.Request.QueryString["Codigo"]);
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NwCn"].ConnectionString);
            SqlCommand cmd = new SqlCommand("sp_mostrarfotoempleado", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Codigo", codigoempleado);
            cn.Open();
            byte[] foto = (byte[])cmd.ExecuteScalar();
            cn.Close();
            context.Response.ContentType = "image/jpg";
            context.Response.OutputStream.Write(foto, 78, foto.Length - 78);
           
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}