using System;
using System.Collections.Generic;

namespace DL;

public partial class ProductoHistorial
{
    public int IdProductoHistorial { get; set; }

    public int? IdProductoPiso { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public int? Cantidad { get; set; }

    public virtual ProductoPiso? IdProductoPisoNavigation { get; set; }
}
