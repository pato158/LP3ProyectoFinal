using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LP3ProyectoFinal.Models
{
    public class Producto
    {
       
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public string img { get; set; }

        public List<Producto> iniciarProductos() {
            var random = new Random();
            var lista = new List<Producto>();
            var productos = new List<string>() {"grampa", "krusty", "itchy", "scratchy", "bob","skinner", "willie",
                "otto","milhouse", "nelson","ralph","ned","jeff", "barney", "carl", "lenny", "moes"};
            foreach (var prod in productos)
            {
                var precio = random.Next(10, 15);
                Producto producto = new Producto()
                {
                    descripcion = prod,
                    img = prod + ".jpeg",
                    precio = precio*1000,
                };
                lista.Add(producto);
            }

            return lista;
        }
    }
}