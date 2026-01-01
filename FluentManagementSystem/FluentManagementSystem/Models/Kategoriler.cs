using System;
using System.Collections.Generic;

namespace FluentManagementSystem.Models;

public partial class Kategoriler
{
    public int KategoriNo { get; set; }

    public string KategoriAd { get; set; } = null!;

    public virtual ICollection<Gorevler> Gorevlers { get; set; } = new List<Gorevler>();
}
