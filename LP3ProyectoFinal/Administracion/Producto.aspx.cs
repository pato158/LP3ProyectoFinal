using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LP3ProyectoFinal.Administracion
{
    public partial class Producto : System.Web.UI.Page
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
            if (FileUpload1.PostedFile.ContentLength > 61440) {//3MB=> 3(mb) * 1024(KB) * 1024(B) = 3145728(B);  60Kb => 60(KB) * 1024(B) = 61440;
                resultado += " <br />archivo de mucho tamaño";
            }
            var extension = Path.GetExtension(FileUpload1.PostedFile.FileName).ToLower();
            if (File.Exists($"{ruta}/{txtDescripcion.Text+extension}"))
            {
                resultado += $" <br />El archivo {txtDescripcion.Text} ya existe ";
               
            } 
            if (extension != ".jpg" && extension != ".jpeg" && extension != ".png") 
            { 
                resultado += " <br />Formato no válido ";

            }
            decimal valor;
            if (decimal.TryParse(txtPrecio.Text, out valor))
            {
                valor = Math.Round(valor, 2);
            }
            else
            {
                resultado += "<br />El precio ingresado no corresponde";
            }


            try
            {


            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            mensaje.Text = resultado;

        }
    }
}