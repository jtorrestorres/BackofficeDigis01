using System;
using System.Collections.Generic;

namespace DL;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Nombre { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public byte? IdArea { get; set; }

    public virtual ICollection<CredencialHistorial> CredencialHistorials { get; set; } = new List<CredencialHistorial>();

    public virtual ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();

    public virtual ICollection<HistorialEquipo> HistorialEquipos { get; set; } = new List<HistorialEquipo>();

    public virtual Area? IdAreaNavigation { get; set; }

    public virtual ICollection<Reposicion> Reposicions { get; set; } = new List<Reposicion>();

    public virtual ICollection<UsuarioGeneracion> UsuarioGeneracions { get; set; } = new List<UsuarioGeneracion>();

    public virtual ICollection<UsuarioMedicamento> UsuarioMedicamentos { get; set; } = new List<UsuarioMedicamento>();
}
