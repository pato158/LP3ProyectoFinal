using LP3ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LP3ProyectoFinal.Administracion
{
    public partial class Administracion : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario user = (Usuario)Session["usuarioActual"];
            if (user != null)
            {
                labelNombre.Text = user.nombre;
                labelUsuarioActual.Text = user.user;
            }
            else {
                Response.Redirect("~/Login/Opening.aspx");
            }
        }
        protected void cerrarSesion_Click(object sender, EventArgs e)
        {
            Session["usuarioActual"] = null;
            Response.Redirect("~/Login/Opening.aspx");
        }
    }
}