using System;
using System.Collections.Generic;

namespace zhp.Models;

public partial class ElőadásHelyszín
{
    public string Város { get; set; } = null!;

    public string Ország { get; set; } = null!;

    public string Iso { get; set; } = null!;

    public virtual ICollection<Előadá> Előadás { get; set; } = new List<Előadá>();
}
