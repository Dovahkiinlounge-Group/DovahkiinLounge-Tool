using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;
using DovahkiinLounge.Functions;
using System.Threading;
using System.Diagnostics.Eventing.Reader;


namespace xCheats.Loader
{
    public partial class RDRO : Form
    {
        static string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        static string appFolderPath = Path.Combine(appDataPath, "DovahkiinLounge Group", "xCheats");
        static string configFilePath = Path.Combine(appFolderPath, "Config\\config.ini");
        IniConfig config = new IniConfig();
        private string JsonFilePath;
        public RDRO()
        {
            InitializeComponent();
            string roamingFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            this.Size = new System.Drawing.Size(287, 220);
            JsonFilePath = Path.Combine(roamingFolderPath + "\\Exodus Client\\", "Credentials.json");
            config.Load(configFilePath);
        }
        private void RDRO_Load(object sender, EventArgs e)
        {

            Pfad.Text = GlobalSettings.SelectedInstallPath;
            // Check if the SelectedInstallPath setting is not empty
            if (!string.IsNullOrEmpty(GlobalSettings.SelectedInstallPath))
            {
                // Disable the button when the path is already set
                //PfadBtn.Enabled = false;
            }
            int buttonModes = GlobalSettings.ButtonMode;

            if (buttonModes == 1)
            {
                // Set button text to "Reset Path"
                PfadBtn.Text = "Reset Path";
            }
            else if (buttonModes == 0)
            {
                // Set button text to "Get Path"
                PfadBtn.Text = "Get Path";
            }

            if (File.Exists(JsonFilePath))
            {
                string jsonContent = File.ReadAllText(JsonFilePath);

                // Deserialize the JSON content into a dynamic object
                dynamic jsonData = JsonConvert.DeserializeObject(jsonContent);

                // Access the 'e' and 'p' values
                string eValue = jsonData.e;
                string pValue = jsonData.p;

                // Write the values to your TextBox
                // Assuming you have a TextBox named textBox1
                Email.Text = $"{eValue}";
                Password.Text = $"{pValue}";

                this.Size = new System.Drawing.Size(572, 220);
            }

            if (!string.IsNullOrEmpty(GlobalSettings.LobbyCode))
            {
               LC.Text = "Last LobbyCode: " + GlobalSettings.LobbyCode;
            }
            else
            {
                LC.Text = "Last LobbyCode: None" + GlobalSettings.LobbyCode;
                LCApply.LinkColor = Color.Red;
            }




        }

        private string GetAndSaveRedDeadRedemption2InstallPath()
        {
            string keyPath = @"SOFTWARE\Wow6432Node\Rockstar Games\Red Dead Redemption 2";

            // Check if the registry key exists before attempting to retrieve its values
            if (Registry.LocalMachine.OpenSubKey(keyPath) != null)
            {
                string installPath = GetValueFromRegistry(keyPath, "InstallFolder");
                string steamInstallPath = GetValueFromRegistry(keyPath, "InstallFolderSteam");

                // Ensure paths do not point to the executable itself
                installPath = CleanPath(installPath);
                steamInstallPath = CleanPath(steamInstallPath);

                // Retrieve the previously selected installation path from application settings
                string savedPath = GlobalSettings.SelectedInstallPath;

                if (!string.IsNullOrEmpty(installPath) && !string.IsNullOrEmpty(steamInstallPath))
                {
                    // Both installation paths exist, prompt the user to select one
                    DialogResult result = MessageBox.Show("Multiple installations detected. Choose one:\n\n" +
                        "1. Rockstar: " + installPath + "\n" +
                        "2. Steam: " + steamInstallPath + "\n\n" +
                        "Select 'Yes' for Rockstar or 'No' for Steam.",
                        "Multiple Installations", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // User selected InstallFolder
                        installPath = savedPath != steamInstallPath ? installPath : null;
                    }
                    else if (result == DialogResult.No)
                    {
                        // User selected InstallFolderSteam
                        installPath = savedPath != installPath ? steamInstallPath : null;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return null; // User canceled the operation
                    }
                }
                else if (!string.IsNullOrEmpty(installPath))
                {
                    // Only InstallFolder exists
                    installPath = savedPath != installPath ? installPath : null;
                }
                else if (!string.IsNullOrEmpty(steamInstallPath))
                {
                    // Only InstallFolderSteam exists
                    installPath = savedPath != steamInstallPath ? steamInstallPath : null;
                }

                // Save the selected installation path in application settings
                GlobalSettings.SelectedInstallPath = installPath;

                // Save the installation path in the application settings
                config.SetValue("RDR", "Path", installPath);
                config.SetValue("RDR", "RedDead2Btn", "1");
                config.Save(configFilePath);
                ReloadForm();
                return installPath;
            }
            else
            {
                // Registry key does not exist
                MessageBox.Show("Registry key not found. The game may not be installed or the registry key is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private string CleanPath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return null;
            }

            // Get the last directory in the path
            string[] directories = path.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
            string lastDirectory = directories.Length > 0 ? directories[directories.Length - 1] : "";

            // Check if the last directory matches the game's name
            string gameName = "Red Dead Redemption 2";

            // Count occurrences of the game name in the path
            int count = 0;
            foreach (string directory in directories)
            {
                if (string.Equals(directory, gameName, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }

            // If game name occurs twice, remove the last directory
            if (count == 2 && string.Equals(lastDirectory, gameName, StringComparison.OrdinalIgnoreCase))
            {
                // Remove the last directory from the path
                path = string.Join(Path.DirectorySeparatorChar.ToString(), directories.Take(directories.Length - 1));
            }

            return path;
        }


        private string GetValueFromRegistry(string keyPath, string valueName)
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyPath))
            {
                if (key != null)
                {
                    return key.GetValue(valueName)?.ToString();
                }
                else
                {
                    // Handle the case where the registry key is not found
                    Console.WriteLine($"Registry key '{keyPath}' not found.");
                    return null;
                }
            }
        }

