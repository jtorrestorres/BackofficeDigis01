using System;
using System.Collections.Generic;

namespace DL;

public partial class Piso
{
    public int IdPiso { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();

    public virtual ICollection<HistorialEquipoPiso> HistorialEquipoPisos { get; set; } = new List<HistorialEquipoPiso>();

    public virtual ICollection<ProductoPiso> ProductoPisos { get; set; } = new List<ProductoPiso>();
}
