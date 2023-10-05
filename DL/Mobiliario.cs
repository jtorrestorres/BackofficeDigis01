using System;
using System.Collections.Generic;

namespace DL;

public partial class Mobiliario
{
    public byte IdMobiliario { get; set; }

    public int IdProductoPiso { get; set; }

    public int? Cantidad { get; set; }

    public virtual ProductoPiso IdProductoPisoNavigation { get; set; } = null!;
}
