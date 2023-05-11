namespace CourseManager.Api.Configurations;

public static class PresentationDI
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services
            .AddControllers()
            .AddApplicationPart(Presentation.AssemblyReference.Assembly);

        services.AddSwaggerGen();

        return services;
    }
}