using System;
using System.Collections.Generic;

namespace DL;

public partial class Tipo
{
    public byte IdTipo { get; set; }

    public string? Tipo1 { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
