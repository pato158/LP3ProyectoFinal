using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LP3ProyectoFinal.Login
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> Usuarios;
            if (Session["usuarios"] != null)
            {
                Usuarios = (List<string>)Session["usuarios"];
            }
            else
            {
                Usuarios = new List<string>();
            }
            if (Usuarios.Contains(txtUsuarioLogin.Text))
            {
                mensaje.Text = "Bienvenido";
                Session["usuarioActual"] = txtUsuarioLogin.Text;
                Response.Redirect("~/Tienda/IndexTienda.aspx");

            }
            else
            {
                mensaje.Text = "Usuario no registrado";
            }
           
        }
    }
}