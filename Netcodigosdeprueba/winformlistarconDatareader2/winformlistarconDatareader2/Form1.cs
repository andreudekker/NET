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

namespace winformlistarconDatareader2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(winformlistarconDatareader2.Properties.Settings.Default.CnNw);
        //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnNw"].ConnectionString);
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_listarEmpleados", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            SqlDataReader lector = cmd.ExecuteReader(CommandBehavior.SingleResult);
            BindingSource bs = new BindingSource();
            bs.DataSource = lector;

            Cboempleados.SelectedValueChanged -= Cboempleados_SelectedValueChanged;
            Cboempleados.DataSource = bs;
            Cboempleados.DisplayMember = "LastName";
            Cboempleados.ValueMember = "EmployeeID";
            Cboempleados.SelectedValueChanged += Cboempleados_SelectedValueChanged;
            cn.Close();
        }

        private void Cboempleados_SelectedValueChanged(object sender, EventArgs e)
        {
         
        }

        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cboempleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigoEmpleado = Convert.ToInt32(Cboempleados.SelectedValue);
            MessageBox.Show(codigoEmpleado.ToString());
        }
    }
}
