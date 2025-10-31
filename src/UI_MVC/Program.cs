using Microsoft.EntityFrameworkCore;
using UI_MVC.Middlwares;
using UI_MVC.Models.Database;
using UI_MVC.Services;

// Add services to the container.
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddScoped<IPeopleRepository, PeopleRepository>();
builder.Services.AddScoped<IRealNumbers, RealNumbers>();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddScoped<ICalculator, Calculator3>();
}
else
{
    builder.Services.AddScoped<Calculator2, Calculator2>();
}

builder.Services.AddDbContext<AppDbContext>(optionsBuilder =>
    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Maktab_PeopleDb; Integrated Security=True;"));





// Configure the HTTP request pipeline.
var app = builder.Build();
app.UseMiddleware<LoggingMiddleware>();
app.UseMiddleware<IpCheckerMiddleware>();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();
app.Run();