        private void RDOLCreate_Click(object sender, EventArgs e)
        {
            // Retrieve the installation path

            string installPath = GlobalSettings.SelectedInstallPath;

            if (!string.IsNullOrEmpty(installPath))
            {
                // Create the folder path
                string folderPath = Path.Combine(installPath, "x64", "data");

                // Adjust the folder path to remove the redundant "Red Dead Redemption 2" folder
                string fixedFolderPath = Path.Combine(folderPath, "..", "..", "..");

                // Check if the folder already exists
                if (!Directory.Exists(fixedFolderPath))
                {
                    // Create the folder if it doesn't exist
                    Directory.CreateDirectory(fixedFolderPath);
                }

                // Create the file path
                string filePath = Path.Combine(folderPath, "startup.meta");

                // Define the XML content for the file


                // Get the additional content from a TextBox
                string additionalContent = RDOContent.Text;

                // Append the additional content after the closing tag
                RDROS.Startup = RDROS.Startup.Replace("</CDataFileMgr__ContentsOfDataFileXml>", "</CDataFileMgr__ContentsOfDataFileXml>\n" + "\n" + additionalContent);

                // Create the file and write the content
                File.WriteAllText(filePath, RDROS.Startup);
                // Display a message to indicate successful file creation
                config.SetValue("RDR", "LobbyCode", RDOContent.Text);
                config.Save(configFilePath);
                MessageBox.Show("Meta file created successfully.");
            }
            else
            {
                MessageBox.Show("Unable to retrieve the installation path. Please make sure the path is valid.");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            LoaderMain Main = new LoaderMain();
            this.Close();
        }

        private void ReloadForm()
        {
            Application.Restart();
        }

        private void PfadBtn_Click(object sender, EventArgs e)
        {

            int buttonModes = GlobalSettings.ButtonMode;

            if (buttonModes == 1)
            {
                ResetPath();
            }
            else if (buttonModes == 0)
            {
                GetAndSaveRedDeadRedemption2InstallPath();
            }
        }


        private void ResetPath()
        {
            config.SetValue("RDR", "Path", string.Empty);
            config.SetValue("RDR", "RedDead2Btn", "0");
            config.Save(configFilePath);
            Thread.Sleep(200);
            Application.Restart();
        }

        private void GoPublicBtn_Click(object sender, EventArgs e)
        {
            // Retrieve the installation path
            string installPath = GlobalSettings.SelectedInstallPath;

            if (!string.IsNullOrEmpty(installPath))
            {
                // Create the file path
                string filePath = Path.Combine(installPath, "x64", "data", "startup.meta");

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Delete the file
                    File.Delete(filePath);

                    // Display a message to indicate successful deletion
                    MessageBox.Show("File deleted successfully.");
                }
                else
                {
                    // Display a message if the file doesn't exist
                    MessageBox.Show("The file doesn't exist.");
                }
            }
            else
            {
                // Display an error message if the install path is empty or null
                MessageBox.Show("Unable to retrieve the installation path. Please make sure the path is valid.");
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string eValue = Email.Text;
            string pValue = Password.Text;

            // Create a JSON object with the new values
            dynamic jsonData = new
            {
                e = eValue,
                p = pValue
            };

            try
            {
                // Serialize the JSON object and save it to the file
                string jsonContent = JsonConvert.SerializeObject(jsonData, Formatting.Indented);
                File.WriteAllText(JsonFilePath, jsonContent);

                // Inform the user that the data has been saved
                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (JsonWriterException)
            {
                MessageBox.Show("Error writing data to JSON file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Password_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Password.PasswordChar = Password.PasswordChar == '\0' ? '●' : '\0';
        }

        private void LCApply_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LCApply.LinkColor == Color.Red)
            {

            }
            else
            {
                RDOContent.Text = GlobalSettings.LobbyCode;
                Thread.Sleep(100);
                RDOLCreate.PerformClick(); 
            }
        }
    }
}
