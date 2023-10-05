using System;
using System.Collections.Generic;

namespace DL;

public partial class SolicitudMedicamento
{
    public int IdPedido { get; set; }

    public DateTime? Fecha { get; set; }

    public string? IdUsuarioSolicito { get; set; }

    public int? IdStatus { get; set; }

    public virtual StatusPedido? IdStatusNavigation { get; set; }

    public virtual AspNetUser? IdUsuarioSolicitoNavigation { get; set; }

    public virtual ICollection<SolicitudDespensaDetalle> SolicitudDespensaDetalles { get; set; } = new List<SolicitudDespensaDetalle>();

    public virtual ICollection<SolicitudMedicamentoDetalle> SolicitudMedicamentoDetalles { get; set; } = new List<SolicitudMedicamentoDetalle>();
}
