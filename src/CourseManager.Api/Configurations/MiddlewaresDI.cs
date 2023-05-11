using CourseManager.Api.Middlewares;

namespace CourseManager.Api.Configurations;

public static class MiddlewaresDI
{
    public static IServiceCollection AddMiddlewares(this IServiceCollection services)
    {
        services.AddTransient<GlobalExceptionHandlingMiddleware>();

        return services;
    }
}