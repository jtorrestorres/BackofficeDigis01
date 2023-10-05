using System;
using System.Collections.Generic;

namespace DL;

public partial class CredencialPiso
{
    public int? IdCredencial { get; set; }

    public int? IdPiso { get; set; }

    public virtual Credencial? IdCredencialNavigation { get; set; }

    public virtual Piso? IdPisoNavigation { get; set; }
}
