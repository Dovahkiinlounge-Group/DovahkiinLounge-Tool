using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Updater
{
    class Program
    {
        public static string? LocalVersion { get; private set; }
        public static AssemblyLoadContext? Context { get; private set; }

        static async Task Main(string[] args)
        {
            string user = "Dovahkiinlounge-Group";
            string repo = "xCheatsv2";

            // Get the latest version from GitHub releases
            LocalVersion = await GetLatestVersion(user, repo);

            // Get the local version from the registry
            Version localRegistryVersion = GetLocalVersionFromRegistry();
            if (localRegistryVersion != null)
            {
                Console.WriteLine($"Local version from registry: {localRegistryVersion.ToString(3)}");
            }

            // Display the versions
            Console.WriteLine($"Latest xCheats version: {LocalVersion}");

            // Check if an update is available
            if (localRegistryVersion == null || new Version(LocalVersion) > localRegistryVersion)
            {
                Console.WriteLine("Update available. Deleting old files...");

                // Delete all files in the directory
                DeleteFilesInDirectory(AppDomain.CurrentDomain.BaseDirectory);

                Console.WriteLine("Old files deleted. Downloading new version...");

                // Download the latest setup executable
                await DownloadLatestSetup(user, repo, LocalVersion);

                Console.WriteLine("Update downloaded. Running installer...");

                // Run the installer
                RunInstaller(LocalVersion);
            }
            else
            {
                Console.WriteLine("No update available.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); // Wait for user input before closing the console window
        }

        static async Task<string> GetLatestVersion(string user, string repo)
        {
            string releaseUrl = $"https://api.github.com/repos/{user}/{repo}/releases/latest";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(releaseUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                dynamic releaseInfo = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);

                string tagName = ((string)releaseInfo.tag_name).TrimStart('v');
                return tagName;
            }
        }

        static async Task DownloadLatestSetup(string user, string repo, string latestVersion)
        {
            string downloadUrl = $"https://github.com/{user}/{repo}/releases/latest/download/xCheats_{latestVersion}.exe";
            string downloadPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"xCheats_{latestVersion}.exe");

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(downloadUrl))
                {
                    using (Stream stream = await response.Content.ReadAsStreamAsync())
                    {
                        using (FileStream fileStream = new FileStream(downloadPath, FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            await stream.CopyToAsync(fileStream);
                        }
                    }
                }
            }
        }

        static void RunInstaller(string latestVersion)
        {
            string installerPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"xCheats_{latestVersion}.exe");
            Process.Start(installerPath);
        }

        static void DeleteFilesInDirectory(string directory)
        {
            DirectoryInfo di = new DirectoryInfo(directory);
            foreach (FileInfo file in di.GetFiles())
            {
                // Check if the file is one of the updater files or Newtonsoft.Json.dll
                if (file.Name.ToLower() != "updater.exe" &&
                    file.Name.ToLower() != "updater.dll" &&
                    file.Name.ToLower() != "updater.runtimeconfig.json" &&
                    file.Name.ToLower() != "newtonsoft.json.dll")
                {
                    Console.WriteLine($"Deleting file: {file.FullName}");
                    try
                    {
                        file.Delete();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error deleting file: {file.FullName}\n{ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine($"Skipping file: {file.FullName}");
                }
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        static Version GetLocalVersionFromRegistry()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\DovahkiinloungeGroup"))
                {
                    if (key != null)
                    {
                        var value = key.GetValue("Version");
                        if (value != null)
                        {
                            return new Version(value.ToString());
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
    }
}
