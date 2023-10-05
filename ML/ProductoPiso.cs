using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class ProductoPiso
    {
        public int IdProductoPiso { get; set; }
        public Producto Producto { get; set; }
        public Piso Piso { get; set; }
    }
}
