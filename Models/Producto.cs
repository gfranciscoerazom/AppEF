using System.ComponentModel.DataAnnotations;

namespace AppEF.Models
{
    public class Producto
    {
        // [Key]
        public int ProductoId
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public string Descripcion
        {
            get;
            set;
        }

        public double Precio
        {
            get;
            set;
        }

        public Producto(int productoId, string nombre, string descripcion, double precio)
        {
            ProductoId = productoId;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}
