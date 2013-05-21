using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StronglyType_Ado2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadadosettings();

        }
        private void loadadosettings()
        {
            Database1DataSetTableAdapters.ClientesTableAdapter clientesadapter =new  Database1DataSetTableAdapters.ClientesTableAdapter();
            Database1DataSet clienteds = new Database1DataSet();
            clientesadapter.Fill(clienteds.Clientes);

            foreach (Database1DataSet.ClientesRow cliente in clienteds.Clientes.Rows)
            {
                listBox1.Items.Add(cliente.Nombre+" "+cliente.Apellido+" "+cliente.Pais+" ");
            }
            listBox1.Items.Add("Antes");
            Database1DataSet.ClientesRow clientenuevo = clienteds.Clientes.NewClientesRow();
            clientenuevo.Nombre = "Ronaldo";
            clientenuevo.Apellido = "Gaucho";
            clientenuevo.Pais = "Brasil";
           
            clienteds.Clientes[0].Nombre = "andres";        //cambiar el dataset del primer record
            clienteds.Clientes[1].Delete();                          //Delete un row completo.
           
            clienteds.Clientes.AddClientesRow(clientenuevo);
            clientesadapter.Update(clienteds);
            listBox1.Items.Add("Despues");
            foreach (Database1DataSet.ClientesRow cliente in clienteds.Clientes.Rows)
            {
                listBox1.Items.Add(cliente.Nombre + "" + cliente.Apellido + "" + cliente.Pais + "");
            }
    
        
        }
        
    }
}
