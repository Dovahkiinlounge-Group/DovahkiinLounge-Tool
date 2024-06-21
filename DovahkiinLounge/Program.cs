using System;
using System.Drawing;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;
using x = xCheats.Calls.API;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;
using CC = xCheats.Calls;
using DovahkiinLounge.Functions;
using System.Runtime.CompilerServices;

namespace xCheats
{
    public static class Program
    {

        private static bool minimized;

        public static bool Minimized
        {
            get { return minimized; }
            private set { minimized = value; }
        }

        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                // Customize the console appearance
                Console.WindowHeight = 20;
                Console.WindowWidth = 100;
                Console.ForegroundColor = ConsoleColor.White;
                Console.CursorVisible = false;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Title = $"{CC.Infostrings.PName}";

                // Temporarily set the buffer height to hide the vertical scrollbar
                int originalBufferHeight = Console.BufferHeight;
                Console.BufferHeight = Console.WindowHeight;

                if (args.Length > 0 && args[0] == "-u6sq8#bhysa68@1c0&$")
                {
                    x.startup();
                }
                else
                {
                    Console.WriteLine($"{CC.Infostrings.PName} must be launched from the launcher.");
                    Console.WriteLine($"Please use the launcher to start {CC.Infostrings.PName}.");
                    Console.Read();
                }

                // Restore the original buffer height
                Console.BufferHeight = originalBufferHeight;
            }
            catch (Exception ex)
            {
                // Log the error using your ErrorLog class library
                ErrorLogv2.LogError(ex);
            }
        }

    }
}
