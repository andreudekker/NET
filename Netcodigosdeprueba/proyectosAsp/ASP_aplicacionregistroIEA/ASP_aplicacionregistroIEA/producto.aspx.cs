using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_aplicacionregistroIEA
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        tienda tienda = new tienda();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["accion"] == null)
            {
                PanelModificar.Visible = false;
                PanelMostrar.Visible = false;
                PanelRegistro.Visible = true;
              
            }
            else
            {
                if (Request.QueryString["accion"]=="MostrarTodo")
                {
                    PanelModificar.Visible = false;
                    PanelMostrar.Visible = true;
                    PanelRegistro.Visible = false;
                    lblEstado.Visible = false;
                    GridView1.DataSource = tienda.MostrarRegistros("productos");
                    GridView1.DataBind();
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string tabla = "productos";
            string campos = "nombreproducto,descripcionproducto,codigoproveedor,preciounidad,unidadenexistencia";
            string valores=" ' "+txtnombreproducto.Text+" ', ' "+txtdescripcion.Text+ " ', ' "+txtcodigoproveedor.Text+" ',+'"+txtprecioporunidad+" ', ' "+txtunidadesenexistencia+" ' ";
            if (tienda.Registrar(tabla, campos, valores))
            {
                lblEstado.Text = "Se ha registrado el producto";
            }
            else 
            {
               
            }
        }
    }
}