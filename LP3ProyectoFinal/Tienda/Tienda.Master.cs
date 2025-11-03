using LP3ProyectoFinal.Models;
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
            Usuario usuarioActual = new Usuario();
            if (Session["usuarioActual"] != null)
            {
                usuarioActual = (Usuario)Session["usuarioActual"];
                labelUsuarioActual.Text = usuarioActual.user;
                labelNombre.Text = usuarioActual.nombre;
            }
            else 
            { 
                Response.Redirect("~/Login/Registrar.aspx");
                return;
            }
            var contador = 0;

            foreach (string nombre in Request.Cookies.AllKeys)
            {
                if (!nombre.StartsWith(".") && !nombre.StartsWith("ASP") && !nombre.StartsWith("__") && !nombre.StartsWith("LP3"))
                {
                    contador++;

                }
            }           
            cantProductos.Text = contador.ToString();
            
        }

        protected void cerrarSesion_Click(object sender, EventArgs e)
        {
            Session["usuarioActual"] = null;
            Response.Redirect("~/Login/Login.aspx");
        }
    }
}