using System;
using System.Collections.Generic;

namespace DL;

public partial class SolicitudMedicamentoDetalle
{
    public int IdDetalle { get; set; }

    public int? IdPedido { get; set; }

    public int? IdMedicamento { get; set; }

    public int? Cantidad { get; set; }

    public virtual Medicamento? IdMedicamentoNavigation { get; set; }

    public virtual SolicitudMedicamento? IdPedidoNavigation { get; set; }
}
