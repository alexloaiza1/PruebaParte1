using PruebaPart1.Data;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Configuro la cadena de conexion a SQLServer 
builder.Services.AddDbContext<AppDBContex>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionSqlServer"))
);



// Add services to the container.
builder.Services.AddControllersWithViews();

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
