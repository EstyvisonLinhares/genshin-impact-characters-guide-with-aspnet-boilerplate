using System.Collections.Generic;
using GenshinImpactGuider.Roles.Dto;

namespace GenshinImpactGuider.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}