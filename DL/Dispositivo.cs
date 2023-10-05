using System;
using System.Collections.Generic;

namespace DL;

public partial class Dispositivo
{
    public int IdDispositivo { get; set; }

    public string Modelo { get; set; } = null!;

    public string? Ram { get; set; }

    public string? Procesador { get; set; }

    public string? Almacenamiento { get; set; }

    public string? TipoAlmacenamiento { get; set; }

    public string? Color { get; set; }

    public string? SistemaOperativo { get; set; }

    public string? TipoComputadora { get; set; }

    public int? IdMarca { get; set; }

    public virtual ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();

    public virtual Marca? IdMarcaNavigation { get; set; }
}
