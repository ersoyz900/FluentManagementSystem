using System;
using System.Collections.Generic;

namespace FluentManagementSystem.Models;

public partial class Kullanicilar
{
    public int KullaniciNo { get; set; }

    public string AdSoyad { get; set; } = null!;

    public string? Eposta { get; set; }

    public string? Departman { get; set; }

    public virtual ICollection<Gorevler> Gorevlers { get; set; } = new List<Gorevler>();
}
