using System.Collections.Generic;

namespace GenshinImpactGuider.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
