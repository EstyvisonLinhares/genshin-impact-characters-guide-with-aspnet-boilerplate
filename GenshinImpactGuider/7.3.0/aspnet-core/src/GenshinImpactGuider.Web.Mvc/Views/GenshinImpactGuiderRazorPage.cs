using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace GenshinImpactGuider.Web.Views
{
    public abstract class GenshinImpactGuiderRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected GenshinImpactGuiderRazorPage()
        {
            LocalizationSourceName = GenshinImpactGuiderConsts.LocalizationSourceName;
        }
    }
}
