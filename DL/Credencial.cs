using System;
using System.Collections.Generic;

namespace DL;

public partial class Credencial
{
    public int IdCredencial { get; set; }

    public int? NumeroCredencial { get; set; }

    public string? Tipo { get; set; }

    public string? IdUsuarioQueAsigno { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    public bool? Disponibilidad { get; set; }

    public int? IdStatus { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public virtual ICollection<CredencialHistorial> CredencialHistorials { get; set; } = new List<CredencialHistorial>();

    public virtual StatusCrendencial? IdStatusNavigation { get; set; }

    public virtual AspNetUser? IdUsuarioQueAsignoNavigation { get; set; }

    public virtual ICollection<Reposicion> Reposicions { get; set; } = new List<Reposicion>();
}
