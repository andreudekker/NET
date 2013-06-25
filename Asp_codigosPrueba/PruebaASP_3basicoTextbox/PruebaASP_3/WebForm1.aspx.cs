using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaASP_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblInfo.Text += "Page.Load event handled.<br />";
            //if (Page.IsPostBack)
            //{
            //    // This text never appears because the HTML is already
            //    // rendered for the page at this point.
            //    lblInfo.Text += "Page.Unload event handled.<br />";
                
            //}

            lblInfo.Text += "Button2.Click event handled.<br />";
        }
    }
}