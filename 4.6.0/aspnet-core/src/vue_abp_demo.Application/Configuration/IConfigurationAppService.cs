using System.Threading.Tasks;
using vue_abp_demo.Configuration.Dto;

namespace vue_abp_demo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
