using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace WinformBDCompletainsertdeleteupdate
{
    class ConexionBD
    {
         private string cadena;
         private SqlConnection cnn;
         private  SqlCommand cmd;
         private  SqlDataAdapter dap;


        
        public    conexoinsql()
            {
                string cnn = "Data Source=ANDREUDEKKER_\\SQLEXPRESS;Initial Catalog=Musica;Integrated Security=True";
               SqlConnection con = new SqlConnection(); 
               return true;
            }
            private bool abrir()
            {
                try 
	{	        
		 cnn= new SqlConnection(cadena);
        cnn.Open();
	}
	catch (Exception)
	{
		
		throw;
	}
                  
            }
            private bool cerrar()
            {
            }
    }
    }
}
