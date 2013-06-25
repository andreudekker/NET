using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaASP_3
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListBox1.Items.Add("primero");
            ListBox1.Items.Add("Segundo");
            ListBox1.Items.Add("Tercero");
        }
    }
}