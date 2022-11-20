using GachiHelp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GachiHelp.DAL.Context;

public class GachiContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<HelpCategory> HelpCategories { get; set; } = null!;
    public DbSet<Help> Helps { get; set; } = null!;
    public DbSet<UserComment> UserComments { get; set; } = null!;

    public GachiContext(DbContextOptions<GachiContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasIndex(u => u.Login).IsUnique();
        modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();

        modelBuilder.Seed();
        
        base.OnModelCreating(modelBuilder);
    }
}
