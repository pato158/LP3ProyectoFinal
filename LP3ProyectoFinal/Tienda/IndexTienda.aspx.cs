using LP3ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LP3ProyectoFinal.Tienda
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Producto> productos = new List<Producto>();
           
            if (Session["productos"] != null)
            {
                productos = (List<Producto>)Session["productos"];
            }
            var carro = new List<string>();
            foreach (string nombre in Request.Cookies.AllKeys)
            {
                string valor = Request.Cookies[nombre]?.Value;
                carro.Add(valor);
            }
            foreach (Producto producto in productos)
            {
                Panel div = new Panel();
                div.CssClass = "card m-3";
                Literal titulo = new Literal();
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                string capitalizado = textInfo.ToTitleCase(producto.descripcion.ToLower());
                titulo.Text = $"<h3>{capitalizado}</h3>";

                Literal precio = new Literal();
                precio.Text = $"<h5>$ {producto.precio}</h5>";

                Image img = new Image();
                img.ImageUrl = $"~/images/{producto.img}";
                img.Width = Unit.Pixel(150);
                img.Height = Unit.Pixel(150);
                img.AlternateText = producto.descripcion;
                Button comprar = new Button();
                if (carro.Contains(producto.descripcion))
                {
                    comprar.Text = "Eliminar";
                    comprar.OnClientClick = $"Eliminar('{producto.descripcion}')";
                    comprar.CssClass = "btn btn-danger";
                }
                else
                {
                    comprar.Text = "Comprar";
                    comprar.OnClientClick = $"Comprar('{producto.descripcion}')";
                    comprar.CssClass = "btn btn-success";
                }
                div.Controls.Add(titulo);
                div.Controls.Add(img);
                div.Controls.Add(precio);
                div.Controls.Add(comprar);

                phProductos.Controls.Add(div);

            }
        }      

    }
}