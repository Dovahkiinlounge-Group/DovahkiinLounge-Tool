using System.Globalization;
using System.Resources;
namespace DovahkiinLounge.Functions
{

    public class IniConfig
    {
        CultureInfo currentCulture = CultureInfo.CurrentCulture;
        readonly ResourceManager rm = new ResourceManager("DovahkiinLounge.Functions.Language.Functions", typeof(IniConfig).Assembly);


        private readonly Dictionary<string, Dictionary<string, string>> sections;

        public IniConfig()
        {
            sections = new Dictionary<string, Dictionary<string, string>>();
        }

        public void Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("INI file not found.", filePath);
            }

            sections.Clear();

            string[] lines = File.ReadAllLines(filePath);

            string currentSection = "";

            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();

                if (trimmedLine.StartsWith("[") && trimmedLine.EndsWith("]"))
                {
                    currentSection = trimmedLine.Substring(1, trimmedLine.Length - 2);
                    continue;
                }

                int separatorIndex = trimmedLine.IndexOf("=");
                if (separatorIndex > 0)
                {
                    string key = trimmedLine.Substring(0, separatorIndex).Trim();
                    string value = trimmedLine.Substring(separatorIndex + 1).Trim();

                    if (!sections.ContainsKey(currentSection))
                    {
                        sections[currentSection] = new Dictionary<string, string>();
                    }

                    sections[currentSection][key] = value;
                }
            }
        }

        public string GetValue(string section, string key, string defaultValue = "")
        {
            if (sections.TryGetValue(section, out var sectionData))
            {
                if (sectionData.TryGetValue(key, out var value))
                {
                    if (bool.TryParse(value, out bool boolValue))
                    {
                        return boolValue.ToString();
                    }
                    return value;
                }
            }

            return defaultValue;
        }
        public string GetStringValue(string section, string key, string defaultValue = "")
        {
            if (sections.TryGetValue(section, out var sectionData))
            {
                if (sectionData.TryGetValue(key, out var value))
                {
                    return value;
                }
            }

            return defaultValue;
        }

        public int GetIntValue(string section, string key, int defaultValue = 0)
        {
            if (sections.TryGetValue(section, out var sectionData))
            {
                if (sectionData.TryGetValue(key, out var value))
                {
                    if (int.TryParse(value, out int intValue))
                    {
                        return intValue;
                    }
                }
            }

            return defaultValue;
        }

        public void SetValue(string section, string key, string value)
        {
            if (!sections.ContainsKey(section))
            {
                sections[section] = new Dictionary<string, string>();
            }

            sections[section][key] = value;
        }

        public void Save(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var section in sections)
                {
                    writer.WriteLine($"[{section.Key}]");

                    foreach (var kvp in section.Value)
                    {
                        writer.WriteLine($"{kvp.Key}={kvp.Value}");
                    }

                    writer.WriteLine();
                }
            }
            GlobalSettings.LoadSettings();
        }
        public void Check(string filepath)
        {
            try
            {
                if (!File.Exists(filepath))
                {

                    SetValue("Settings", "OfflineMode", "false");
                    SetValue("Settings", "AdminMode", "false");
                    SetValue("Settings", "BackgroundWork", "false");
                    SetValue("Settings", "AutoStart", "0");
                    SetValue("Settings","ConsoleHide","false");
                    SetValue("RDR", "Path", "");
                    SetValue("RDR", "RedDead2Btn", "0"); // Changed default value to "0"
                    SetValue("RDR", "LobbyCode", "");
                    SetValue("IGNORE", "First Start", "0");
                    Save(filepath);
                }
                else
                {
                    Load(filepath);
                    bool configChanged = false;

                    // Check and set missing values
                    if (GetValue("Settings", "OfflineMode") == "")
                    {
                        SetValue("Settings", "OfflineMode", "false");

                        configChanged = true;
                    }
                    if (GetValue("Settings", "AdminMode") == "")
                    {
                        SetValue("Settings", "AdminMode", "false");
                        configChanged = true;
                    }
                    if (GetValue("Settings", "BackgroundWork") == "")
                    {
                        SetValue("Settings", "BackgroundWork", "false");
                        configChanged = true;
                    }
                    if (GetValue("RDR", "Path") == "")
                    {
                        SetValue("RDR", "Path", "");
                        configChanged = true;
                    }
                    if (GetValue("RDR", "LobbyCode") == "")
                    {
                        SetValue("RDR", "LobbyCode", "");
                        configChanged = true;
                    }
                    if (GetValue("RDR", "RedDead2Btn") == "")
                    {
                        SetValue("RDR", "RedDead2Btn", "0");
                        configChanged = true;
                    }
                    if (GetValue("Settings", "AutoStart") == "")
                    {
                        SetValue("Settings", "AutoStart", "0");
                        configChanged = true;
                    }
                    if (GetValue("Settings", "ConsoleHide") == "")
                    {
                        SetValue("Settings", "ConsoleHide", "false");
                        configChanged = true;
                    }
                    if (configChanged)
                    {
                        Save(filepath);
                    }
                }
            }
            catch (Exception)
            {
                DialogResult result = ShowYesNoMessageBox("" + rm.GetString("Firsttime", currentCulture), "" + rm.GetString("welcome", currentCulture));

                if (result == DialogResult.Yes)
                {
                    string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    string appFolderPath = Path.Combine(appDataPath, "DovahkiinLounge Group", "xCheats");
                    string configFilePathCC = Path.Combine(appFolderPath, "Config");
                    string configFilePathCC2 = Path.Combine(appFolderPath, "Downloads");
                    string configFilePathCC3 = Path.Combine(appFolderPath, "Dlls");
                    string oldPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DovahkiinLounge Group");
                    Directory.CreateDirectory(configFilePathCC);
                    Directory.CreateDirectory(configFilePathCC2);
                    Directory.CreateDirectory(configFilePathCC3);
                    if (Directory.Exists(oldPath))
                    {
                        try
                        {
                            Directory.Delete(oldPath, true);
                            MessageBox.Show(rm.GetString("oldpath", currentCulture), "Oh Yeah.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {

                        }
                    }

                    RestartApplication();
                }
                else
                {

                    MessageBox.Show(rm.GetString("error", currentCulture), "Oh Noes!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }

                static DialogResult ShowYesNoMessageBox(string message, string caption)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    MessageBoxIcon icon = MessageBoxIcon.Question;

                    message ??= ""; // Wenn message null ist, setze es auf einen leeren String
                    caption ??= ""; // Wenn caption null ist, setze es auf einen leeren String

                    return MessageBox.Show(message, caption, buttons, icon);
                }
            }
        }
        private void RestartApplication()
        {
            try
            {
                
                StopExternalApplication("xCheats Launcher.exe"); // Hier wird die externe Anwendung gestoppt
                Thread.Sleep(1000);
                Application.Restart(); // Hier wird die eigene Anwendung neu gestartet
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error restarting application: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void StopExternalApplication(string processName)
        {
            // Prozess mit dem angegebenen Namen suchen
            Process[] processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(processName));

            // Wenn der Prozess gefunden wurde, beende ihn
            if (processes.Length > 0)
            {
                foreach (Process process in processes)
                {
                    process.Kill();
                    process.WaitForExit(); // Warte bis der Prozess beendet ist
                }
            }
        }
    }
}
