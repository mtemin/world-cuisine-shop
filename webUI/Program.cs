using business.Concrete;
using data.Abstract;
using data.Concrete;
using data.Concrete.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;


builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<WorldCuisineShopContext>(
//   options =>
// {
//   options.UseNpgsql(configuration.GetConnectionString("worldCuisine"));
// }
);

builder.Services.AddScoped<IFoodRepository, EFCoreFoodRepository>();
builder.Services.AddScoped<IFoodService, FoodManager>();

SeedDatabase.Seed();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  // Development-specific configuration
  SeedDatabase.Seed();
  app.UseDeveloperExceptionPage();
}

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
  name: "default",
  pattern: "{controller}/{action}/{id?}"
);
});

app.Run();
