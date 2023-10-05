using System;
using System.Collections.Generic;

namespace DL;

public partial class Incidencia
{
    public int IdIncidencias { get; set; }

    public int IdEquipo { get; set; }

    public DateTime FechaIncidencia { get; set; }

    public string? Detalle { get; set; }

    public string Estatus { get; set; } = null!;

    public virtual Equipo IdEquipoNavigation { get; set; } = null!;
}
