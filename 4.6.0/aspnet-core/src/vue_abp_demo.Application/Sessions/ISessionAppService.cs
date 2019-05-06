using System.Threading.Tasks;
using Abp.Application.Services;
using vue_abp_demo.Sessions.Dto;

namespace vue_abp_demo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
