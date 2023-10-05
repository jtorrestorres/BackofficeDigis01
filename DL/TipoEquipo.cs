using System;
using System.Collections.Generic;

namespace DL;

public partial class TipoEquipo
{
    public int IdTipoEquipo { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();
}
