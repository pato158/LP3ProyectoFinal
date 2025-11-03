using LP3ProyectoFinal.Models;
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
            Usuario userRegist = new Usuario();
            mensaje.Text = "";
            List<Usuario> Usuarios;
            if (Session["usuarios"] != null)
            {
                Usuarios = (List<Usuario>)Session["usuarios"];
            }
            else
            {
                Usuarios = new List<Usuario>();
            }
            bool registrado = false;
            foreach (Usuario usuario in Usuarios)
            {
                if (usuario.user == txtUsuarioLogin.Text)
                {
                    mensaje.Text = "Bienvenido";
                    Session["usuarioActual"] = usuario;
                    userRegist = usuario;
                    registrado = true;
                    break;
                }

            }
          
            System.Threading.Thread.Sleep(2000);
            if (registrado)
            {
                if (userRegist.idRol == 1)
                {
                    Response.Redirect("~/Tienda/IndexTienda.aspx");
                    return;
                }
                if (userRegist.idRol == 2)
                {
                    Response.Redirect("~/Administracion/IndexAdmin.aspx");
                    return;
                }
            }
            else
            {
                mensaje.Text = "Usuario no registrado";
            }

        }
    }
}