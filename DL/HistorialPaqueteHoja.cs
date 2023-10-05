using System;
using System.Collections.Generic;

namespace DL;

public partial class HistorialPaqueteHoja
{
    public int IdHistorialPaqueteHojas { get; set; }

    public int? IdPapeleria { get; set; }

    public string? IdUsuario { get; set; }

    public DateTime? Fecha { get; set; }

    public virtual Papelerium? IdPapeleriaNavigation { get; set; }

    public virtual AspNetUser? IdUsuarioNavigation { get; set; }
}
