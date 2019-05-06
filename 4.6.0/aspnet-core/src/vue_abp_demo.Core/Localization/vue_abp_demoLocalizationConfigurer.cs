using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace vue_abp_demo.Localization
{
    public static class vue_abp_demoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(vue_abp_demoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(vue_abp_demoLocalizationConfigurer).GetAssembly(),
                        "vue_abp_demo.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
