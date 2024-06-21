using System.Resources;

namespace DovahkiinLounge.Lang
{
    public class EN
    {
        public static ResourceManager ResourceManager { get; } = new ResourceManager(typeof(EN));
        public static string DovahmemDLL => "FOUND: DovahkiinLounge.Memory.dll, Controls Enabled/Timer Stopped";
        public static string Infos_More => "More";
        public static string WelcomeConsole => "Welcome to xCheats";
        public static string GFWLDwn => "Games For Windows Live is disabled by Microsoft here u can download the offline setup ";
        public static string FourGBPatchTxt => "This is a patcher for 32Bit old games to patch the 4GB for 64Bit";
        public static string RemoveBtn => "Uninstall";
        public static string OpenBtn => "Start";
        public static string DwnBtn => "Download";
        public static string DwnExtractSuc => "Download and extraction completed successfully.";
        public static string InitConsole => "Disable the Console Hide Function after Initialize";
        public static string AddStart => "Create Autostart On Boot";
        public static string RmStart => "Removed Autostart";
        public static string DovahmemDLLF => "NOT-FOUND: DovahkiinLounge.Memory.dll, Controls Disabled";
        public static string BUT_OK = "Open";
        public static string BUT_CANCEL = "Ignore";
        public static string BUT_ABORT = "Stop";
        public static string BUT_RETRY = "Continue";
        public static string BUT_IGNORE = "Ignore";
        public static string BUT_YES = "Yes";
        public static string BUT_NO = "No";
    }
}
