using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WinformsRegistroSQl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region spregistroproductos
        //create proc sp_registrarProductosFastFood
        //@descripcion nvarchar(20),
        //@Unidaddemedida nvarchar(20),
        //@costo nvarchar(20),
        //@preciodeventa nvarchar(20)
        //as
        //insert into productos
        //(descripcion,unidaddemedida,coste,precioventa)
        //values(@descripcion,@Unidaddemedida,@costo,@preciodeventa)
        //go
        #endregion

        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLregistro"].ConnectionString);
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("sp_registrarProductosFastFood",cnn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tblDescripcion = new DataTable();
            dap.Fill(tblDescripcion);

            CboDescripcion.DataSource = tblDescripcion;
            CboDescripcion.DisplayMember = "descripcion"; //value id
            CboDescripcion.ValueMember = "idproductos";  //primarykey
        }

        private void btnRegistrarDatos_Click(object sender, EventArgs e)
        {

        }

    }
}
