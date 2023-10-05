using System;
using System.Collections.Generic;

namespace DL;

public partial class StatusPedido
{
    public int IdStatus { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<SolicitudDespensa> SolicitudDespensas { get; set; } = new List<SolicitudDespensa>();

    public virtual ICollection<SolicitudHojasDetalle> SolicitudHojasDetalles { get; set; } = new List<SolicitudHojasDetalle>();

    public virtual ICollection<SolicitudMedicamento> SolicitudMedicamentos { get; set; } = new List<SolicitudMedicamento>();
}
