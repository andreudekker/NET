using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaAsp2
{
    public partial class page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
         
            Button1.Text = "hola" + "como estas" + "adios";
            Button1.ForeColor = Color.Red;

        }
    }
}