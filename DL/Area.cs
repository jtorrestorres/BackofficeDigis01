using System;
using System.Collections.Generic;

namespace DL;

public partial class Area
{
    public byte IdArea { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
