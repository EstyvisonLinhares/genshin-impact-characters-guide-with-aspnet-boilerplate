using System.Collections.Generic;
using GenshinImpactGuider.Roles.Dto;

namespace GenshinImpactGuider.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
