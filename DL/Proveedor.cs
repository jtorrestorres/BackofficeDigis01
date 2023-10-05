using System;
using System.Collections.Generic;

namespace DL;

public partial class Proveedor
{
    public byte IdProveedor { get; set; }

    public string? Nombre { get; set; }

    public string? Telefono { get; set; }

    public string? PaginaWeb { get; set; }

    public string? Direccion { get; set; }

    public virtual ICollection<Papelerium> Papeleria { get; set; } = new List<Papelerium>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
