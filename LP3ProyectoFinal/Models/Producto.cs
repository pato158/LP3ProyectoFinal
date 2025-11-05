using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Web;

namespace LP3ProyectoFinal.Models
{
    public class Producto
    {

        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public string img { get; set; }

        public List<Producto> iniciarProductos()
        {
            var random = new Random();
            var lista = new List<Producto>();
            var productos = new List<string>() {"grampa", "krusty", "itchy", "scratchy", "bob","skinner", "willie",
                "otto","milhouse", "nelson","ralph","ned","jeff", "barney", "carl", "lenny", "moes"};
            foreach (var prod in productos)
            {
                int precioEntero = random.Next(10, 15) * 1000;
                string preciostring = precioEntero.ToString();
               preciostring = preciostring+".00";

                // decimal valor = Math.Round((decimal)precioEntero, 2);
                decimal valor;
                if (decimal.TryParse(preciostring, NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
                {
                    valor = Math.Round(valor, 2);

                }

                Producto producto = new Producto()
                {
                    descripcion = prod,
                    img = prod + ".jpeg",
                    precio = valor
                };
                lista.Add(producto);
            }

            return lista;
        }
    }
}