using System.Collections.Generic;
using GenshinImpactGuider.Roles.Dto;

namespace GenshinImpactGuider.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
