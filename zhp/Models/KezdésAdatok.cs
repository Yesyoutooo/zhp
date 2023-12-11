using System;
using System.Collections.Generic;

namespace zhp.Models;

public partial class KezdésAdatok
{
    public int KezdésId { get; set; }

    public string KezdésTípus { get; set; } = null!;

    public virtual ICollection<Előadá> Előadás { get; set; } = new List<Előadá>();
}
