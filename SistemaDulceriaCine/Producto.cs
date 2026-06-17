using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDulceriaCine
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }

        public Producto(int id, string nombre, double precio, int existencia)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Existencia = existencia;
        }
    }
}
