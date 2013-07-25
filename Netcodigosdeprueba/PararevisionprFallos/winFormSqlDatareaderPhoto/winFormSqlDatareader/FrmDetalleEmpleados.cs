using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO; //photo

namespace winFormSqlDatareader
{
    public partial class FrmDetalleEmpleados : Form
    {
        public FrmDetalleEmpleados()
        {
            InitializeComponent();
        }
        #region STOREPROCEDURE
                
        //SP_DETALLEEMPLEADO
        //        USE [Northwind]
                //GO
                ///****** Object:  StoredProcedure [dbo].[sp_detalleEmpleado]    Script Date: 07/15/2013 14:04:56 ******/
                //SET ANSI_NULLS ON
                //GO
                //SET QUOTED_IDENTIFIER ON
                //GO
                //ALTER proc [dbo].[sp_detalleEmpleado]
                //@codigo int
                //as
                // select FirstName,LastName,Title,Photo from Employees
                // where EmployeeID=@codigo
                //sp_detalleEmpleado 1

        //SP_LISTAREMPLEADOS
            //        USE [Northwind]
            //GO
            ///****** Object:  StoredProcedure [dbo].[sp_listarEmpleados]    Script Date: 07/15/2013 13:55:51 ******/
            //SET ANSI_NULLS ON
            //GO
            //SET QUOTED_IDENTIFIER ON
            //GO
            //ALTER proc [dbo].[sp_listarEmpleados]
            //as
            //select 0 as EmployeeID, 'seleccione' as LastName
            //union all
            //Select EmployeeID,LastName from Employees
            //sp_listarEmpleados

        #endregion

        SqlConnection cn = new SqlConnection(winFormSqlDatareader.Properties.Settings.Default.CnNw);
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_listarEmpleados", cn);
            cmd.CommandType= CommandType.StoredProcedure;
            cn.Open();
            SqlDataReader lector =cmd.ExecuteReader(CommandBehavior.SingleResult);

            BindingSource bs = new BindingSource();
            bs.DataSource = lector;
            CboEmpleados.SelectedIndexChanged-=CboEmpleados_SelectedIndexChanged; //desenlazarelevento
            CboEmpleados.DataSource = bs;
            CboEmpleados.DisplayMember = "LastName";
            CboEmpleados.ValueMember = "EmployeeID";
            CboEmpleados.SelectedIndexChanged += CboEmpleados_SelectedIndexChanged; //enlazado
            cn.Close();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CboEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
 
            int codigoEmpleado = Convert.ToInt32(CboEmpleados.SelectedValue);
            //MessageBox.Show(codigoEmpleado.ToString());
            if (codigoEmpleado!=0)
            {
                SqlCommand cmd = new SqlCommand("sp_detalleEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Codigo", codigoEmpleado);
                cn.Open();
                SqlDataReader lector = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (lector.HasRows)
                {
                    lector.Read();

                    //txtNombre.Text = lector.GetString(0);
                    txtNombre.Text = lector.GetString(lector.GetOrdinal("FirstName")); //linea Optimizada para escojer por tabla
                    //txtApellido.Text = lector.GetString(1);
                    txtApellido.Text = lector.GetString(lector.GetOrdinal("LastName"));//linea Optimizada para escojer por tabla
                    //txtTitulo.Text = lector.GetString(2);
                    txtTitulo.Text = lector.GetString(lector.GetOrdinal("Title"));//linea Optimizada para escojer por tabla
                   
                    //Foto con OLEheader
                    byte[] foto = (byte[])lector.GetValue(lector.GetOrdinal("Photo"));  //cast para la imagen
                    MemoryStream ms = new MemoryStream(foto, 78, foto.Length); // con consobrecarga 5 de 7
                    picFoto.Image = Image.FromStream(ms);
                
                    lector.Close();
                }
               cn.Close();
            }
            else
            {
                txtNombre.Text = String.Empty;
                txtApellido.Text = String.Empty;
                txtTitulo.Text = String.Empty;
            }
        }
    }
}
