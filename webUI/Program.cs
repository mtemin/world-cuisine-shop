using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
  FileProvider = new PhysicalFileProvider(
    Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
    RequestPath = "/modules"
});
app.UseRouting();

app.MapDefaultControllerRoute();
app.MapRazorPages();

app.UseEndpoints(endpoints => 
{
  endpoints.MapControllerRoute(
    name:"default",
    pattern:"{controller}/{action}/{id?}"
  );
});

app.Run();
