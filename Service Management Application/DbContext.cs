using Service_Management_Application.Controllers;
using Service_Management_Application.Models;

namespace Service_Management_Application;

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext // Renamed from DbContext to AppDbContext
{
    public DbSet<Persons> Persons { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<Project> Projects { get; set; }
    
    // Add a constructor that accepts DbContextOptions<AppDbContext>
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Person-Skill Relationship
        modelBuilder.Entity<Persons>()
            .HasMany(p => p.Skills)
            .WithOne(s => s.Person)
            .HasForeignKey(s => s.PersonId);

        // Project-Skill Relationship
        modelBuilder.Entity<Project>()
            .HasMany(p => p.Skills)
            .WithOne(s => s.Project)
            .HasForeignKey(s => s.ProjectId);
    }

}