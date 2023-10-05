using System;
using System.Collections.Generic;

namespace DL;

public partial class UsuarioGeneracion
{
    public int IdUsuarioGeneracion { get; set; }

    public int IdUsuario { get; set; }

    public int IdGeneracion { get; set; }

    public virtual Generacion IdGeneracionNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
