using System;
using System.Collections.Generic;

namespace DL;

public partial class Membretado
{
    public byte IdMembretado { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Hoja> Hojas { get; set; } = new List<Hoja>();
}
