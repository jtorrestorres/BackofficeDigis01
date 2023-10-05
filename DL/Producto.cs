using System;
using System.Collections.Generic;

namespace DL;

public partial class Producto
{
    public Guid IdProducto { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public byte[]? Imagen { get; set; }

    public byte IdTipo { get; set; }

    public byte IdProveedor { get; set; }

    public string? IdUsuarioRegistro { get; set; }

    public virtual ICollection<HistorialMobiliario> HistorialMobiliarios { get; set; } = new List<HistorialMobiliario>();

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;

    public virtual Tipo IdTipoNavigation { get; set; } = null!;

    public virtual AspNetUser? IdUsuarioRegistroNavigation { get; set; }

    public virtual ICollection<Papelerium> Papeleria { get; set; } = new List<Papelerium>();

    public virtual ICollection<ProductoPiso> ProductoPisos { get; set; } = new List<ProductoPiso>();
}
