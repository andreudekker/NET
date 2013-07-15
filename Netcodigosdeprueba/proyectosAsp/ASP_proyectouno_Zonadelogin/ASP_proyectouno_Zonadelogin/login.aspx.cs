using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ASP_proyectouno_Zonadelogin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet1TableAdapters.usuarioTableAdapter obj = new DataSet1TableAdapters.usuarioTableAdapter();
                string nombreUsuario = obj.login(txtUsuario.Text, TxtClave.Text).ToString();
                if (!nombreUsuario.Equals(""))
                {
                    Session["Usuario"] = nombreUsuario;
                    Response.Redirect("default.aspx");
                }
            }
            catch (Exception)
            {

                lblMensaje.Text = "Usuario o contraseña no valido";
            }
        }

      
    }
}