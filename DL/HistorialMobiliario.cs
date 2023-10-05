using System;
using System.Collections.Generic;

namespace DL;

public partial class HistorialMobiliario
{
    public byte IdHistorialMobiliario { get; set; }

    public int IdProductoPiso { get; set; }

    public Guid IdProducto { get; set; }

    public virtual Producto IdProductoNavigation { get; set; } = null!;

    public virtual ProductoPiso IdProductoPisoNavigation { get; set; } = null!;
}
