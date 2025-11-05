using LP3ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LP3ProyectoFinal.Administracion
{
    public partial class ProductoNuevo1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            mensaje.Text = "";
            FileUpload1.Dispose();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string ruta = $"{Server.MapPath("../")}images";
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
                resultado = " <br />directorio creado";
            }


            bool apto = true;
            if (!FileUpload1.HasFile)
            {
                apto = false;
                resultado += " <br />Seleccione un archivo";
            }
            if (FileUpload1.PostedFile.ContentLength > 61440)
            {//3MB=> 3(mb) * 1024(KB) * 1024(B) = 3145728(B);  60Kb => 60(KB) * 1024(B) = 61440;
                resultado += " <br />archivo de mucho tamaño";
                apto = false;
            }
            var extension = Path.GetExtension(FileUpload1.PostedFile.FileName).ToLower();
            if (File.Exists($"{ruta}/{txtDescripcion.Text + extension}"))
            {
                resultado += $" <br />El archivo {txtDescripcion.Text} ya existe ";
                apto = false;

            }
            if (extension != ".jpg" && extension != ".jpeg" && extension != ".png")
            {
                resultado += " <br />Formato no válido ";
                apto = false;

            }
            decimal valor;
            if (decimal.TryParse(txtPrecio.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
            {
                valor = Math.Round(valor, 2);

            }
            else
            {
                resultado += "<br />El precio ingresado no corresponde";
                apto |= false;
            }

            if (apto)
            {
                try
                {
                    FileUpload1.SaveAs($"{ruta}/{txtDescripcion.Text}{extension}");
                    List<Producto> productos = new List<Producto>();
                    if (Session["productos"] != null)
                    {
                        productos = (List<Producto>)Session["productos"];
                    }
                    Producto nuevo = new Producto()
                    {
                        descripcion = txtDescripcion.Text,
                        precio = valor,
                        img = txtDescripcion.Text + extension
                    };
                    productos.Add( nuevo );
                    Session["productos"] = productos;
                    resultado = "Producto guardado con Exito";

                }
                catch (Exception ex)
                {
                    resultado = ex.Message;
                }
            }
            mensaje.Text = resultado;
        }
    }
}