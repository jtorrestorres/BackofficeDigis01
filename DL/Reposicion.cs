using System;
using System.Collections.Generic;

namespace DL;

public partial class Reposicion
{
    public int IdReposicion { get; set; }

    public int? IdCredencial { get; set; }

    public int? IdUsuarioSolicito { get; set; }

    public string? Motivo { get; set; }

    public decimal? Costo { get; set; }

    public int? IdMetodoPago { get; set; }

    public string? StatusReposicion { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public byte[]? ComprobanteDePago { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public virtual Credencial? IdCredencialNavigation { get; set; }

    public virtual MetodoPago? IdMetodoPagoNavigation { get; set; }

    public virtual Usuario? IdUsuarioSolicitoNavigation { get; set; }
}
