using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//agregar

namespace AppDisenoAdo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Llenandolistbox(textBox1.Text);
            dataGridView1.DataSource = EjecutarQuery(textBox1.Text);
        }

        #region Ejecutando el query
        public DataTable EjecutarQuery(string miQuery)
        {
            try
            {
                Conn adoconn = new Conn();
                SqlConnection miconection = new SqlConnection(adoconn.getconnectionstring("AdventureWorks2012"));
                //tabla en memoria para guardar el resultado
                DataTable midatable = new DataTable();
                SqlCommand micomando = new SqlCommand(miQuery , miconection);

                SqlDataAdapter miadaptador = new SqlDataAdapter();
                miadaptador.SelectCommand = micomando;
                miadaptador.Fill(midatable);
                return midatable;

            }
            catch (Exception ex)
            {
                
                throw new Exception("Error ejecutando el query"+ex.Message);
            }
        }
        #endregion

        # region Llenando la lista
        public void Llenandolistbox (string miQuery)
        {
            Conn adoconn = new Conn();
            SqlConnection miconection = new SqlConnection(adoconn.getconnectionstring("AdventureWorks2012"));
            SqlCommand micomando = new SqlCommand( miQuery , miconection);
            miconection.Open();
            SqlDataReader reader = micomando.ExecuteReader();

            while (reader.Read())
            {
                string resultado = reader["Sales.Store"].ToString(); ;
                listBox1.Items.Add(resultado);
            }
        }
        #endregion
    }
}
