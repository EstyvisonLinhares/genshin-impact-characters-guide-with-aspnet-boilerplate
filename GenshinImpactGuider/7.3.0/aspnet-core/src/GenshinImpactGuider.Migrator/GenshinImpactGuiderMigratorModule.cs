using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GenshinImpactGuider.Configuration;
using GenshinImpactGuider.EntityFrameworkCore;
using GenshinImpactGuider.Migrator.DependencyInjection;

namespace GenshinImpactGuider.Migrator
{
    [DependsOn(typeof(GenshinImpactGuiderEntityFrameworkModule))]
    public class GenshinImpactGuiderMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public GenshinImpactGuiderMigratorModule(GenshinImpactGuiderEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(GenshinImpactGuiderMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                GenshinImpactGuiderConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GenshinImpactGuiderMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
