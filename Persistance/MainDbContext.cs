using Microsoft.EntityFrameworkCore;
using Models.Models;
using System.Diagnostics.Metrics;

namespace Persistance;

public class MainDbContext : DbContext
{
    public DbSet<Detail> Details {  get; set; }
    public DbSet<Profession> Professions { get; set; }
    public DbSet<Standart> Standarts { get; set; }
    public DbSet<Tarif> Tarifs { get; set; }
    public DbSet<Operation> Operations { get; set; }
    public MainDbContext(DbContextOptions<MainDbContext> options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseNpgsql($"Host=localhost;Port=5432;Username=postgres;Password=admin;Database=HomeWork");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Standart>()
            .ToTable(t => t.HasCheckConstraint("DischargeBuilder", "\"DischargeBuilder\" > 0 AND \"DischargeBuilder\" < 9"));
    }
}