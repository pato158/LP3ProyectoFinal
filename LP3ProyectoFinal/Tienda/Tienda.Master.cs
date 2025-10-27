using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LP3ProyectoFinal.Carrito
{
    public partial class Carrito : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuarioActual = String.Empty;
            if (Session["usuarioActual"] != null) { 
                usuarioActual = Session["usuarioActual"].ToString();
            }
            if (usuarioActual == String.Empty)
            {
                Response.Redirect("~/Login/Registrar.aspx");
            }
            else {
                labelUsuarioActual.Text = usuarioActual;
            }
            var contador = -1;
            if (Request.Cookies.Count > 1)
            {
                foreach (string nombre in Request.Cookies.AllKeys)
                {
                    contador++;
                }
            }
            if (contador >0)
            {
                cantProductos.Text = contador.ToString();
            }
            else {
                cantProductos.Text = "0";
            }
        }
    }
}