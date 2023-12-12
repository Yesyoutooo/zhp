using System;
using System.Collections.Generic;

namespace zhp.Models;

public partial class RendezésAdatok
{
    public int RendezésId { get; set; }

    public string RendezésTípus { get; set; } = null!;

    public virtual ICollection<Előadás> Előadás { get; set; } = new List<Előadás>();
}
