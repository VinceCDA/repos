using Microsoft.AspNetCore.Identity;

namespace TestIdentity.Data
{
    public static class RolesConfig
    {

        public static async Task InitialiseAsync(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                string[] roleNames = { "Admin", "Report", "Search" };
                foreach (var roleName in roleNames)
                {
                    var roleExist = await roleManager.RoleExistsAsync(roleName);
                    if (!roleExist)
                        await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
            
        }
    }
}
