using System;
using System.Collections.Generic;

namespace FluentManagementSystem.Models;

public partial class Projeler
{
    public int ProjeNo { get; set; }

    public string ProjeAd { get; set; } = null!;

    public DateTime? OlusturmaTarihi { get; set; }

    public bool? AktifMi { get; set; }

    public virtual ICollection<Gorevler> Gorevlers { get; set; } = new List<Gorevler>();
}
