using System;
using System.Collections.Generic;

namespace DL;

public partial class SolicitudDespensa
{
    public int IdPedido { get; set; }

    public DateTime? Fecha { get; set; }

    public string? IdUsuarioSolicito { get; set; }

    public int? IdStatus { get; set; }

    public virtual StatusPedido? IdStatusNavigation { get; set; }

    public virtual AspNetUser? IdUsuarioSolicitoNavigation { get; set; }
}
