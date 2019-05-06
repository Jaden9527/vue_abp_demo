using System.Threading.Tasks;
using Abp.Application.Services;
using vue_abp_demo.Authorization.Accounts.Dto;

namespace vue_abp_demo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
