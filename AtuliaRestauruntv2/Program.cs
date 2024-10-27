using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AtuliaRestauruntv2.Data;
using AtuliaRestauruntv2.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AtuliaRestauruntv2ContextConnection") ?? throw new InvalidOperationException("Connection string 'AtuliaRestauruntv2ContextConnection' not found.");

builder.Services.AddDbContext<AtuliaRestauruntv2Context>(options =>
    options.UseSqlServer(connectionString));

// Use ApplicationUser instead of ApplicationUser
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AtuliaRestauruntv2Context>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
