using Abp.Application.Services.Dto;

namespace vue_abp_demo.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

