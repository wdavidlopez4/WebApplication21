using Microsoft.EntityFrameworkCore;
using WebApplication21.Data;
using WebApplication21.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//IOC
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<EscuelaServices>();

//config de db
builder.Services.AddDbContext<WebApplication21DbContext>(options => 
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("WebConnectionString")));

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
