using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApp_1._44_PracticeProject.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Db1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Db1Context") ?? throw new InvalidOperationException("Connection string 'Db1Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
