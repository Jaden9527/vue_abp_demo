using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using vue_abp_demo.Configuration;
using vue_abp_demo.EntityFrameworkCore;
using vue_abp_demo.Migrator.DependencyInjection;

namespace vue_abp_demo.Migrator
{
    [DependsOn(typeof(vue_abp_demoEntityFrameworkModule))]
    public class vue_abp_demoMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public vue_abp_demoMigratorModule(vue_abp_demoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(vue_abp_demoMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                vue_abp_demoConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(vue_abp_demoMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
