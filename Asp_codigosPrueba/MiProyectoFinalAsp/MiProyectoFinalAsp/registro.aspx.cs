using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiProyectoFinalAsp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 cls = new Class1();
            bool r;
            r = cls.guardardatos(TextBox1.Text, DropDownList1.Text);
            if (r=true)
            {
                Response.Write("<script language=javascript>alert('inserto bien');</script>");  

            }
            else
            {
                Response.Write("<script language= javascript>alert('inserto mal');<script>");
            }
        }
    }
}