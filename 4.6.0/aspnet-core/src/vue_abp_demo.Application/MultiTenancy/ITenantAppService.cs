using Abp.Application.Services;
using Abp.Application.Services.Dto;
using vue_abp_demo.MultiTenancy.Dto;

namespace vue_abp_demo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

