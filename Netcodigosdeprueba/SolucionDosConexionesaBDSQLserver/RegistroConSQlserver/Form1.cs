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

namespace RegistroConSQlserver
{
    public partial class FrmRegistrarConSQl : Form
    {
        public FrmRegistrarConSQl()
        {
            InitializeComponent();
        }
        #region proceduredeestePrograma
            // create proc sp_registrarproductosconid
            //@nombre nvarchar(50),
            //@numeroproducto nvarchar(25),
            //@color nvarchar(15),
            //@costoestandar money,
            //@listadeprecio money
            //as
            //  insert into Production.Product
            //  (Name,ProductNumber,Color,StandardCost,ListPrice) values(@nombre,@numeroproducto,@color,@costoestandar,@listadeprecio)
            //go
        #endregion

        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLregistro"].ConnectionString);
        private void FrmRegistrarConSQl_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("sp_listarproductos", cnn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tblCategorias = new DataTable();
            dap.Fill(tblCategorias);
            
            cboNumerodelproducto.DataSource=tblCategorias;
            cboNumerodelproducto.DisplayMember="ProductNumber";
            cboNumerodelproducto.ValueMember="ProductID";

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_registrarproductosconid");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nombre",txtNombre.Text );
            cmd.Parameters.AddWithValue("Numeroproducto", cboNumerodelproducto.SelectedValue);//para el comboBox
            cmd.Parameters.AddWithValue("color", txtColor.Text);
            cmd.Parameters.AddWithValue("costosestandar", txtCostoEstandar.Text);
            cmd.Parameters.AddWithValue("listadeprecio", txtListaPrecios.Text);
            
            cmd.Parameters.AddWithValue("Codigo", 0);
            cmd.Parameters["Codigo"].Direction = ParameterDirection.Output;
            cnn.Open();
             int fila =cmd.ExecuteNonQuery();
             cnn.Close();
             if (fila!=0)
             {
                 MessageBox.Show("El producto se registro satisfactoriamente");
                 txtCodigo.Text = cmd.Parameters["codigo"].Value.ToString();
                 txtNombre.Text = string.Empty;
                 txtColor.Text = string.Empty;
                 txtCostoEstandar.Text = string.Empty;
                 txtListaPrecios.Text = string.Empty;
                 cboNumerodelproducto.SelectedIndex = 0;
             }
        }
    }
}
