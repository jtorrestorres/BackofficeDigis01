using System;
using System.Collections.Generic;

namespace DL;

public partial class MetodoPago
{
    public int IdMetodoPago { get; set; }

    public string? Metodo { get; set; }

    public virtual ICollection<Reposicion> Reposicions { get; set; } = new List<Reposicion>();
}
