using Abp.AspNetCore.Mvc.ViewComponents;

namespace GenshinImpactGuider.Web.Views
{
    public abstract class GenshinImpactGuiderViewComponent : AbpViewComponent
    {
        protected GenshinImpactGuiderViewComponent()
        {
            LocalizationSourceName = GenshinImpactGuiderConsts.LocalizationSourceName;
        }
    }
}
