using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace GenshinImpactGuider.Localization
{
    public static class GenshinImpactGuiderLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(GenshinImpactGuiderConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(GenshinImpactGuiderLocalizationConfigurer).GetAssembly(),
                        "GenshinImpactGuider.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
