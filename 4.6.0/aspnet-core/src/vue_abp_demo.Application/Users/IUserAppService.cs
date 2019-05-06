using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using vue_abp_demo.Roles.Dto;
using vue_abp_demo.Users.Dto;

namespace vue_abp_demo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
