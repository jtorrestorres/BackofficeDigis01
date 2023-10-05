using System;
using System.Collections.Generic;

namespace DL;

public partial class Generacion
{
    public int IdGeneracion { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime? FechaSalidaEstimada { get; set; }

    public virtual ICollection<UsuarioGeneracion> UsuarioGeneracions { get; set; } = new List<UsuarioGeneracion>();
}
