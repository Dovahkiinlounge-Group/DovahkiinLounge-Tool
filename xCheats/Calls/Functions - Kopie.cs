using DiscordRPC;
using Button = DiscordRPC.Button;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Net;
using System.Diagnostics;
using AutoUpdaterDotNET;
using System.IO;
using System.Reflection;

namespace xCheats.Calls
{
    internal class API
    {
        [DllImport("Kernel32.dll")]
        static extern Boolean AllocConsole();
        public static DiscordRpcClient client;
        public static void update()
        {
            AutoUpdater.Start("252552552", new NetworkCredential("252522552", "5252525252"));
            AutoUpdater.DownloadPath = Application.StartupPath;
            var currentDirectory = new DirectoryInfo(Application.StartupPath);
            if (currentDirectory.Parent != null)
            {
                AutoUpdater.InstallationPath = currentDirectory.Parent.FullName;
            }
            AutoUpdater.UpdateFormSize = new System.Drawing.Size(800, 600);
            string jsonPath = Path.Combine(Environment.CurrentDirectory, "settings.json");
            AutoUpdater.PersistenceProvider = new JsonFilePersistenceProvider(jsonPath);
        }
        public static void Sleep()
        {
            Thread.Sleep(1000);
        }
        public static void Sleep2()
        {
            Thread.Sleep(4000);
        }
        public static void RPC_Init()
        {
            client = new DiscordRpcClient("971709968787079198");
            client.Initialize();
            Console.WriteLine("Success RPC Active");
            client.SetPresence(new RichPresence()
            {
               Details = ("xCheats Launcher"),
               State = ("Selecting a Cheat"),
               Timestamps = Timestamps.Now,
               Buttons = new Button[]
               {
                  new Button() { Label = "Download(Coming Soon)", Url = "http://weavesilk.com/"}
               }
               
            });
        }
        public static void RPC()
        {
            client.UpdateDetails("xCheats Launcher");
            client.UpdateState("Selecting a Cheat");
        }
        public static void RPC_RE4()
        {
            client.UpdateDetails("Resident Evil 4");
            client.UpdateState("Playing with xCheats");
        }
        public static void RPC_GTAVC()
        {
            client.UpdateDetails("GTA Vice City");
            client.UpdateState("Playing with xCheats");
        }
       //Console
        public static void Start()
        {
            Thread.Sleep(2000);
        }
        public static void Load()
        {
            Thread.Sleep(5000);
        }
        public static void con()
        {
            MySqlConnection connection = new MySqlConnection("SERVER= 52525255; DATABASE=CheatListe; USERNAME=xCheats ;PASSWORD=u84ox@C37;");

            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                Console.WriteLine("Success Connected No Errors Found");
            }
            else
            {
                Console.WriteLine("Connecting Failed");
            }
        }
        public static void Load2()
        {
            Console.Write("Check Database in ");
            for (int a = 60; a >= 0; a--)
            {
                Console.CursorLeft = 22;
                Console.Write("{0} ", a);  
                Thread.Sleep(1000);
            }
            Console.Clear();
            //Thread.Sleep(60000);
        }
        public static void startup()
        {
            Console.WriteLine("Initialize xCheats...");
            Start();
            Console.WriteLine("Connecting To Database");
            Sleep2();
            con();
            Start();
            Console.WriteLine("Initialize Discord RPC...");
            Start();
            RPC_Init();
            Start();
            Console.WriteLine("Loading xCheats...");
            Load();
            Console.WriteLine("Success Open xCheats NOW");
            Application.Run(new Main());
        }
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        public static void hide()
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
            Console.Clear();
        }
    }
}