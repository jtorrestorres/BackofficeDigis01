using System;
using System.Collections.Generic;

namespace DL;

public partial class SolicitudHoja
{
    public int IdSolicitudHojasDetalle { get; set; }

    public int? IdSolicitudHojas { get; set; }

    public int? IdHojas { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal Total { get; set; }

    public virtual Hoja? IdHojasNavigation { get; set; }

    public virtual SolicitudHojasDetalle? IdSolicitudHojasNavigation { get; set; }
}
