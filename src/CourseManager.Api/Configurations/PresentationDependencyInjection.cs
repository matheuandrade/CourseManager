namespace CourseManager.Api.Configurations;

public static class PresentationServiceInstaller
{
    public static void AddPresentation(IServiceCollection services)
    {
        services
            .AddControllers()
            .AddApplicationPart(Presentation.AssemblyReference.Assembly);

        services.AddSwaggerGen();
    }
}