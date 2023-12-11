using System;
using System.Collections.Generic;

namespace zhp.Models;

public partial class Előadá
{
    public int ElőadásId { get; set; }

    public DateTime? PremierDátum { get; set; }

    public int ElőadásokSzáma { get; set; }

    public string Város { get; set; } = null!;

    public int KezdésId { get; set; }

    public int ÉvadId { get; set; }

    public int RendezésId { get; set; }

    public int OperaId { get; set; }

    public virtual KezdésAdatok Kezdés { get; set; } = null!;

    public virtual OperaAdatok Opera { get; set; } = null!;

    public virtual RendezésAdatok Rendezés { get; set; } = null!;

    public virtual ElőadásHelyszín VárosNavigation { get; set; } = null!;

    public virtual ÉvadAdatok Évad { get; set; } = null!;
}
