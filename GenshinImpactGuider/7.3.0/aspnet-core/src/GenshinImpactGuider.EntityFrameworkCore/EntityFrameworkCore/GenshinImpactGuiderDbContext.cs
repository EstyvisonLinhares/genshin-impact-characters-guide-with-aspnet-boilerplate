using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GenshinImpactGuider.Authorization.Roles;
using GenshinImpactGuider.Authorization.Users;
using GenshinImpactGuider.MultiTenancy;

namespace GenshinImpactGuider.EntityFrameworkCore
{
    public class GenshinImpactGuiderDbContext : AbpZeroDbContext<Tenant, Role, User, GenshinImpactGuiderDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public GenshinImpactGuiderDbContext(DbContextOptions<GenshinImpactGuiderDbContext> options)
            : base(options)
        {
        }
    }
}
