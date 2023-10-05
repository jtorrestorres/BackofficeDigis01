using System;
using System.Collections.Generic;

namespace DL;

public partial class SolicitudDespensaDetalle
{
    public int IdDetalle { get; set; }

    public int? IdPedido { get; set; }

    public int? IdProductoPiso { get; set; }

    public int? Cantidad { get; set; }

    public virtual SolicitudMedicamento? IdPedidoNavigation { get; set; }

    public virtual ProductoPiso? IdProductoPisoNavigation { get; set; }
}
