using Microsoft.EntityFrameworkCore;
using TestIdentity.Data;
using Microsoft.AspNetCore.Identity;
using TestIdentity.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = "Server=LocalHost;Database=ASPNetCoreIdentity;Trusted_Connection=True;MultipleActiveResultSets=true";
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddIdentity<IdentityUser,IdentityRole> (options => options.SignIn.RequireConfirmedAccount = false)
    .AddErrorDescriber<FrenchIdentityErrorDescriber>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddRoleManager<RoleManager<IdentityRole>>()
    .AddSignInManager()
    .AddTokenProvider<DataProtectorTokenProvider<IdentityUser>>(TokenOptions.DefaultProvider)
    .AddDefaultUI();

    //.AddRoles<IdentityRole>();

//builder.Services.AddAuthentication()
//           .AddIdentityCookies();
ConfigurationManager config = new();
config.AddJsonFile("./appsettings.json");
// Add services to the container.
builder.Services.AddRazorPages();

//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//        options.UseSqlServer("Server=LocalHost;Database=ASPNetCoreIdentity;Trusted_Connection=True;MultipleActiveResultSets=true"));
//var UserManager = app.Services.GetRequiredService<UserManager<IdentityUser>>();

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
//using (var scope = app.Services.CreateScope())
//{
//    RolesConfig.InitialiseAsync(app.Services).Wait();  
//} ;
using (IServiceScope scope = app.Services.CreateScope())
{
    RoleManager<IdentityRole> roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    RolesConfig.InitialiseAsync(app.Services,roleManager).Wait();
    // Seed database code goes here
}

//initializing custom roles 

app.Run();
