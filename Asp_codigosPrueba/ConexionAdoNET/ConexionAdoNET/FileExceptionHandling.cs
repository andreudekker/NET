using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ConexionAdoNET
{
    public partial class FileExceptionHandling : Form
    {
        public FileExceptionHandling()
        {
            InitializeComponent();
        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            StreamWriter objSw = new StreamWriter(txtFileWritePath.Text, true);
            objSw.WriteLine(txtFileText.Text);
            objSw.Close();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(txtFileReadPath.Text);
                txtFileContent.Text = sr.ReadToEnd();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message + " " + "Please provide valid path and filename");
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message + " " + "Please provide valid Directory  name", "File Read Error");

            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();

                }
            }
        }
    }
}
  
    

