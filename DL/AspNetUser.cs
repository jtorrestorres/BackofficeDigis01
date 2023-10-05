using System;
using System.Collections.Generic;

namespace DL;

public partial class AspNetUser
{
    public string Id { get; set; } = null!;

    public string? UserName { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? Email { get; set; }

    public string? NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; } = new List<AspNetUserClaim>();

    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; } = new List<AspNetUserLogin>();

    public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; } = new List<AspNetUserToken>();

    public virtual ICollection<Credencial> Credencials { get; set; } = new List<Credencial>();

    public virtual ICollection<HistorialHoja> HistorialHojas { get; set; } = new List<HistorialHoja>();

    public virtual ICollection<HistorialPaqueteHoja> HistorialPaqueteHojas { get; set; } = new List<HistorialPaqueteHoja>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<SolicitudDespensa> SolicitudDespensas { get; set; } = new List<SolicitudDespensa>();

    public virtual ICollection<SolicitudHojasDetalle> SolicitudHojasDetalles { get; set; } = new List<SolicitudHojasDetalle>();

    public virtual ICollection<SolicitudMedicamento> SolicitudMedicamentos { get; set; } = new List<SolicitudMedicamento>();

    public virtual ICollection<UsuarioMedicamento> UsuarioMedicamentos { get; set; } = new List<UsuarioMedicamento>();

    public virtual ICollection<AspNetRole> Roles { get; set; } = new List<AspNetRole>();
}
