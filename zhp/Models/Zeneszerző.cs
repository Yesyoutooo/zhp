using System;
using System.Collections.Generic;

namespace zhp.Models;

public partial class Zeneszerző
{
    public int? ZenId { get; set; }

    public string Név { get; set; } = null!;

    public DateTime? SzületésDátum { get; set; }

    public DateTime? HalálDátum { get; set; }

    public string Nemzetiség { get; set; } = null!;

    public string Nem { get; set; } = null!;

    public virtual ICollection<OperaAdatok> OperaAdatoks { get; set; } = new List<OperaAdatok>();
}
