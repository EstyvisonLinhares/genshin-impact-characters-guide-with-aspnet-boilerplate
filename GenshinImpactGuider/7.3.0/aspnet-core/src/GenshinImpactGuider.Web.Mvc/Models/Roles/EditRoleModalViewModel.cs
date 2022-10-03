using Abp.AutoMapper;
using GenshinImpactGuider.Roles.Dto;
using GenshinImpactGuider.Web.Models.Common;

namespace GenshinImpactGuider.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
