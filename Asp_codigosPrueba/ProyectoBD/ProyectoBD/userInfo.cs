using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoBD
{
    public partial class userInfo : Form
    {
        public userInfo()
        {
            InitializeComponent();
        }

        private void btnRemoveCountry_Click(object sender, EventArgs e)
        {
            lstCountry.Items.Remove(lstCountry.SelectedItem);
        }

        private void btnRemoveState_Click(object sender, EventArgs e)
        {
            CboState.Items.Remove(CboState.SelectedItem);
        }

        private void btnShowdetails_Click(object sender, EventArgs e)
        {
            if (chkEmail.Checked == true || chkPostaMail.Checked == true && rdbMale.Checked == true)
            {
                MessageBox.Show("Hola Sr, sera contactado via codigo postal o email",
            "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
                if (chkEmail.Checked == true || chkPostaMail.Checked == true && rdbFemale.Checked == true)
                {
                    MessageBox.Show("Hola srta, sera contactada via codigo postal o email",
                    "Information", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
                }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstCountry.Items.Add(TxtCountry.Text);
            TxtCountry.Clear();
            CboState.Items.Add(txtState.Text);
            txtState.Clear();
        }
    }
}
