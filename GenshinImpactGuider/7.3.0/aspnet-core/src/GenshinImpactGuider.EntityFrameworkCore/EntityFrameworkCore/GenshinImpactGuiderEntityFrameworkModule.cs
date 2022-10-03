using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using GenshinImpactGuider.EntityFrameworkCore.Seed;

namespace GenshinImpactGuider.EntityFrameworkCore
{
    [DependsOn(
        typeof(GenshinImpactGuiderCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class GenshinImpactGuiderEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<GenshinImpactGuiderDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        GenshinImpactGuiderDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        GenshinImpactGuiderDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GenshinImpactGuiderEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
