using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Updater
{
    class Program
    {
        private const string ApiUrl = "http://localhost:5000/api/version/check"; // Your API URL

        static async Task Main(string[] args)
        {
            try
            {
                // Check for updates
                await CheckForUpdateAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static async Task CheckForUpdateAsync()
        {
            try
            {
                // Retrieve the current version from the registry
                string currentVersion = GetCurrentVersionFromRegistry();
                if (string.IsNullOrEmpty(currentVersion))
                {
                    Console.WriteLine("Failed to retrieve current version from registry.");
                    return;
                }

                using (HttpClient client = new HttpClient())
                {
                    var requestBody = new { CurrentVersion = currentVersion };
                    var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(ApiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseBody = await response.Content.ReadAsStringAsync();
                        dynamic result = JsonConvert.DeserializeObject(responseBody);

                        if (result.updateAvailable == true)
                        {
                            Console.WriteLine($"Update available! Latest version is {result.latestVersion}. You have {currentVersion}.");
                            Console.WriteLine("Downloading the latest version...");
                            // Ensure result.downloadUrl is a string
                            string downloadUrl = (string)result.downloadUrl;
                            await DownloadLatestSetup(downloadUrl);
                            Console.WriteLine("Update downloaded. Running installer...");
                            RunInstaller();
                        }
                        else
                        {
                            Console.WriteLine("You are already using the latest version.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Failed to check for updates. Status Code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while checking for updates: {ex.Message}");
            }
        }

        private static string GetCurrentVersionFromRegistry()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Dovahkiinlounge Group"))
                {
                    if (key != null)
                    {
                        var value = key.GetValue("Version");
                        if (value != null)
                        {
                            return value.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading registry: {ex.Message}");
            }
            return null;
        }

        private static async Task DownloadLatestSetup(string downloadUrl)
        {
            string downloadPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DovahkiinLounge.exe");

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(downloadUrl))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (Stream stream = await response.Content.ReadAsStreamAsync())
                        {
                            using (FileStream fileStream = new FileStream(downloadPath, FileMode.Create, FileAccess.Write, FileShare.None))
                            {
                                await stream.CopyToAsync(fileStream);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Failed to download the update. Status Code: {response.StatusCode}");
                    }
                }
            }
        }

        private static void RunInstaller()
        {
            string installerPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DovahkiinLounge.exe");
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = installerPath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to start the installer: {ex.Message}");
            }
        }
    }
}
