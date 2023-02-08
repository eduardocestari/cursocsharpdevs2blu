using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using RevisaoProjetoNoticias.Domain.IRepositories;
using RevisaoProjetoNoticias.Infra.Data.Context;
using RevisaoProjetoNoticias.Infra.Data.Repositories;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Context SQL Server
builder.Services.AddControllersWithViews();
// Context DB SQL Server
builder.Services.AddDbContext<SQLServerContext>
    (options => options.UseSqlServer("Server=localhost;Database=NewsPage;User Id=sa;Password=sa123456; TrustServerCertificate=True"));

// Dependecy Injection
// #Repositories
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>(); 
builder.Services.AddScoped<INewsRepository, NewsRepository>();  

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
