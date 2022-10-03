using GenshinImpactGuider.Debugging;

namespace GenshinImpactGuider
{
    public class GenshinImpactGuiderConsts
    {
        public const string LocalizationSourceName = "GenshinImpactGuider";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "e612320ca2154fada5eba72775a9968e";
    }
}
