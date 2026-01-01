using Microsoft.EntityFrameworkCore;

namespace FluentManagementSystem.Web.Data;

public class ProjeDbContext : DbContext
{
    public ProjeDbContext(DbContextOptions<ProjeDbContext> options) : base(options) { }

    // Burası SQL'deki tabloyu temsil eder. 
    // Eğer SQL'deki tablonun adı farklıysa "Gorevler" yerine onu yaz.
    public DbSet<GorevModel> Gorevler { get; set; }
}

public class GorevModel
{
    public int Id { get; set; }
    public string? Baslik { get; set; }
    public string? Aciklama { get; set; }
}