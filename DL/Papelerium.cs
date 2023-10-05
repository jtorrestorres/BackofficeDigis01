using System;
using System.Collections.Generic;

namespace DL;

public partial class Papelerium
{
    public int IdPapeleria { get; set; }

    public Guid? IdProducto { get; set; }

    public byte? IdProveedor { get; set; }

    public string Nombre { get; set; } = null!;

    public int Cantidad { get; set; }

    public virtual ICollection<HistorialPaqueteHoja> HistorialPaqueteHojas { get; set; } = new List<HistorialPaqueteHoja>();

    public virtual ICollection<Hoja> Hojas { get; set; } = new List<Hoja>();

    public virtual Producto? IdProductoNavigation { get; set; }

    public virtual Proveedor? IdProveedorNavigation { get; set; }
}
