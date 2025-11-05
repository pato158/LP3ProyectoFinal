using LP3ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LP3ProyectoFinal.Administracion
{
    public partial class IndexAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                divEditar.Visible = false;
            }
            else
            {
                divEditar.Visible = true;
            }
            List<Producto> productos = new List<Producto>();
            if (Session["productos"] != null)
            {
                productos = (List<Producto>)Session["productos"];
            }
            GridView1.DataSource = productos;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "editar")
            {
                divEditar.Visible = true;
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                txtDescripcion.Text = row.Cells[1].Text;
                txtDescripcioOriginal.Text = row.Cells[1].Text;
                txtPrecio.Text = row.Cells[2].Text.Replace(",",".");


            }
            if (e.CommandName == "eliminar")
            {
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            FileUpload1.Dispose();
            divEditar.Visible = false;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombre = txtDescripcioOriginal.Text;
            string nombreNuevo = txtDescripcion.Text;
           
            List<Producto> productos = new List<Producto>();
            if (Session["productos"] != null)
            {
                productos = Session["productos"] as List<Producto>;
            }
            Producto editar = new Producto();
            bool apto = true;
            decimal valor;
            string resultado = string.Empty;
            if (decimal.TryParse(txtPrecio.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
            {
                valor = Math.Round(valor, 2);

            }
            else
            {
                resultado += "<br />El precio ingresado no corresponde";
                mensaje.Text = resultado;
                return;
               
            }


            foreach (Producto producto in productos)
            {
                if (producto.descripcion == nombre)
                {
                    editar = producto;
                    editar.descripcion = nombreNuevo;
                    editar.precio = valor;
                    break;
                }
            }
            string ruta = $"{Server.MapPath("../")}images";
            resultado = "Cambios guardado con exito";
            if (FileUpload1.HasFile)
            {
                if (FileUpload1.PostedFile.ContentLength > 61440)
                {//3MB=> 3(mb) * 1024(KB) * 1024(B) = 3145728(B);  60Kb => 60(KB) * 1024(B) = 61440;
                    resultado += " <br />archivo de mucho tamaño";
                    apto = false;
                }
                var extension = Path.GetExtension(FileUpload1.PostedFile.FileName).ToLower();
                if (File.Exists($"{ruta}/{editar.img}"))
                {

                    File.Delete($"{ruta}/{editar.img}");

                }
                if (extension != ".jpg" && extension != ".jpeg" && extension != ".png")
                {
                    resultado += " <br />Formato no válido ";
                    apto = false;

                }
                if (apto)
                {
                    editar.img = nombreNuevo + extension;
                    try
                    {
                        FileUpload1.SaveAs($"{ruta}/{editar.img}");
                    }
                    catch (Exception ex)
                    {
                        resultado = ex.Message;
                    }
                }
            }

            Session["productos"] = productos;
            GridView1.DataBind();
            mensaje.Text = resultado;
            //divEditar.Visible = false;
        }
    }
}