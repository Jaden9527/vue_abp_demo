using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using vue_abp_demo.Authorization;

namespace vue_abp_demo
{
    [DependsOn(
        typeof(vue_abp_demoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class vue_abp_demoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<vue_abp_demoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(vue_abp_demoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
