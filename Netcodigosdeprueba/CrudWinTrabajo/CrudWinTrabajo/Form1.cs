using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CrudWinTrabajo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(CrudWinTrabajo.Properties.Settings.Default.Nwcn);
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        public void cargarGrid()
        {
            DataTable tblPersonas = new DataTable();
            SqlCommand consultapersona = new SqlCommand("Select * from personas", cn);
            SqlDataAdapter dap = new SqlDataAdapter(consultapersona);
            dap.Fill(tblPersonas);
            dgvCrud.DataSource = tblPersonas;

   
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           SqlCommand cmd= new SqlCommand("INSERT INTO personas VALUES(@nombre,@apellido,@edad)",cn);
           cn.Open();
            cmd.Parameters.Add("nombre", SqlDbType.VarChar, 50).Value = txtNombre.Text;
           cmd.Parameters.Add("apellido", SqlDbType.VarChar, 50).Value = txtApellido.Text;
           cmd.Parameters.Add("edad", SqlDbType.Int, 3).Value = txtEdad.Text;
            cmd.ExecuteNonQuery();
         
            cargarGrid();
            cn.Close();
       
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE personas SET nombre=@Nombre,apellido=@Apellido, edad=@Edad  WHERE nombre=@Nombre",cn);
            
                                                                        //update Products set ProductName=@nombre,UnitPrice=@precio,UnitsInStock=@stock where ProductID=@codigo
            cn.Open();
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = txtNombre.Text;
            cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = txtApellido.Text;
            cmd.Parameters.Add("@Edad", SqlDbType.Int, 3).Value = txtEdad.Text;

            cmd.ExecuteNonQuery();
            cargarGrid();
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM personas WHERE nombre=@nombre", cn);
            cn.Open();
            cmd.Parameters.Add("Nombre", SqlDbType.VarChar, 50).Value = txtNombre.Text;
            cmd.ExecuteNonQuery();
            cargarGrid();
            cn.Close();
        }
    }
}
