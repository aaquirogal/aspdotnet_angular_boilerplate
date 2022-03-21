using MyApp.Debugging;

namespace MyApp
{
    public class MyAppConsts
    {
        public const string LocalizationSourceName = "MyApp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "cb19735d94144ddca7ea5c8897ebb217";
    }
}
