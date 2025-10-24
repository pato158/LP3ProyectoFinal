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
            List<string> Usuarios ;
            if (Session["usuarios"] != null)
            {
                Usuarios = (List<string>)Session["usuarios"];
            }
            else { 
                Usuarios = new List<string>();
            }
            if (Usuarios.Contains(txtUsuario.Text))
            {
                mensaje.Text = "Usuario ya registrado";
                return;
            }
            else
            {
                Usuarios.Add(txtUsuario.Text);
                Session["usuarios"] = Usuarios;
                mensaje.Text = "Usuario registrado con Exito";
                txtUsuario.Text = "";
            }
           
        }
    }
}