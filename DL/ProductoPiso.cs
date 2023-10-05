using System;
using System.Collections.Generic;

namespace DL;

public partial class ProductoPiso
{
    public int IdProductoPiso { get; set; }

    public Guid? IdProducto { get; set; }

    public int? IdPiso { get; set; }

    public virtual ICollection<HistorialMobiliario> HistorialMobiliarios { get; set; } = new List<HistorialMobiliario>();

    public virtual Piso? IdPisoNavigation { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }

    public virtual ICollection<Medicamento> Medicamentos { get; set; } = new List<Medicamento>();

    public virtual ICollection<Mobiliario> Mobiliarios { get; set; } = new List<Mobiliario>();

    public virtual ICollection<ProductoHistorial> ProductoHistorials { get; set; } = new List<ProductoHistorial>();

    public virtual ICollection<SolicitudDespensaDetalle> SolicitudDespensaDetalles { get; set; } = new List<SolicitudDespensaDetalle>();
}
