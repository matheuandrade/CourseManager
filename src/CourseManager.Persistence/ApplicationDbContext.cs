using CourseManager.Domain.Abstractions;
using CourseManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseManager.Persistence;

public partial class ApplicationDbContext : DbContext, IUnitOfWork
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public ApplicationDbContext(){
        this.Database.EnsureCreated();
    }

    public virtual DbSet<Course> Courses => Set<Course>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}

