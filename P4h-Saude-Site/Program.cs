using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using P4h_Saude_Site.Areas.Identity.Data;
using P4h_Saude_Site.Data;
var builder = WebApplication.CreateBuilder(args);

var connectionString = "server=p4h-saude-server-azure.mysql.database.azure.com;user=LAPTOP09SI7DE3;password=Acelera!123;database=p4h-user-data";

builder.Services.AddDbContext<P4h_Saude_SiteContext>(options => options.UseMySql(connectionString, new MySqlServerVersion(new Version(8,0,33))));

builder.Services.AddDefaultIdentity<P4h_Saude_Site_UserClass>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<P4h_Saude_SiteContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

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
app.MapRazorPages();

app.Run();
