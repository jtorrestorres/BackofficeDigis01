using System;
using System.Collections.Generic;

namespace DL;

public partial class StatusCrendencial
{
    public int IdStatus { get; set; }

    public string? TipoStatus { get; set; }

    public virtual ICollection<Credencial> Credencials { get; set; } = new List<Credencial>();
}
