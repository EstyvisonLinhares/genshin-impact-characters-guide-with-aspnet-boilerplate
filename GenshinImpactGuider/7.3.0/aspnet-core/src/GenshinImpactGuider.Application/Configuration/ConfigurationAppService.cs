using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using GenshinImpactGuider.Configuration.Dto;

namespace GenshinImpactGuider.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GenshinImpactGuiderAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
