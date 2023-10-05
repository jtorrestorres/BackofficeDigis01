using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Producto
    {
        public Guid IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string FechaRegistro { get; set; }
        public byte[] Imagen { get; set; }


        //Propiedades de navegacion
        public User User { get; set; }
        public Tipo Tipo { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}
