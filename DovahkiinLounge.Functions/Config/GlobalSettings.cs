namespace DovahkiinLounge.Functions
{
    public static class GlobalSettings
    {
        private static readonly IniConfig config;
        private static readonly string configFilePath;

        static GlobalSettings() // Static constructor
        {
             config = new IniConfig();
             string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
             string appFolderPath = Path.Combine(appDataPath, "DovahkiinLounge Group", "xCheats");
             configFilePath = Path.Combine(appFolderPath, "Config\\config.ini");
             LoadSettings();
        }

        public static bool AdminMode { get; set; }
        public static bool IsOfflineMode { get; set; }
        public static bool BackgroundWork { get; set; }
        public static bool ConsoleHideFunction { get; set; }
        public static string? SelectedInstallPath { get; set; }
        public static string? LobbyCode { get; set; }
        public static int ButtonMode { get; set; }
        public static int AutostartMode { get; set; }

        internal static void LoadSettings()
        {
            config.Load(configFilePath);
            _ = bool.TryParse(config.GetValue("Settings", "AdminMode"), out bool adminModeValue);
            _ = bool.TryParse(config.GetValue("Settings", "OfflineMode"), out bool offlineModeValue);
            _ = bool.TryParse(config.GetValue("Settings", "BackgroundWork"), out bool backgroundWorkValue);
            _ = bool.TryParse(config.GetValue("Settings", "ConsoleHide"), out bool ConsoleHide);
            string SelectedPath = config.GetStringValue("RDR", "Path", "");
            string LobbyID = config.GetStringValue("RDR", "LobbyCode", "");
            int btnmode = config.GetIntValue("RDR", "RedDead2Btn");
            int autostart = config.GetIntValue("Settings" ,"AutoStart");
            BackgroundWork = backgroundWorkValue;
            AdminMode = adminModeValue;
            IsOfflineMode = offlineModeValue;
            SelectedInstallPath = SelectedPath;
            ButtonMode = btnmode;
            AutostartMode = autostart;
            ConsoleHideFunction = ConsoleHide;
            LobbyCode = LobbyID;
        }
    }
}
