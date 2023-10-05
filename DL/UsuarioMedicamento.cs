using System;
using System.Collections.Generic;

namespace DL;

public partial class UsuarioMedicamento
{
    public int IdUsuarioMedicamento { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdMedicamento { get; set; }

    public int? Cantidad { get; set; }

    public string? Motivo { get; set; }

    public DateTime? Fecha { get; set; }

    public string? IdUsuarioSuministro { get; set; }

    public virtual Medicamento? IdMedicamentoNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }

    public virtual AspNetUser? IdUsuarioSuministroNavigation { get; set; }
}
