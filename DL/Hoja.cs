using System;
using System.Collections.Generic;

namespace DL;

public partial class Hoja
{
    public int IdHojas { get; set; }

    public int? IdPapeleria { get; set; }

    public byte? IdMembretado { get; set; }

    public int Cantidad { get; set; }

    public virtual ICollection<HistorialHoja> HistorialHojas { get; set; } = new List<HistorialHoja>();

    public virtual Membretado? IdMembretadoNavigation { get; set; }

    public virtual Papelerium? IdPapeleriaNavigation { get; set; }

    public virtual ICollection<SolicitudHoja> SolicitudHojas { get; set; } = new List<SolicitudHoja>();
}
