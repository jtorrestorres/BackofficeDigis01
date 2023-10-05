using System;
using System.Collections.Generic;

namespace DL;

public partial class HistorialHoja
{
    public byte IdHistorialHojas { get; set; }

    public string? IdUsuario { get; set; }

    public int? IdHojas { get; set; }

    public DateTime? Fecha { get; set; }

    public int Cantidad { get; set; }

    public string? Motivo { get; set; }

    public virtual Hoja? IdHojasNavigation { get; set; }

    public virtual AspNetUser? IdUsuarioNavigation { get; set; }
}
