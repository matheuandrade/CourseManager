using Scrutor;

namespace CourseManager.Api.Configurations;

public static class InfrastructureDI
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
         services
            .Scan(
                selector => selector
                    .FromAssemblies(
                        Persistence.AssemblyReference.Assembly)
                    .AddClasses(false)
                    .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                    .AsMatchingInterface()
                    .WithScopedLifetime());

        return services;
    }
}