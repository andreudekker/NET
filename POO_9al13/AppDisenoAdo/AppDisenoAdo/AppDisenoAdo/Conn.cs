using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace AppDisenoAdo
{
    class Conn
    {
        #region Variables
        string SqlServer = "", SqlUser= "", SqlPassword = "", SqlDataBase = "",  NTaut = "";
        #endregion
       
        #region Metodo construir la conexion BD
        private string connectionstringcustom()
        {
            string  StrConn;
            try
            {
                if (NTaut.ToLower() == "false")

                    StrConn = "server=" + SqlServer + ";  uid=" + SqlUser + ";  pwd=" + SqlPassword + "; database=" + SqlDataBase;

                else
                    StrConn = "DataSource=" + SqlServer + "; Integrated security=SSPI" + "; InitialCatalog=" + SqlDataBase;
                return StrConn;
            }

            catch (Exception ex)
            {
                throw new Exception("SQL connection error:" + ex.Message);
            }
     
        }
    #endregion
        
        #region Retorna la conexion
            public string getconnectionstring(string DB)
            {

                try
                {
                    SqlServer = ConfigurationManager.AppSettings["SqlServer"].ToString();
                    SqlUser = ConfigurationManager.AppSettings["SqlUser"].ToString();
                    SqlPassword = ConfigurationManager.AppSettings["SqlPassword"].ToString();
                    SqlDataBase = DB;
                    NTaut = ConfigurationManager.AppSettings["NtAutentication"].ToString();
                    return connectionstringcustom();
            
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en el metodo ConnectionString" + ex.Message);
                }
                
               
            
            }
#endregion
    
    }
}
