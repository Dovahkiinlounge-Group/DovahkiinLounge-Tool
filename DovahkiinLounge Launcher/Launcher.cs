using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DovahkiinLounge.Functions;
using Timer = System.Windows.Forms.Timer;

namespace xCheats_Launcher
{
    public partial class Launcher : Form
    {
        private bool isFunction1Active;
        private bool isFunction2Active;
        private bool isFunction3Active;
        private Timer clickTimer;
        private bool isDragging = false;
        private int mouseX, mouseY;
        static string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        static string appFolderPath = Path.Combine(appDataPath, "DovahkiinLounge Group", "xCheats");
        static string configFilePath = Path.Combine(appFolderPath, "Config\\config.ini");
        static string error = Path.Combine(appDataPath, "logs");
        IniConfig config = new IniConfig();
        CultureInfo lang = CultureInfo.CurrentCulture;
        public ComponentResourceManager resources { get; } = new ComponentResourceManager(typeof(Launcher));

        public Launcher()
        {
            var resources = new ComponentResourceManager(typeof(Launcher));
            System.Threading.Thread.Sleep(500);
            config.Check(configFilePath);
            InitializeComponent();
            OffTggl.ForeColor = Color.Red;
            clickTimer = new Timer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += ClickTimer_Tick;
            config.Load(configFilePath);
            bool isOfflineMode = GlobalSettings.IsOfflineMode;
            bool isAdminMode = GlobalSettings.AdminMode;
            bool backgroundMode = GlobalSettings.BackgroundWork;
            AppText.Text = string.Format(resources.GetString("appname", lang));



            if (isOfflineMode && isAdminMode && backgroundMode)
            {
                // Both are true
                isFunction1Active = true;
                isFunction2Active = true;
                isFunction3Active = true;
                OffTggl.Checked = true;
                AdminTggl.Checked = true;
                BGTggl.Checked = true;
                UpdateOfflineLabel(true);
                UpdateAdmin(true);
                UpdateBackground(true);
            }
            else if (!isOfflineMode && !isAdminMode && !backgroundMode)
            {
                // Both are false
                isFunction1Active = false;
                isFunction2Active = false;
                isFunction3Active = false;
                OffTggl.Checked = false;
                AdminTggl.Checked = false;
                BGTggl.Checked = false;
                UpdateAdmin(false);
                UpdateOfflineLabel(false);
                UpdateBackground(false);
            }
            else
            {
                // One is true, the other is false
                isFunction1Active = isOfflineMode;
                isFunction2Active = isAdminMode;
                isFunction3Active = backgroundMode;
                OffTggl.Checked = isOfflineMode;
                AdminTggl.Checked = isAdminMode;
                BGTggl.Checked = backgroundMode;
                UpdateAdmin(isAdminMode);
                UpdateOfflineLabel(isOfflineMode);
                UpdateBackground(backgroundMode);
            }
            this.ShowInTaskbar = true;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - mouseX;
                int deltaY = e.Y - mouseY;

                Location = new System.Drawing.Point(Location.X + deltaX, Location.Y + deltaY);
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            OffTggl.Enabled = true;
            AdminTggl.Enabled = true;
            BGTggl.Enabled = true;
            clickTimer.Stop();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            config.Load(configFilePath);
            string arguments = "-u6sq8#bhysa68@1c0&$";
            string mainAppPath = Path.Combine(Environment.CurrentDirectory, "DovahkiinLounge.exe");

            Process proc = new Process();
            proc.StartInfo.FileName = mainAppPath;
            
            proc.StartInfo.Arguments = arguments;

            try
            {

                if (GlobalSettings.AdminMode) // Check if AdminMode is true and set the Verb accordingly
                {
                    proc.StartInfo.Verb = "runas"; // Indicates that the process should be run as an administrator
                    proc.StartInfo.UseShellExecute = true;
                    proc.Start();// Start the process

                    // Exit the current process if needed
                    Environment.Exit(0);

                }
                else if (!GlobalSettings.AdminMode)
                {
                    // Start the process
                    proc.Start();

                    // Exit the current process if needed
                    Environment.Exit(0);
                }

            }
            catch (Exception ex)
            {
                // Log the error
                ErrorLogv2.LogError(ex, error);
            }
        }



        private void zeroitLollipopButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void OffTggl_Click(object sender, EventArgs e)
        {
            isFunction1Active = !isFunction1Active;
            OffTggl.Enabled = false;
            clickTimer.Start();
            OffTggl.Checked = isFunction1Active;
            UpdateOfflineLabel(OffTggl.Checked);
            config.SetValue("Settings", "OfflineMode", OffTggl.Checked.ToString().ToLower());
            config.Save(configFilePath);
        }

        private void AdminTggl_Click(object sender, EventArgs e)
        {
            isFunction2Active = !isFunction2Active;
            AdminTggl.Enabled = false;
            clickTimer.Start();
            AdminTggl.Checked = isFunction2Active;
            UpdateAdmin(AdminTggl.Checked);
            config.SetValue("Settings", "AdminMode", AdminTggl.Checked.ToString().ToLower());
            config.Save(configFilePath);
        }

        private void UpdateOfflineLabel(bool isOfflineMode)
        {
            if (isOfflineMode)
            {
                OffTggl.Text = string.Format(resources.GetString("inetoff", lang));
                OffTggl.ForeColor = Color.Red;
            }
            else
            {
                OffTggl.Text = string.Format(resources.GetString("ineton", lang));
                OffTggl.ForeColor = Color.Green;
            }
        }

        private void BGTggl_Click(object sender, EventArgs e)
        {
            BGTggl.Enabled = false;
            isFunction3Active = !isFunction3Active;
            clickTimer.Start();
            BGTggl.Checked = isFunction3Active;
            UpdateBackground(BGTggl.Checked);
            config.SetValue("Settings", "BackgroundWork", BGTggl.Checked.ToString().ToLower());
            config.Save(configFilePath);
        }

        private void UpdateAdmin(bool isAdminMode)
        {
            if (isAdminMode)
            {

                AdminTggl.Text = string.Format(resources.GetString("admintggltxton", lang));
                StartBtn.Text = string.Format(resources.GetString("startbtn1", lang));
                AdminTggl.ForeColor = Color.Green;
            }
            else
            {
                AdminTggl.Text = string.Format(resources.GetString("admintggltxtoff", lang));
                StartBtn.Text = string.Format(resources.GetString("startbtn2", lang));
                AdminTggl.ForeColor = Color.Red;
            }
        }

        private void UpdateBackground(bool backgroundMode)
        {
            if (backgroundMode)
            {

                BGTggl.Text = string.Format(resources.GetString("backgroundworkeron", lang));
                BGTggl.ForeColor = Color.Green;
            }
            else
            {
                BGTggl.Text = string.Format(resources.GetString("backgroundworkeroff", lang));
                BGTggl.ForeColor = Color.Red;
            }
        }
    }
}
