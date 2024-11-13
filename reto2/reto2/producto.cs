using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto2
{
    internal class Producto
    {
        public string NombreProducto { get; set; }
        public string Codigo { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        
        public Producto(string nombreProducto, string codigo, decimal precio, int cantidad)
        {
            NombreProducto = nombreProducto;
            Codigo = codigo;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}
