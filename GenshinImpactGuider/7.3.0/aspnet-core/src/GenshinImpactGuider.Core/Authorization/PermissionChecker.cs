using Abp.Authorization;
using GenshinImpactGuider.Authorization.Roles;
using GenshinImpactGuider.Authorization.Users;

namespace GenshinImpactGuider.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
