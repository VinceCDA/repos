using Microsoft.EntityFrameworkCore;
using TestIdentity.Data;
using Microsoft.AspNetCore.Identity;
using TestIdentity.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = "Server=LocalHost;Database=ASPNetCoreIdentity;Trusted_Connection=True;MultipleActiveResultSets=true";
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDefaultIdentity<Member>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
ConfigurationManager config = new();
config.AddJsonFile("./appsettings.json");
// Add services to the container.
builder.Services.AddRazorPages();

//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//        options.UseSqlServer("Server=LocalHost;Database=ASPNetCoreIdentity;Trusted_Connection=True;MultipleActiveResultSets=true"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
