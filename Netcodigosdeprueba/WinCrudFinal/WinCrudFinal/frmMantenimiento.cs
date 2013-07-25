using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinCrudFinal
{
    public partial class frmMantenimiento : Form
    {
        public frmMantenimiento()
        {
            InitializeComponent();
        }
        public enum Operacion : int
        { 
            Nuevo =1,
            Editar =2,
            Eliminar = 3
        }
        #region SeleccionarcamposdesdeSQlserver
        //Select * from sysobjects
        //where type ='u'

        //select * from syscolumns where id=117575457 
        ///*columnas del objeto seleccionado*/

        //public datatype PropertyName{get;set}


        //select 'public'+ 
        //case 
        //    when xtype =56 then 'int '
        //    when xtype =231 then 'string '
        //    when xtype =52 then 'short '
        //    when xtype =60 then 'decimal '
        //end + name +' {get; set;} '
        //from syscolumns where id=117575457 

        ///*Como encotrar los codigos*/
        //select * from systypes
        #endregion
        
        public Operacion operacion { get; set; }  //propiedad del enum
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
 

        SqlConnection cn = new SqlConnection(WinCrudFinal.Properties.Settings.Default.CnNw);
        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            
            
            switch (operacion)
            {
                case Operacion.Nuevo:
                    btnGrabar.Text = "Grabar";
                    this.Text = "Agregar Producto";
                    deshabilitarControles(false);
                    break;
                case Operacion.Editar:
                    btnGrabar.Text = "Actualizar";
                    this.Text = "Editar Producto";
                    mostrarDatos();
                    deshabilitarControles(false);
                    txtCodigo.ReadOnly = true;
                    break;
                case Operacion.Eliminar:
                    btnGrabar.Text = "Eliminar";
                    this.Text = "Eliminar Producto";
                    mostrarDatos();
                    deshabilitarControles(true);
                    break;
                default:
                    break;
            }

        }

        public void mostrarDatos()
        {
            txtCodigo.Text = ProductID.ToString();
            txtNombredelProducto.Text = ProductName;
            txtPrecio.Text = UnitPrice.ToString();
            txtStock.Text = UnitsInStock.ToString();
        }
        public void deshabilitarControles(bool estado)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).ReadOnly = estado;
                }
            }
        }

        private void txtPrecio_validarDigitos(object sender, KeyPressEventArgs e)
        {
            e.Handled=!(char.IsDigit(e.KeyChar) || ((int)e.KeyChar) == 8);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("",cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int fila = 0;
            switch (operacion)
            {
                case Operacion.Nuevo:
                    cmd.CommandText = "registrarProducto";
                    cmd.Parameters.AddWithValue("Codigo", 0);
                    cmd.Parameters.AddWithValue("Nombre",txtNombredelProducto.Text);
                    cmd.Parameters.AddWithValue("Categoria",1);
                    cmd.Parameters.AddWithValue("Precio",txtPrecio.Text);
                    cmd.Parameters.AddWithValue("Stock",txtStock.Text);
                     
                       cmd.Parameters["Codigo"].Direction = ParameterDirection.Output;
                       fila = cmd.ExecuteNonQuery();
                       if (fila != 0)
                       {
                           MessageBox.Show(@" El producto Ha sido registrado satisfactoriamente con codigo"+cmd.Parameters["codigo"].Value.ToString());
                       }

                    break;
                case Operacion.Editar:
                    cmd.CommandText = "SP_actualizarregistros";
                        cmd.Parameters.AddWithValue("Codigo", 0);
                        cmd.Parameters.AddWithValue("Nombre",txtNombredelProducto.Text);
                        cmd.Parameters.AddWithValue("Precio",txtPrecio.Text);
                        cmd.Parameters.AddWithValue("Stock",txtStock.Text);
                    
                         fila = cmd.ExecuteNonQuery();
                       if (fila!=0)
                       {
                           MessageBox.Show("El producto se actualizo satisfactoriamente ");
                       }
                    
                    break;
                case Operacion.Eliminar:
                    cmd.CommandText = "SP_eliminarproducto";
                    cmd.Parameters.AddWithValue("Codigo",txtCodigo.Text);
                     fila = cmd.ExecuteNonQuery();
                       if (fila!=0)
                       {
                           MessageBox.Show("El producto se Elimino satisfactoriamente ");
                       }
                    break;
                default:
                    break;
            }

            cn.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    
    }
}
