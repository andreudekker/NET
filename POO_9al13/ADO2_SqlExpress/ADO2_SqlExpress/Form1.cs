using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//usando serviceBaseDatabase
namespace ADO2_SqlExpress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conexion con la bd
            SqlConnection miconexion = new SqlConnection("..\\sqlexpress;attachDBfilename=|dataDirectory|\\DataBase.mdf; Integrated Security=True;User Instance = True");
            miconexion.Open();

            // especificar el request
            SqlCommand MiComando = miconexion.CreateCommand();
            MiComando.CommandText = "Select * from Cliente";
            MiComando.CommandType = System.Data.CommandType.Text;
            SqlDataReader miDataReader;
            miDataReader = MiComando.ExecuteReader();

            //Usando la data
            while (miDataReader.Read())
            {
                listBox1.Items.Add(miDataReader[1]+ "-->" +miDataReader[2]);
            }
            miconexion.Close();
        }
    }
}
