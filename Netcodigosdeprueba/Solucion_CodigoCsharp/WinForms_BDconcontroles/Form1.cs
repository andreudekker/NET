using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration; //add el systemconfiguration
using System.Data.SqlClient;

namespace WinForms_BDconcontroles
{
    public partial class Form1 : Form
    {

        SqlConnection cn = null;
       
        public Form1()
        {
            InitializeComponent();
            string strConexion = ConfigurationManager.ConnectionStrings["SQlserver"].ConnectionString;
            cn = new SqlConnection(strConexion); // a nivel public
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
           
            try
            {
              //SqlConnection cn = new SqlConnection(strConexion); //a nivel private
                cn.Open();
                DataTable tblTablas = cn.GetSchema("Tables");
                DataView dv = tblTablas.AsDataView();
                dv.RowFilter = " TABLE_TYPE ='BASE TABLE' ";
                dv.Sort = "Table_Name Asc";
                tblTablas = dv.ToTable();
                CbxTabla.DataSource = tblTablas;
                CbxTabla.DisplayMember = "TABLE_NAME";
                cn.Close();
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Ocurrio un Error:" + sqlex.Message);

            }
            catch (NullReferenceException Nullex)
            {
                MessageBox.Show("Ocurrio un Error" + Nullex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error" + ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            
            ////este es el codigo del storeprocedure ALTER CREATE PROC sp_mostrarinformacionFastFood
            //    @TABLA NVARCHAR(25)
            //    AS
            //    DECLARE @SQL NVARCHAR(MAX)
            //    SET @SQL ='SELECT * FROM '+@TABLA
            //    EXEC SP_EXECUTESQL @SQL
            //    GO
            //    sp_mostrarinformacion 'registro'

            SqlDataAdapter dap = new SqlDataAdapter("sp_mostrarinformacionFastFood", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.AddWithValue("Tabla", CbxTabla.Text);
            DataTable tbl = new DataTable();
            dap.Fill(tbl);
            try
            {
                dap.Fill(tbl);
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Ocurrio un Error:" + sqlex.Message);

            }
            catch (NullReferenceException Nullex)
            {
                MessageBox.Show("Ocurrio un Error" + Nullex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error" + ex.Message);
            }
            
            
            dgvTabla.DataSource = tbl; 
        }
    }
}
