using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace AdonetSqlserverCE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Contacto con la BD
            SqlCeConnection miconn = new SqlCeConnection(" Data Source =Database1.sdf ");
            miconn.Open();
            //Paso2 request
            SqlCeCommand micomando = miconn.CreateCommand();
            micomando.CommandText = "Clientes";
            micomando.CommandType = System.Data.CommandType.TableDirect; //en esta linea tabledirect o storedprocedure
            SqlCeDataReader midatareader;
            midatareader = micomando.ExecuteReader();
            //Paso3  usando la data
            while (midatareader.Read())
            {
                listBox1.Items.Add(midatareader[1]+ " " + midatareader[2] + " ==> "+midatareader[3]); // datos de la bd 
            }
            miconn.Close();


        }
    }
}
