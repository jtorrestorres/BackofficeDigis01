using System;
using System.Collections.Generic;

namespace DL;

public partial class HistorialEquipo
{
    public int IdHistorialEquipo { get; set; }

    public int IdUsuario { get; set; }

    public int IdEquipo { get; set; }

    public DateTime FechaAsignacion { get; set; }

    public DateTime FechaRetiro { get; set; }

    public string? Detalle { get; set; }

    public virtual Equipo IdEquipoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
