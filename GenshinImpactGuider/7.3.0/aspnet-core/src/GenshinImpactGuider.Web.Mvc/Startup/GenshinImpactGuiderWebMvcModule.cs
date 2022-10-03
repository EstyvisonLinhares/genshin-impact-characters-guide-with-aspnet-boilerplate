using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GenshinImpactGuider.Configuration;

namespace GenshinImpactGuider.Web.Startup
{
    [DependsOn(typeof(GenshinImpactGuiderWebCoreModule))]
    public class GenshinImpactGuiderWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GenshinImpactGuiderWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<GenshinImpactGuiderNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GenshinImpactGuiderWebMvcModule).GetAssembly());
        }
    }
}
