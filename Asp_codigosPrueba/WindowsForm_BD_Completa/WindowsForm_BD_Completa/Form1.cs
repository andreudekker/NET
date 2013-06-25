using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Domain;  //referencia
using Session;  //referencia


namespace WindowsForm_BD_Completa
{
    public partial class Form1 : Form
    {
        Broker b = new Broker();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.FirstName = txtFirstName.Text;
            p.LastName = txtLastName.Text;

            b.Insert(p);
            
        }

        private void btnFillComboBox_Click(object sender, EventArgs e)
        {
         
            cmbPersons.DataSource = b.fillComboBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Person oldPerson = new Person();
            Person newPerson = new Person();
            oldPerson = cmbPersons.SelectedItem as Person;
            newPerson.FirstName = txtNewFirstName.Text;
            newPerson.LastName = TxtNewLastName.Text;
            b.update(oldPerson,newPerson);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p = cmbPersons.SelectedItem as Person;
            b.Delete(p);
        }
    }
}
