using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace ASP_aplicacionregistroIEA
{
    public class tienda
    {
        SqlConnection conexion = new SqlConnection();

        string mostrarError;
        //public string mostrarError
        //{
        //    get { return mostrarError; }
        //    set { mostrarError = value; }
        //}
        private bool conectarserver()
        {
            bool respuesta;
            string cadenaConexion = @"Data Source=ANDREUDEKKER_\\SQLEXPRESS;Initial Catalog=registro_IEA;Integrated Security=True ";
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                respuesta = true;
            }
            catch (Exception e)
            {

                respuesta = false;
                mostrarError = "No se ha podido conectar con el servidor,exepcion" + e.Message.ToString();
            }
            return respuesta;
        }
        #region registrarenlabd
        public bool Registrar(string tabla, string campos, string valores)
        {
            bool respuesta = false;
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO" + tabla + "(" + campos + ")VALUES(" + valores + ") ;";
                conectarserver();
                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = true;
                }
                else
                {
                    respuesta = false;
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mostrarError = "excepcion linea comando" + ex.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }

            return respuesta;
        }
        #endregion

        #region modificarenlabd
        public bool Modificar(string tabla, string campos, string condicion)
        {
            bool respuesta = false;
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "UPDATE" + tabla + "SET"+ campos + "WHERE" +condicion +") ;";
                if (conectarserver())
                {
                    if (comando.ExecuteNonQuery() == 1)
                    {
                        respuesta = true;
                    }
                    else
                    {
                        respuesta = false;
                    }
                } 
                else
	            {
                    respuesta = false;
	            }
               
            }
            catch (Exception ex)
            {
                respuesta = false;
                mostrarError = ""+ex.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }

            return respuesta;
        }
        #endregion

        #region eliminarregistrosbd
        public bool Eliminar(string tabla, string condicion)
        {
            bool respuesta = false;
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "DELETE FROM" + tabla + "WHERE" + condicion + ") ;";
                if ( conectarserver())
                {
                    if (comando.ExecuteNonQuery() == 1)
                    {
                        respuesta = true;
                    }
                    else
                    {
                        respuesta = false;
                    }
                }
               
            }
            catch (Exception ex)
            {
                respuesta = false;
                mostrarError = ""+ex.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }

            return respuesta;
        }
        #endregion
        public DataSet MostrarRegistros(string tabla)
        {
            DataSet respuesta = new DataSet();
            try
            {
                string instruccionSQL = "SELECT * FROM "+tabla+";";
                SqlDataAdapter adaptador = new SqlDataAdapter("",conexion);
                if (conectarserver())
                {
                    adaptador.Fill(respuesta, tabla);
                }

            }
            catch (Exception e)
            {

                mostrarError="mensaje de la excepcion "+e.Message.ToString();
            }
            finally
            { 
                    conexion.Close();
            }
            return respuesta;
        }
        
    }
}

