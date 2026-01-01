using System;
using System.Collections.Generic;

namespace FluentManagementSystem.Models;

public partial class OncelikDurumlari
{
    public int OncelikNo { get; set; }

    public string OncelikAd { get; set; } = null!;

    public string? RenkKodu { get; set; }

    public virtual ICollection<Gorevler> Gorevlers { get; set; } = new List<Gorevler>();
}
