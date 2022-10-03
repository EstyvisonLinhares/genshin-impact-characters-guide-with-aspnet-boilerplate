using Abp.AutoMapper;
using GenshinImpactGuider.Authentication.External;

namespace GenshinImpactGuider.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
