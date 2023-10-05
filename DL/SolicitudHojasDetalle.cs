using System;
using System.Collections.Generic;

namespace DL;

public partial class SolicitudHojasDetalle
{
    public int IdSolicitudHojas { get; set; }

    public string? IdUsuario { get; set; }

    public int? IdStatus { get; set; }

    public int Cantidad { get; set; }

    public virtual StatusPedido? IdStatusNavigation { get; set; }

    public virtual AspNetUser? IdUsuarioNavigation { get; set; }

    public virtual ICollection<SolicitudHoja> SolicitudHojas { get; set; } = new List<SolicitudHoja>();
}
