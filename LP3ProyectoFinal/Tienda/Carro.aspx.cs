using LP3ProyectoFinal.Carrito;
using LP3ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LP3ProyectoFinal.Tienda
{
    public partial class Carro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var tiene = cargarGrilla();
            if (!tiene) {
                Button1.Visible = false;
                Button2.Visible = false;
            }
        }
        public bool cargarGrilla()
        {
            bool tiene = false;
            decimal subTotal = 0;
            var productos = new List<Producto>();
            var misProductos = new List<Producto>();
            if (Session["productos"] != null)
            {
                productos = (List<Producto>)Session["productos"];
            }
            foreach (string nombre in Request.Cookies.AllKeys)
            {
                foreach (Producto producto in productos)
                {
                    if (producto.descripcion == nombre)
                    {
                        subTotal += producto.precio;

                        misProductos.Add(producto);
                    }
                }
            }
            List<ProductoDTO> totales = new List<ProductoDTO>();
            if (misProductos.Count() > 0)
            {
                tiene = true;
                var total = new ProductoDTO()
                {
                    Producto = "Total",
                    Precio = subTotal,
                    img = misProductos.Count().ToString()
                };
                totales.Add(total);
            }
           

            GridView1.DataSource = misProductos;
            GridView1.DataBind();
            GridView2.DataSource = totales;
            //GridView2.ShowHeader = false;
            GridView2.DataBind();
            return tiene;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            mensaje.Text = "¡¡VUELVA PRONTOS!!";
            System.Threading.Thread.Sleep(2000);
            
            System.Threading.Thread.Sleep(2000);
            foreach (string nombre in Request.Cookies.AllKeys)
            {
                if (!nombre.StartsWith(".") && !nombre.StartsWith("ASP") && !nombre.StartsWith("__") && !nombre.StartsWith("LP3"))
                {
                    Response.Cookies[nombre].Expires = DateTime.Now.AddDays(-1);

                }
            }

            Response.Redirect("~/Tienda/Comprado.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            mensaje.Text = "Gracias por su compra, ¡¡VUELVA PRONTOS!!";
           

            System.Threading.Thread.Sleep(2000);
            foreach (string nombre in Request.Cookies.AllKeys)
            {
                if (!nombre.StartsWith(".") && !nombre.StartsWith("ASP") && !nombre.StartsWith("__") && !nombre.StartsWith("LP3"))
                {
                    Response.Cookies[nombre].Expires = DateTime.Now.AddDays(-1);

                }
            }

            Response.Redirect("~/Tienda/Carro.aspx");
        }
    }
}