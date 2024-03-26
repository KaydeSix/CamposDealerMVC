using CamposDealerMVC.Business.Cliente;
using CamposDealerMVC.Business.Produto;
using CamposDealerMVC.Business.Venda;
using CamposDealerMVC.DataAcces;
using CamposDealerMVC.Repositorio.Cliente;
using CamposDealerMVC.Repositorio.Produto;
using CamposDealerMVC.Repositorio.Venda;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string mySqlConnection = builder.Configuration.GetConnectionString("DataBase");
builder.Services.AddEntityFrameworkSqlServer().AddDbContext<BancoContext>(x => x.UseSqlServer(mySqlConnection));

builder.Services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
builder.Services.AddScoped<IClienteBL, ClienteBL>();

builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
builder.Services.AddScoped<IProdutoBL, ProdutoBL>();

builder.Services.AddScoped<IVendaRepositorio, VendaRepositorio>();
builder.Services.AddScoped<IVendaBL, VendaBL>();

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
    pattern: "{controller=Produto}/{action=Produto}/{id?}");

app.Run();
