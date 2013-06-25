using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace Asp_BD_Completa
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            string cadena = "Data Source=ANDREUDEKKER_\\SQLEXPRESS;Initial Catalog=registro_bd;Integrated Security=True";
            SqlConnection  conexion =new SqlConnection(cadena) ;
             
             string ad= "insert into clientes values(@Empresa,@NombreCliente,@ApellidoCliente,@Puesto,@Poblacion,@Telefono,@CP,@NumerooCC)";
            SqlCommand cmd = new SqlCommand(ad,conexion);  
            conexion.Open();

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Empresa", SqlDbType.VarChar, 50).Value = TxtEmpresa.Text;
            cmd.CommandType= CommandType.Text;
            cmd.Parameters.Add("@NombreCliente", SqlDbType.VarChar,50).Value=TxtNombre.Text;
            
            cmd.CommandType= CommandType.Text;
            cmd.Parameters.Add("@ApellidoCliente",SqlDbType.VarChar,50).Value=TxtApellido.Text;

            cmd.CommandType= CommandType.Text;
            cmd.Parameters.Add("@Puesto",SqlDbType.VarChar,50).Value=TxtPuesto.Text;

            cmd.CommandType= CommandType.Text;
            cmd.Parameters.Add("@Poblacion",SqlDbType.VarChar,50).Value=TxtPoblacion.Text;

            cmd.CommandType=CommandType.Text;
            cmd.Parameters.Add("@Telefono",SqlDbType.VarChar,50).Value=TxtTelefono.Text;

            cmd.CommandType=CommandType.Text;
            cmd.Parameters.Add("@CP",SqlDbType.VarChar,50).Value=TxtCodigoPostal.Text;

            cmd.CommandType =CommandType.Text;
            cmd.Parameters.Add("@NumerooCC", SqlDbType.VarChar, 50).Value = TxtDireccion.Text;


            cmd.ExecuteNonQuery();
            conexion.Close();


        }

        protected void BtnMostrarDatos_Click(object sender, EventArgs e)
        {
            string cadena="Data Source=ANDREUDEKKER_\\SQLEXPRESS;Initial Catalog=registro_bd;Integrated Security=True";
            SqlConnection conexion= new SqlConnection(cadena);

            conexion.Open();
            SqlDataAdapter  ad = new SqlDataAdapter("Select * from clientes",conexion);
            DataSet  ds= new DataSet();
            ad.Fill(ds,"Clientes");

          
            GridView1.DataSource = ds;    //lenar el GV
            GridView1.DataBind();
            conexion.Close();


        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            string cadena = "Data Source=ANDREUDEKKER_\\SQLEXPRESS;Initial Catalog=registro_bd;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadena);
            string ad = "DELETE  FROM clientes where CodigoCliente=@codi";
            SqlCommand cmd = new SqlCommand(ad, conexion);
            conexion.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@codi", SqlDbType.VarChar, 50).Value = TxtEliminarRegistro.Text;
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            string cadena="Data Source=ANDREUDEKKER_\\SQLEXPRESS;Initial Catalog=registro_bd;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadena);
            string ad = "UPDATE  clientes SET  Empresa=@emp, NombreCliente=@nombre, ApellidoCliente=@apellido, Puesto=@puesto, Poblacion=@poblacion, Telefono=@telefono, CP=@cp, Direccion=@direccion where CodigoCliente=@codi";
            SqlCommand cmd = new SqlCommand(ad, conexion);
            conexion.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@emp", SqlDbType.VarChar, 50).Value = TxtEmpresa.Text;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@codi",SqlDbType.VarChar,50).Value=TxtCodigoActualizar.Text;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@nombre",SqlDbType.VarChar, 50).Value = TxtNombre.Text;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@apellido",SqlDbType.VarChar,50).Value=TxtApellido.Text;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@puesto",SqlDbType.VarChar,50).Value=TxtPuesto.Text;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@poblacion", SqlDbType.VarChar, 50).Value = TxtPoblacion.Text;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@telefono",SqlDbType.VarChar,50).Value=TxtTelefono.Text;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@cp", SqlDbType.VarChar, 50).Value = TxtCodigoPostal.Text;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = TxtDireccion.Text;

            cmd.ExecuteNonQuery();
            conexion.Close();


        }
    }
}