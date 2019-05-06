using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace vue_abp_demo.Controllers
{
    public abstract class vue_abp_demoControllerBase: AbpController
    {
        protected vue_abp_demoControllerBase()
        {
            LocalizationSourceName = vue_abp_demoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
