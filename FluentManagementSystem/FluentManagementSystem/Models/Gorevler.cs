using System;
using System.Collections.Generic;

namespace FluentManagementSystem.Models;

public partial class Gorevler
{
    public int GorevNo { get; set; }

    public string GorevBaslik { get; set; } = null!;

    public string? GorevAciklama { get; set; }

    public int RefProjeNo { get; set; }

    public int RefKullaniciNo { get; set; }

    public int RefOncelikNo { get; set; }

    public int RefKategoriNo { get; set; }

    public bool? TamamlandiMi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public virtual Kategoriler RefKategoriNoNavigation { get; set; } = null!;

    public virtual Kullanicilar RefKullaniciNoNavigation { get; set; } = null!;

    public virtual OncelikDurumlari RefOncelikNoNavigation { get; set; } = null!;

    public virtual Projeler RefProjeNoNavigation { get; set; } = null!;
}
