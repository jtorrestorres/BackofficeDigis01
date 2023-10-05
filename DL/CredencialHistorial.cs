using System;
using System.Collections.Generic;

namespace DL;

public partial class CredencialHistorial
{
    public int IdHistorial { get; set; }

    public int? IdCredencial { get; set; }

    public int? IdUsuarioAsignado { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    public virtual Credencial? IdCredencialNavigation { get; set; }

    public virtual Usuario? IdUsuarioAsignadoNavigation { get; set; }
}
