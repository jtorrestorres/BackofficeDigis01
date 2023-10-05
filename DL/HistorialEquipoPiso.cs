using System;
using System.Collections.Generic;

namespace DL;

public partial class HistorialEquipoPiso
{
    public int IdHistorialEquipoPiso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime? FechaMovimiento { get; set; }

    public string? Detalle { get; set; }

    public int IdEquipo { get; set; }

    public int IdPiso { get; set; }

    public virtual Equipo IdEquipoNavigation { get; set; } = null!;

    public virtual Piso IdPisoNavigation { get; set; } = null!;
}
