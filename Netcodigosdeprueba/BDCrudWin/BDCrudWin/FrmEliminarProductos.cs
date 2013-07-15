using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BDCrudWin
{
    public partial class FrmEliminarProductos : BDCrudWin.ActualizarRegistros
    {
        public FrmEliminarProductos()
        {
            InitializeComponent();
        }
        #region SP_borrarRegistro
        //SP_borrarregistro
            //        create proc SP_eliminarproducto
            //@codigo int
            //as
            //delete Products where ProductID=@codigo
        //go
        #endregion

        SqlConnection cn = new SqlConnection(BDCrudWin.Properties.Settings.Default.SQL2008);
        //SqlConnection cn= new SqlConnection(ConfigurationManager.ConnectionStrings["SQL2008"].ConnectionString);
        private void FrmEliminarProductos_Load(object sender, EventArgs e)
        {
            DialogResult rpta= MessageBox.Show("Deseas realmente eliminar el registro","en esta base de datos",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (rpta == System.Windows.Forms.DialogResult.Yes)// si es verdadera
	        {
		        SqlCommand cmd = new SqlCommand("SP_eliminarproducto",cn);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("codigo",txtCodigo.Text);
               
	                 try 
	                {	        
		                    cn.Open();
                            int filas = cmd.ExecuteNonQuery();
                            cn.Close();
                         if (filas!=0)
	                    {
		                            MessageBox.Show("El producto fue eliminado satisfactoriamente","Andreu dekker");
                                  
                                     ActualizarRegistros_Load(null,null);

                                   
	                    }
	               }
	                catch (SqlException sqlex)
	                {
                        if (cn.State !=ConnectionState.Closed)
                        {
                            cn.Close();
                        }
		                MessageBox.Show("Ocurrio un error"+sqlex.Message);
	                }
                        
                     catch (Exception ex)
	                {
                        if (cn.State != ConnectionState.Closed)
                        {
                            cn.Close();
                        }
		                MessageBox.Show("Ocurrio un error"+ex.Message);
	                }
                        
            
            }
        }
   
    }
}
