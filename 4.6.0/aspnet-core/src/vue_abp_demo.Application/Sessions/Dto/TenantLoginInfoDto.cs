using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using vue_abp_demo.MultiTenancy;

namespace vue_abp_demo.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
