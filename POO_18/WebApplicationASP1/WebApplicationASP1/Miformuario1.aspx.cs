using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace WebApplicationASP1
{
    public partial class Miformuario1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Page.IsPostBack)
            {
                Label1.Text = "Prueba";
            }
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            TextBox1.Text = "andres";
        }
    }
}