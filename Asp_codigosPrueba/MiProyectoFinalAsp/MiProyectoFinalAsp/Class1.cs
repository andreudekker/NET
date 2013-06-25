using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;


namespace MiProyectoFinalAsp
{
    public class Class1
    {
        private SqlConnection conectar;
        private SqlCommand comando;
        private SqlDataAdapter adaptador;
        private DataTable tabla;
        //
        private void inicia()
        {
            try 
	{
        conectar = new SqlConnection();
        conectar.ConnectionString = "Data Source=ANDREUDEKKER_\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True";
        conectar.Open();

	}
	catch (Exception e)
	{
		
		throw e ;
	}
        }
    
    public bool guardardatos(string nom_proyecto ,string cod_tipo)
    
    {
        inicia();
        try
        {
            comando = new SqlCommand("guardardatos", conectar);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter prm1 = new SqlParameter("@nom_proyecto", nom_proyecto);
            SqlParameter prm2 = new SqlParameter("@cod_tipo", cod_tipo);
            comando.Parameters.Add(prm1);
            comando.Parameters.Add(prm2);
            comando.ExecuteNonQuery();
            return true;

        }
        catch (Exception)
        {

            return false;
        }
    }

    public DataTable Datos(string str)
    {
        inicia();
        try
        {
            adaptador = new SqlDataAdapter(str, conectar);
            tabla = new DataTable();
            adaptador.Fill(tabla);
        }
        catch (Exception)
        {
            
           
        }
        return tabla;
    }

    }
}