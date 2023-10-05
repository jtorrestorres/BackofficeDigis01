using System;
using System.Collections.Generic;

namespace DL;

public partial class Medicamento
{
    public int IdMedicamento { get; set; }

    public int? IdProductoPiso { get; set; }

    public int? Stock { get; set; }

    public virtual ProductoPiso? IdProductoPisoNavigation { get; set; }

    public virtual ICollection<SolicitudMedicamentoDetalle> SolicitudMedicamentoDetalles { get; set; } = new List<SolicitudMedicamentoDetalle>();

    public virtual ICollection<UsuarioMedicamento> UsuarioMedicamentos { get; set; } = new List<UsuarioMedicamento>();
}
