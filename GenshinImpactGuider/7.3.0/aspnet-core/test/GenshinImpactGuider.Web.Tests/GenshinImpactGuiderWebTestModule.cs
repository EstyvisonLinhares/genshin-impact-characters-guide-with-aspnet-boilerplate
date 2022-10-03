using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GenshinImpactGuider.EntityFrameworkCore;
using GenshinImpactGuider.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace GenshinImpactGuider.Web.Tests
{
    [DependsOn(
        typeof(GenshinImpactGuiderWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class GenshinImpactGuiderWebTestModule : AbpModule
    {
        public GenshinImpactGuiderWebTestModule(GenshinImpactGuiderEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GenshinImpactGuiderWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(GenshinImpactGuiderWebMvcModule).Assembly);
        }
    }
}