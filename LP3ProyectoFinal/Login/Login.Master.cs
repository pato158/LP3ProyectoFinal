using LP3ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LP3ProyectoFinal.Login
{
    public partial class Login : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["activo"] == null) { 
                List<Producto> productos = new List<Producto>();
                Producto productoClass = new Producto();
                productos = productoClass.iniciarProductos();
                Session["productos"] = (List<Producto>)productos;
                Session["activo"]=true;
            }
        }
    }
}