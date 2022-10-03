using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GenshinImpactGuider.Configuration;

namespace GenshinImpactGuider.Web.Host.Startup
{
    [DependsOn(
       typeof(GenshinImpactGuiderWebCoreModule))]
    public class GenshinImpactGuiderWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GenshinImpactGuiderWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GenshinImpactGuiderWebHostModule).GetAssembly());
        }
    }
}
