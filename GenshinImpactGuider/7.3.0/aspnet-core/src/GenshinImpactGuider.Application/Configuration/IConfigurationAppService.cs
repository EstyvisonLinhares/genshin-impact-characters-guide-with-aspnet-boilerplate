using System.Threading.Tasks;
using GenshinImpactGuider.Configuration.Dto;

namespace GenshinImpactGuider.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
