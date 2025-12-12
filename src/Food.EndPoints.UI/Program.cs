using Food.Infra.Data.Db.SqlServer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(optionsBuilder => 
    optionsBuilder.UseSqlServer(
        "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Maktab_Food_Db; Integrated Security=True;"));

builder.Services.AddDbContext<UsersDbContext>(optionsBuilder =>
    optionsBuilder.UseSqlServer(
        "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Maktab_Food_Db; Integrated Security=True;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
