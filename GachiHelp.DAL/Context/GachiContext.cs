using GachiHelp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GachiHelp.DAL.Context;

public class GachiContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<HelpCategory> HelpCategories { get; set; } = null!;
    public DbSet<Help> Helps { get; set; } = null!;
    public DbSet<JobApplications> JobApplications { get; set; } = null!;

    public DbSet<AppliedJobApplication> AppliedJobApplication { get; set; } = null!;

    public GachiContext(DbContextOptions<GachiContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasIndex(u => u.Login).IsUnique();
        modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();

        modelBuilder.Entity<AppliedJobApplication>()
            .HasOne(app => app.JobApplication)
            .WithMany(u => u.AppliedJobApplication)
            .HasForeignKey(app => app.JobApplicationId);

        modelBuilder.Entity<AppliedJobApplication>()
            .HasOne(app => app.AppliedUser)
            .WithMany(u => u.AppliedJobApplication)
            .HasForeignKey(app => app.AppliedUsersId);

        modelBuilder.Seed();
        
        base.OnModelCreating(modelBuilder);
    }

}
