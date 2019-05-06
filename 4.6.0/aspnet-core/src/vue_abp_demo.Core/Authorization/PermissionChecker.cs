using Abp.Authorization;
using vue_abp_demo.Authorization.Roles;
using vue_abp_demo.Authorization.Users;

namespace vue_abp_demo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
