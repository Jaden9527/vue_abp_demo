using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using vue_abp_demo.Configuration;

namespace vue_abp_demo.Web.Host.Startup
{
    [DependsOn(
       typeof(vue_abp_demoWebCoreModule))]
    public class vue_abp_demoWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public vue_abp_demoWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(vue_abp_demoWebHostModule).GetAssembly());
        }
    }
}
