using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_datagrid_BD_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void database1DataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet1.Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.Update(this.database1DataSet1.Table);  //actualizar en memoria
            this.tableTableAdapter.Fill(this.database1DataSet1.Table);
          
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            //look in  properties row validated inside datagrid

            this.tableTableAdapter.Update(this.database1DataSet1.Table);            //without buttom
            this.tableTableAdapter.Fill(this.database1DataSet1.Table);
           
        }
    
    
    }
}
