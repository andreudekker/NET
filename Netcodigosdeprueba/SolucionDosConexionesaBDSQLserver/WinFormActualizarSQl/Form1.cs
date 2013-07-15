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


namespace WinFormActualizarSQl
{
    public partial class FrmActualizacionRegistros : Form
    {
        public FrmActualizacionRegistros()
        {
            InitializeComponent();
        }

        //SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["QlActualizacion"].ConnectionString);
        SqlConnection cnn = new SqlConnection(WinFormActualizarSQl.Properties.Settings.Default.Newcnn); //para llamar desde los settings
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter();

        }
    }
}
