using System;
using System.Collections.Generic;

namespace DL;

public partial class Equipo
{
    public int IdEquipo { get; set; }

    public string CuentaUsuario { get; set; } = null!;

    public DateTime FechaIngreso { get; set; }

    public bool Disponible { get; set; }

    public bool EnOficina { get; set; }

    public string NumeroSerie { get; set; } = null!;

    public string? Comentario { get; set; }

    public int IdDispositivo { get; set; }

    public int IdTipoEquipo { get; set; }

    public byte IdArea { get; set; }

    public int IdUsuarioActual { get; set; }

    public int IdPiso { get; set; }

    public virtual ICollection<HistorialEquipoPiso> HistorialEquipoPisos { get; set; } = new List<HistorialEquipoPiso>();

    public virtual ICollection<HistorialEquipo> HistorialEquipos { get; set; } = new List<HistorialEquipo>();

    public virtual Area IdAreaNavigation { get; set; } = null!;

    public virtual Dispositivo IdDispositivoNavigation { get; set; } = null!;

    public virtual Piso IdPisoNavigation { get; set; } = null!;

    public virtual TipoEquipo IdTipoEquipoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioActualNavigation { get; set; } = null!;

    public virtual ICollection<Incidencia> Incidencia { get; set; } = new List<Incidencia>();
}
