using Microsoft.EntityFrameworkCore;
using CourseManager.Persistence;

namespace CourseManager.Api.Configurations;

public static class PersistenceDI
{
    public static IServiceCollection AddPersistence(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(
                (sp, optionsBuilder) =>
                {
                    optionsBuilder.UseSqlServer(
                        configuration.GetConnectionString("Database"));
                });

        return services;
    }
}