using LP3ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LP3ProyectoFinal.Login
{
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Usuario> Usuarios;
            if (Session["usuarios"] != null)
            {
                Usuarios = (List<Usuario>)Session["usuarios"];
            }
            else
            {
                Usuarios = new List<Usuario>();
            }
            bool existe = false;
            foreach (Usuario usuario in Usuarios)
            {
                if (usuario.user==txtUser.Text)
                {
                    mensaje.Text = "Usuario ya registrado";
                    existe = true;
                    break;
                }
            }
            if(!existe)
            {
                Usuario nuevoUsuario = new Usuario()
                {
                    user = txtUser.Text,
                    nombre = txtnombre.Text,
                    idRol = Convert.ToInt32(idRol.SelectedValue)
                };
                Usuarios.Add(nuevoUsuario);
                Session["usuarios"] = Usuarios;
                mensaje.Text = "Usuario registrado con Exito";
                txtUser.Text = "";
            }

        }
    }
}