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

namespace BdFinalCRUD
{
    public partial class frmedicionBD : Form
    {
        public frmedicionBD()
        {
            InitializeComponent();
        }

        public enum menu :int
        {
           Nuevo=1,
           Editar=2,
           Borrar=3
        }
         public menu menucrud{get;set;}
         public int codigo { get; set; }
         public string nombrecompleto { get; set; }
         public string descripcion{get;set;}
         public  int telefono{get;set;}   
           

        SqlConnection cn = new SqlConnection(BdFinalCRUD.Properties.Settings.Default.NwCn);
        private void frmedicionBD_Load(object sender, EventArgs e)
        {
            switch (menucrud)
            {
                case menu.Nuevo:
                    btnGrabar.Text = "Grabar";
                    this.Text = "Nuevo registro";                
                    deshabilitarcontroles(false);
                    txtCodigo.ReadOnly = true;
                    break;
                case menu.Editar:
                    btnGrabar.Text = "Editar";
                    this.Text="Editar registro";
                    mostrarDatos();
                    deshabilitarcontroles(false);
                    txtCodigo.ReadOnly=true;
                    break;
                case menu.Borrar:
                    btnGrabar.Text = "Borrar";
                    this.Text="Borrar registro";
                    deshabilitarcontroles(true);
                    mostrarDatos();
                    break;
                default:
                    break;
            }
        }

        public void mostrarDatos()
        {
            txtCodigo.Text = codigo.ToString();
            txtNombreCompleto.Text = nombrecompleto.ToString(); 
            txtDescripcion.Text = descripcion.ToString();
            txtTelefono.Text = telefono.ToString();
        }

        public void deshabilitarcontroles(bool estado)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).ReadOnly=estado;
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int fila = 0;
            switch (menucrud)
            {
                case menu.Nuevo:
                    cmd.CommandText = "sp_registro";
                    cmd.Parameters.AddWithValue("codigo", 0);
                    cmd.Parameters.AddWithValue("nombrecompleto", txtNombreCompleto.Text);
                    cmd.Parameters.AddWithValue("descripcion",txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("telefono",txtTelefono.Text);
                    cmd.Parameters["codigo"].Direction = ParameterDirection.Output;
                    fila = cmd.ExecuteNonQuery();
                    if (fila!=0)
                    {
                        MessageBox.Show("Registro correcto" + cmd.Parameters["codigo"].Value.ToString());
                    }
                    
                    break;
                case menu.Editar:
                     cmd.CommandText = "sp_actualizarregistro";
                    cmd.Parameters.AddWithValue("codigo", txtCodigo.Text);
                    cmd.Parameters.AddWithValue("nombrecompleto", txtNombreCompleto.Text);
                    cmd.Parameters.AddWithValue("descripcion",txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("telefono",txtTelefono.Text);
                    fila = cmd.ExecuteNonQuery();
                    if (fila!=0)
                    {
                        MessageBox.Show("Actulizacion correcta" + cmd.Parameters["codigo"].Value.ToString());
                    }

                    break;
                case menu.Borrar:
                    cmd.CommandText = "sp_borrarRegistro";
                    cmd.Parameters.AddWithValue("codigo", txtCodigo.Text);
                    fila = cmd.ExecuteNonQuery();
                    if (fila != 0)
                    {
                        MessageBox.Show("El registro ha sido eliminado correctamente" + cmd.Parameters["codigo"].Value.ToString());
                    }
                    break;
                default:
                    break;
            }
            cn.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

     
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || ((int)e.KeyChar) == 8);
        }
    
    }
}
