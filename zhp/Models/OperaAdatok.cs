using System;
using System.Collections.Generic;

namespace zhp.Models;

public partial class OperaAdatok
{
    public int OperaId { get; set; }

    public int? ZeneszerzőId { get; set; }

    public string OperaCíme { get; set; } = null!;

    public string? Éneknyelv { get; set; }

    public string? ŐsbemutatóÉve { get; set; }

    public virtual ICollection<Előadá> Előadás { get; set; } = new List<Előadá>();

    public virtual Zeneszerző Zeneszerző { get; set; } = null!;
}
