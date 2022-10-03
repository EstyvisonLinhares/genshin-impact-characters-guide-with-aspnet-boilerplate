using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GenshinImpactGuider.Authorization;

namespace GenshinImpactGuider
{
    [DependsOn(
        typeof(GenshinImpactGuiderCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GenshinImpactGuiderApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GenshinImpactGuiderAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GenshinImpactGuiderApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
