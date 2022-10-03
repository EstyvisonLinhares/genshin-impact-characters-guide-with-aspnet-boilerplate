using Abp.AutoMapper;
using GenshinImpactGuider.Sessions.Dto;

namespace GenshinImpactGuider.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
