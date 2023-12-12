using System;
using System.Collections.Generic;

namespace zhp.Models;

public partial class ÉvadAdatok
{
    public int ÉvadId { get; set; }

    public string ÉvadMegnevezése { get; set; } = null!;

    public virtual ICollection<Előadás> Előadás { get; set; } = new List<Előadás>();
}
