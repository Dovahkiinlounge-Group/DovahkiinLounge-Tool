
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Win32;
using System.Reflection;
using DovahkiinLounge.Functions;
using System.Configuration;

namespace xCheats.Calls
{
    public class API
    {
        [DllImport("Kernel32.dll")]
        static extern Boolean AllocConsole();
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        public static void Sleep()
        {
            Thread.Sleep(1000);
        }

        public static void startup()
        {
            Console.WriteLine("Initializing xCheats...");

            if (GS.IsOfflineMode)
            {
                Console.WriteLine("Connection: Disabled in Settings");
                Thread.Sleep(2000);
                Console.WriteLine("Checking Version: Disabled in Settings");
                Thread.Sleep(2000);
                Console.WriteLine("Starting xCheats...");
                Thread.Sleep(2000);
                Application.Run(new LoaderMain());
            }
            else
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);

                Thread.Sleep(500);
                Console.WriteLine("Checking Connection...");
                Thread.Sleep(1000);
                WriteColoredLine($"Connection: {(reply.Status == IPStatus.Success ? "Established" : "Not Established")}", reply.Status == IPStatus.Success);
                Thread.Sleep(500);
                Console.WriteLine("Checking Administrator Privileges...");
                Thread.Sleep(1000);
                WriteColoredLine($"Administrator Privileges: {(GS.AdminMode ? "Enabled" : "Disabled")}", GS.AdminMode);
                Thread.Sleep(500);
                Console.WriteLine("Checking Offline Mode...");
                Thread.Sleep(1000);
                WriteColoredLine($"Offline Mode: {(GS.IsOfflineMode ? "Enabled" : "Disabled")}", GS.IsOfflineMode);
                Thread.Sleep(500);
                Console.WriteLine("Checking Autostart Setting...");
                Thread.Sleep(1000);
                WriteColoredLine($"Autostart Setting: {(GS.AutostartMode != 0 ? "Enabled" : "Disabled")}", GS.AutostartMode != 0);
                Thread.Sleep(500);
                Console.WriteLine("Checking Console Hide Function...");
                Thread.Sleep(1000);
                WriteColoredLine($"Console Hide Function: {(GS.ConsoleHideFunction ? "Enabled" : "Disabled")}", GS.ConsoleHideFunction);
                Thread.Sleep(500);
                Console.WriteLine("Checking Stored LobbyCode for RDO...");
                Thread.Sleep(1000);
                WriteColoredLine($"Stored LobbyCode for RDO: {(string.IsNullOrEmpty(GS.LobbyCode) ? "Not Found" : GS.LobbyCode)}", !string.IsNullOrEmpty(GS.LobbyCode));
                Thread.Sleep(500);
                Console.WriteLine("Checking RDR install Path...");
                Thread.Sleep(1000);
                WriteColoredLine($"RDR install Path: {(string.IsNullOrEmpty(GS.SelectedInstallPath) ? "Not Found" : GS.SelectedInstallPath)}", !string.IsNullOrEmpty(GS.SelectedInstallPath));
                Thread.Sleep(500);
                Console.WriteLine("Starting xCheats...");
                Thread.Sleep(1000);
                Application.Run(new LoaderMain());
            }
        }

        private static void WriteColoredLine(string message, bool condition)
        {
            int colonIndex = message.IndexOf(':');
            if (colonIndex != -1)
            {
                string prefix = message.Substring(0, colonIndex + 1);
                string status = message.Substring(colonIndex + 1).Trim();

                Console.Write(prefix + " ");
                Console.ForegroundColor = condition ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine(status);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(message);
            }
        }

        public static void CleanTempFolder(string folderPath)
        {
            try
            {
                DirectoryInfo tempDir = new DirectoryInfo(folderPath);

                foreach (FileInfo file in tempDir.GetFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch (Exception)
                    {
                        // Handle exceptions if needed
                    }
                }

                foreach (DirectoryInfo dir in tempDir.GetDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch (Exception)
                    {
                        // Handle exceptions if needed
                    }
                }

                // Optionally, you can indicate the completion of the operation here.
            }
            catch (Exception)
            {
                // Handle exceptions if needed
            }
        }
        public static void hide()
        {

            if (GlobalSettings.ConsoleHideFunction)
            {
                var handle = GetConsoleWindow();
                ShowWindow(handle, SW_HIDE);
                Console.Clear();
            }
            else
            {

            }
        }
    }

}