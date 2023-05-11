using CourseManager.Api.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder
    .Services
    .AddMiddlewares()
    .AddInfrastructure()
    .AddPersistence(builder.Configuration)
    .AddApplication()
    .AddPresentation();

builder.Services.AddControllersWithViews();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
