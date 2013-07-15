using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BDcompletaCRUD_winform
{
    public partial class FrmEliminarRegitros : BDcompletaCRUD_winform.frmActualizarRegistros
    {
        public FrmEliminarRegitros()
        {
            InitializeComponent();
        }

        private void FrmEliminarRegitros_Load(object sender, EventArgs e)
        {

        }
        SqlConnection cn = new SqlConnection(BDcompletaCRUD_winform.Properties.Settings.Default.CnNw);
        //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnNw"].ConnectionString);
        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            DialogResult rpta = MessageBox.Show("Estas seguro que desea eliminar el registro","Andreudekker",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rpta != DialogResult.Yes)
            {
                SqlCommand cmd= new SqlCommand("SP_eliminarproducto",cn);
                cmd.CommandType= CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("Codigo",txtCodigo.Text);
            
            try 
	            {	        
		              cn.Open();
                      int filas= cmd.ExecuteNonQuery();
                      cn.Close();
                        if (filas !=0)
	                {
		                    MessageBox.Show("El producto fue eliminado satisfactoriamente");
                            FrmEliminarRegitros_Load(null,null);  //cargar nuevamente la lista de productos
	                }
	            }
	            catch (SqlException sqlex)
	            {
		        MessageBox.Show("Ocurrio un error"+sqlex.Message);
                if (cn.State !=ConnectionState.Closed)
                {
                    cn.Close();
                }
	            }  
               catch (Exception ex)
	            {
		        MessageBox.Show("Ocurrio un error"+ex.Message);
                if (cn.State!= ConnectionState.Closed)
                {
                    cn.Close();
                }
		         
	            }  
            
            }
       
        
        
        
        
        
        
        
        }
    }
}
