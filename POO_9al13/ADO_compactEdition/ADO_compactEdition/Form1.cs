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

namespace ADO_compactEdition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conectar la BD
            SqlCeConnection miconexion = new SqlCeConnection("Data Source= Database1.sdf " );
            miconexion.Open();

            //Request
            SqlCeCommand miComando = miconexion.CreateCommand();
            miComando.CommandText = "Clientes"; //igual a la tabla que se creo en la BD
            miComando.CommandText = System.Data.CommandType.TableDirect;
            SqlCeDataReader miDataReader;
            miDataReader = miComando.ExecuteReader();

            //Usando la Data
            while (miDataReader.Read())
            {
                listBox1.Items.Add(miDataReader[1]+ " " + miDataReader[2]);
            }
            miconexion.Close();
            //

  

        }
    }
}
