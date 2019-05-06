using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using vue_abp_demo.Configuration.Dto;

namespace vue_abp_demo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : vue_abp_demoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
