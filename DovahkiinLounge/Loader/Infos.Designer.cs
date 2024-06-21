namespace xCheats.Loader
{
    partial class Infos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Infos));
            ExitBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            DeviceInfo = new Siticone.Desktop.UI.WinForms.SiticoneDeviceInfo(components);
            BorderInfo = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(components);
            TaskPRogress = new Siticone.Desktop.UI.WinForms.SiticoneTaskBarProgress(components);
            FolderDial = new FolderBrowserDialog();
            Automation = new System.ComponentModel.BackgroundWorker();
            Credits = new TabPage();
            DevBDGA = new Label();
            DevBDGC = new Label();
            GLName2 = new Label();
            GLName = new Label();
            label4 = new Label();
            DCName2 = new Label();
            DCAV2 = new PictureBox();
            DCName = new Label();
            DCAV1 = new PictureBox();
            Settings = new TabPage();
            AutoStartBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            WS = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            ConsoleHideBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            inittxt = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            KBListener = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            HotkeyTxT = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            FixTool = new TabPage();
            RemoveRT = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            RemoveGWLD = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            StateUpd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            RemovePatch = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            RuntimesText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            RunTimeDwn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            PatchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            PatchDwn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            DwnBar = new Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar();
            GamesWinLiveText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            GamesWinLiveDwn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            About = new TabPage();
            Repo2 = new LinkLabel();
            CPUStat = new Label();
            MBoard = new Label();
            CPU = new Label();
            GPU = new Label();
            TestLabel = new Label();
            ConInfo = new Label();
            StatusInfo = new Label();
            AppVer = new Label();
            DCCopyTag = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            Credits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DCAV2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DCAV1).BeginInit();
            Settings.SuspendLayout();
            FixTool.SuspendLayout();
            About.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).BeginInit();
            siticoneTabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // ExitBtn
            // 
            ExitBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitBtn.Animated = true;
            ExitBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            ExitBtn.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            ExitBtn.FillColor = Color.Red;
            ExitBtn.IconColor = Color.Black;
            ExitBtn.Location = new Point(854, 6);
            ExitBtn.Margin = new Padding(4, 3, 4, 3);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(52, 23);
            ExitBtn.TabIndex = 2;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // BorderInfo
            // 
            BorderInfo.AnimateWindow = true;
            BorderInfo.AnimationType = Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
            BorderInfo.ContainerControl = this;
            BorderInfo.DockIndicatorTransparencyValue = 0.6D;
            BorderInfo.DragStartTransparencyValue = 0.5D;
            BorderInfo.ResizeForm = false;
            BorderInfo.TransparentWhileDrag = true;
            // 
            // TaskPRogress
            // 
            TaskPRogress.TargetForm = null;
            // 
            // FolderDial
            // 
            FolderDial.Description = "Select a exclusion for Windows Defender";
            FolderDial.RootFolder = Environment.SpecialFolder.MyComputer;
            FolderDial.ShowNewFolderButton = false;
            // 
            // Automation
            // 
            Automation.DoWork += Automation_DoWork;
            // 
            // Credits
            // 
            Credits.BackColor = Color.Black;
            Credits.Controls.Add(DevBDGA);
            Credits.Controls.Add(DevBDGC);
            Credits.Controls.Add(GLName2);
            Credits.Controls.Add(GLName);
            Credits.Controls.Add(label4);
            Credits.Controls.Add(DCName2);
            Credits.Controls.Add(DCAV2);
            Credits.Controls.Add(DCName);
            Credits.Controls.Add(DCAV1);
            Credits.Location = new Point(4, 44);
            Credits.Margin = new Padding(4, 3, 4, 3);
            Credits.Name = "Credits";
            Credits.Size = new Size(906, 458);
            Credits.TabIndex = 7;
            Credits.Text = "Credits";
            // 
            // DevBDGA
            // 
            DevBDGA.Enabled = false;
            DevBDGA.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DevBDGA.ForeColor = Color.Magenta;
            DevBDGA.Location = new Point(172, 268);
            DevBDGA.Margin = new Padding(4, 0, 4, 0);
            DevBDGA.Name = "DevBDGA";
            DevBDGA.RightToLeft = RightToLeft.No;
            DevBDGA.Size = new Size(242, 23);
            DevBDGA.TabIndex = 48;
            DevBDGA.Text = "API Service:";
            DevBDGA.Visible = false;
            // 
            // DevBDGC
            // 
            DevBDGC.Enabled = false;
            DevBDGC.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DevBDGC.ForeColor = Color.Magenta;
            DevBDGC.Location = new Point(172, 80);
            DevBDGC.Margin = new Padding(4, 0, 4, 0);
            DevBDGC.Name = "DevBDGC";
            DevBDGC.RightToLeft = RightToLeft.No;
            DevBDGC.Size = new Size(242, 23);
            DevBDGC.TabIndex = 47;
            DevBDGC.Text = "Core System Development:";
            DevBDGC.Visible = false;
            // 
            // GLName2
            // 
            GLName2.Enabled = false;
            GLName2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            GLName2.ForeColor = Color.White;
            GLName2.Location = new Point(172, 317);
            GLName2.Margin = new Padding(4, 0, 4, 0);
            GLName2.Name = "GLName2";
            GLName2.RightToLeft = RightToLeft.No;
            GLName2.Size = new Size(237, 25);
            GLName2.TabIndex = 46;
            GLName2.Text = "Name: ";
            GLName2.Visible = false;
            // 
            // GLName
            // 
            GLName.Enabled = false;
            GLName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            GLName.ForeColor = Color.White;
            GLName.Location = new Point(172, 129);
            GLName.Margin = new Padding(4, 0, 4, 0);
            GLName.Name = "GLName";
            GLName.RightToLeft = RightToLeft.No;
            GLName.Size = new Size(237, 23);
            GLName.TabIndex = 45;
            GLName.Text = "Name: ";
            GLName.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(9, 16);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 39;
            label4.Text = "Developed By:";
            // 
            // DCName2
            // 
            DCName2.Enabled = false;
            DCName2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            DCName2.ForeColor = Color.White;
            DCName2.Location = new Point(172, 342);
            DCName2.Margin = new Padding(4, 0, 4, 0);
            DCName2.Name = "DCName2";
            DCName2.Size = new Size(237, 28);
            DCName2.TabIndex = 38;
            DCName2.Text = "Discord-Name: ???";
            DCName2.Visible = false;
            // 
            // DCAV2
            // 
            DCAV2.BackgroundImageLayout = ImageLayout.Stretch;
            DCAV2.BorderStyle = BorderStyle.FixedSingle;
            DCAV2.Enabled = false;
            DCAV2.ErrorImage = null;
            DCAV2.InitialImage = null;
            DCAV2.Location = new Point(9, 241);
            DCAV2.Margin = new Padding(4, 3, 4, 3);
            DCAV2.Name = "DCAV2";
            DCAV2.Size = new Size(155, 150);
            DCAV2.SizeMode = PictureBoxSizeMode.StretchImage;
            DCAV2.TabIndex = 37;
            DCAV2.TabStop = false;
            DCAV2.Visible = false;
            // 
            // DCName
            // 
            DCName.Enabled = false;
            DCName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DCName.ForeColor = Color.White;
            DCName.Location = new Point(172, 152);
            DCName.Margin = new Padding(4, 0, 4, 0);
            DCName.Name = "DCName";
            DCName.RightToLeft = RightToLeft.No;
            DCName.Size = new Size(237, 28);
            DCName.TabIndex = 36;
            DCName.Text = "Discord-Name:";
            DCName.Visible = false;
            // 
            // DCAV1
            // 
            DCAV1.BackgroundImageLayout = ImageLayout.Stretch;
            DCAV1.BorderStyle = BorderStyle.FixedSingle;
            DCAV1.Enabled = false;
            DCAV1.ErrorImage = null;
            DCAV1.InitialImage = null;
            DCAV1.Location = new Point(9, 53);
            DCAV1.Margin = new Padding(4, 3, 4, 3);
            DCAV1.Name = "DCAV1";
            DCAV1.Size = new Size(155, 150);
            DCAV1.SizeMode = PictureBoxSizeMode.StretchImage;
            DCAV1.TabIndex = 35;
            DCAV1.TabStop = false;
            DCAV1.Visible = false;
            // 
            // Settings
            // 
            Settings.BackColor = Color.Black;
            Settings.Controls.Add(AutoStartBtn);
            Settings.Controls.Add(WS);
            Settings.Controls.Add(ConsoleHideBox);
            Settings.Controls.Add(inittxt);
            Settings.Controls.Add(KBListener);
            Settings.Controls.Add(HotkeyTxT);
            Settings.Location = new Point(4, 44);
            Settings.Margin = new Padding(4, 3, 4, 3);
            Settings.Name = "Settings";
            Settings.Size = new Size(906, 458);
            Settings.TabIndex = 6;
            Settings.Text = "Settings";
            // 
            // AutoStartBtn
            // 
            AutoStartBtn.DisabledState.BorderColor = Color.DarkGray;
            AutoStartBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            AutoStartBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AutoStartBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            AutoStartBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AutoStartBtn.Font = new Font("Segoe UI", 9F);
            AutoStartBtn.ForeColor = Color.White;
            AutoStartBtn.Location = new Point(0, 145);
            AutoStartBtn.Margin = new Padding(4, 3, 4, 3);
            AutoStartBtn.Name = "AutoStartBtn";
            AutoStartBtn.Size = new Size(233, 39);
            AutoStartBtn.TabIndex = 30;
            AutoStartBtn.Text = "Install Autostart";
            AutoStartBtn.Click += ToggleButton_Click;
            // 
            // WS
            // 
            WS.Cursor = Cursors.IBeam;
            WS.DefaultText = "Set Autostart\r\n";
            WS.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            WS.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            WS.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            WS.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            WS.FillColor = Color.Black;
            WS.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            WS.Font = new Font("Segoe UI", 9F);
            WS.ForeColor = Color.Fuchsia;
            WS.HideSelection = false;
            WS.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            WS.Location = new Point(0, 113);
            WS.Margin = new Padding(4, 3, 4, 3);
            WS.Multiline = true;
            WS.Name = "WS";
            WS.PasswordChar = '\0';
            WS.PlaceholderText = "";
            WS.ReadOnly = true;
            WS.SelectedText = "";
            WS.Size = new Size(233, 72);
            WS.TabIndex = 29;
            // 
            // ConsoleHideBox
            // 
            ConsoleHideBox.AutoSize = true;
            ConsoleHideBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            ConsoleHideBox.CheckedState.BorderRadius = 0;
            ConsoleHideBox.CheckedState.BorderThickness = 0;
            ConsoleHideBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            ConsoleHideBox.ForeColor = Color.Magenta;
            ConsoleHideBox.Location = new Point(245, 83);
            ConsoleHideBox.Margin = new Padding(4, 3, 4, 3);
            ConsoleHideBox.Name = "ConsoleHideBox";
            ConsoleHideBox.Size = new Size(142, 19);
            ConsoleHideBox.TabIndex = 3;
            ConsoleHideBox.Text = "Disable Hide Function";
            ConsoleHideBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            ConsoleHideBox.UncheckedState.BorderRadius = 0;
            ConsoleHideBox.UncheckedState.BorderThickness = 0;
            ConsoleHideBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // inittxt
            // 
            inittxt.Cursor = Cursors.IBeam;
            inittxt.DefaultText = "Disable the Console Hide Function after Initialize";
            inittxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            inittxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            inittxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            inittxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            inittxt.FillColor = Color.Black;
            inittxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            inittxt.Font = new Font("Segoe UI", 9F);
            inittxt.ForeColor = Color.Fuchsia;
            inittxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            inittxt.Location = new Point(240, 0);
            inittxt.Margin = new Padding(4, 3, 4, 3);
            inittxt.Multiline = true;
            inittxt.Name = "inittxt";
            inittxt.PasswordChar = '\0';
            inittxt.PlaceholderText = "";
            inittxt.ReadOnly = true;
            inittxt.SelectedText = "";
            inittxt.Size = new Size(233, 107);
            inittxt.TabIndex = 4;
            // 
            // KBListener
            // 
            KBListener.AutoSize = true;
            KBListener.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            KBListener.CheckedState.BorderRadius = 0;
            KBListener.CheckedState.BorderThickness = 0;
            KBListener.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            KBListener.ForeColor = Color.Magenta;
            KBListener.Location = new Point(6, 82);
            KBListener.Margin = new Padding(4, 3, 4, 3);
            KBListener.Name = "KBListener";
            KBListener.Size = new Size(120, 19);
            KBListener.TabIndex = 1;
            KBListener.Text = "Keyboard Listener";
            KBListener.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            KBListener.UncheckedState.BorderRadius = 0;
            KBListener.UncheckedState.BorderThickness = 0;
            KBListener.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // HotkeyTxT
            // 
            HotkeyTxT.Cursor = Cursors.IBeam;
            HotkeyTxT.DefaultText = "Activate the Hotkey Function";
            HotkeyTxT.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            HotkeyTxT.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            HotkeyTxT.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            HotkeyTxT.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            HotkeyTxT.FillColor = Color.Black;
            HotkeyTxT.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            HotkeyTxT.Font = new Font("Segoe UI", 9F);
            HotkeyTxT.ForeColor = Color.Fuchsia;
            HotkeyTxT.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            HotkeyTxT.Location = new Point(0, 0);
            HotkeyTxT.Margin = new Padding(4, 3, 4, 3);
            HotkeyTxT.Multiline = true;
            HotkeyTxT.Name = "HotkeyTxT";
            HotkeyTxT.PasswordChar = '\0';
            HotkeyTxT.PlaceholderText = "";
            HotkeyTxT.ReadOnly = true;
            HotkeyTxT.SelectedText = "";
            HotkeyTxT.Size = new Size(233, 106);
            HotkeyTxT.TabIndex = 2;
            // 
            // FixTool
            // 
            FixTool.BackColor = Color.Black;
            FixTool.Controls.Add(RemoveRT);
            FixTool.Controls.Add(RemoveGWLD);
            FixTool.Controls.Add(StateUpd);
            FixTool.Controls.Add(RemovePatch);
            FixTool.Controls.Add(RuntimesText);
            FixTool.Controls.Add(RunTimeDwn);
            FixTool.Controls.Add(PatchText);
            FixTool.Controls.Add(PatchDwn);
            FixTool.Controls.Add(DwnBar);
            FixTool.Controls.Add(GamesWinLiveText);
            FixTool.Controls.Add(GamesWinLiveDwn);
            FixTool.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FixTool.Location = new Point(4, 44);
            FixTool.Margin = new Padding(4, 3, 4, 3);
            FixTool.Name = "FixTool";
            FixTool.Size = new Size(906, 458);
            FixTool.TabIndex = 5;
            FixTool.Text = "Fix Tools";
            FixTool.Click += FixTool_Click;
            // 
            // RemoveRT
            // 
            RemoveRT.DisabledState.BorderColor = Color.DarkGray;
            RemoveRT.DisabledState.CustomBorderColor = Color.DarkGray;
            RemoveRT.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            RemoveRT.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            RemoveRT.FillColor = Color.Black;
            RemoveRT.Font = new Font("Segoe UI", 9F);
            RemoveRT.ForeColor = Color.White;
            RemoveRT.HoverState.ForeColor = Color.Magenta;
            RemoveRT.Location = new Point(490, 210);
            RemoveRT.Margin = new Padding(4, 3, 4, 3);
            RemoveRT.Name = "RemoveRT";
            RemoveRT.Size = new Size(233, 27);
            RemoveRT.TabIndex = 12;
            RemoveRT.Text = "Remove";
            RemoveRT.Click += RemoveRT_Click;
            // 
            // RemoveGWLD
            // 
            RemoveGWLD.DisabledState.BorderColor = Color.DarkGray;
            RemoveGWLD.DisabledState.CustomBorderColor = Color.DarkGray;
            RemoveGWLD.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            RemoveGWLD.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            RemoveGWLD.FillColor = Color.Black;
            RemoveGWLD.Font = new Font("Segoe UI", 9F);
            RemoveGWLD.ForeColor = Color.White;
            RemoveGWLD.HoverState.ForeColor = Color.Magenta;
            RemoveGWLD.Location = new Point(9, 210);
            RemoveGWLD.Margin = new Padding(4, 3, 4, 3);
            RemoveGWLD.Name = "RemoveGWLD";
            RemoveGWLD.Size = new Size(233, 27);
            RemoveGWLD.TabIndex = 11;
            RemoveGWLD.Text = "Remove";
            RemoveGWLD.Visible = false;
            RemoveGWLD.Click += RemoveGWLD_Click;
            // 
            // StateUpd
            // 
            StateUpd.DisabledState.BorderColor = Color.DarkGray;
            StateUpd.DisabledState.CustomBorderColor = Color.DarkGray;
            StateUpd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            StateUpd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            StateUpd.FillColor = Color.Black;
            StateUpd.Font = new Font("Segoe UI", 9F);
            StateUpd.ForeColor = Color.White;
            StateUpd.HoverState.ForeColor = Color.Magenta;
            StateUpd.Location = new Point(765, 403);
            StateUpd.Margin = new Padding(4, 3, 4, 3);
            StateUpd.Name = "StateUpd";
            StateUpd.Size = new Size(130, 44);
            StateUpd.TabIndex = 10;
            StateUpd.Text = "Update State";
            StateUpd.Click += StateUpd_Click;
            // 
            // RemovePatch
            // 
            RemovePatch.DisabledState.BorderColor = Color.DarkGray;
            RemovePatch.DisabledState.CustomBorderColor = Color.DarkGray;
            RemovePatch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            RemovePatch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            RemovePatch.FillColor = Color.Black;
            RemovePatch.Font = new Font("Segoe UI", 9F);
            RemovePatch.ForeColor = Color.White;
            RemovePatch.HoverState.ForeColor = Color.Magenta;
            RemovePatch.Location = new Point(250, 210);
            RemovePatch.Margin = new Padding(4, 3, 4, 3);
            RemovePatch.Name = "RemovePatch";
            RemovePatch.Size = new Size(233, 27);
            RemovePatch.TabIndex = 9;
            RemovePatch.Text = "Remove";
            RemovePatch.Visible = false;
            RemovePatch.Click += RemovePatch_Click;
            // 
            // RuntimesText
            // 
            RuntimesText.Cursor = Cursors.IBeam;
            RuntimesText.DefaultText = "This install all Runtimes from Windows ";
            RuntimesText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            RuntimesText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            RuntimesText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            RuntimesText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            RuntimesText.FillColor = Color.Black;
            RuntimesText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            RuntimesText.Font = new Font("Segoe UI", 9F);
            RuntimesText.ForeColor = Color.Fuchsia;
            RuntimesText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            RuntimesText.Location = new Point(490, 14);
            RuntimesText.Margin = new Padding(4, 3, 4, 3);
            RuntimesText.Multiline = true;
            RuntimesText.Name = "RuntimesText";
            RuntimesText.PasswordChar = '\0';
            RuntimesText.PlaceholderText = "";
            RuntimesText.ReadOnly = true;
            RuntimesText.SelectedText = "";
            RuntimesText.Size = new Size(233, 156);
            RuntimesText.TabIndex = 7;
            // 
            // RunTimeDwn
            // 
            RunTimeDwn.DisabledState.BorderColor = Color.DarkGray;
            RunTimeDwn.DisabledState.CustomBorderColor = Color.DarkGray;
            RunTimeDwn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            RunTimeDwn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            RunTimeDwn.FillColor = Color.Black;
            RunTimeDwn.Font = new Font("Segoe UI", 9F);
            RunTimeDwn.ForeColor = Color.White;
            RunTimeDwn.HoverState.ForeColor = Color.Magenta;
            RunTimeDwn.Location = new Point(490, 177);
            RunTimeDwn.Margin = new Padding(4, 3, 4, 3);
            RunTimeDwn.Name = "RunTimeDwn";
            RunTimeDwn.Size = new Size(233, 27);
            RunTimeDwn.TabIndex = 6;
            RunTimeDwn.Text = "Download";
            RunTimeDwn.Click += RunTimeDwn_Click;
            // 
            // PatchText
            // 
            PatchText.Cursor = Cursors.IBeam;
            PatchText.DefaultText = "This is a Patcher for 32Bit old games to Patch that 4GB for 64Bit";
            PatchText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PatchText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PatchText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PatchText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PatchText.FillColor = Color.Black;
            PatchText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PatchText.Font = new Font("Segoe UI", 9F);
            PatchText.ForeColor = Color.Fuchsia;
            PatchText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PatchText.Location = new Point(250, 14);
            PatchText.Margin = new Padding(4, 3, 4, 3);
            PatchText.Multiline = true;
            PatchText.Name = "PatchText";
            PatchText.PasswordChar = '\0';
            PatchText.PlaceholderText = "";
            PatchText.ReadOnly = true;
            PatchText.SelectedText = "";
            PatchText.Size = new Size(233, 156);
            PatchText.TabIndex = 5;
            // 
            // PatchDwn
            // 
            PatchDwn.DisabledState.BorderColor = Color.DarkGray;
            PatchDwn.DisabledState.CustomBorderColor = Color.DarkGray;
            PatchDwn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            PatchDwn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            PatchDwn.FillColor = Color.Black;
            PatchDwn.Font = new Font("Segoe UI", 9F);
            PatchDwn.ForeColor = Color.White;
            PatchDwn.HoverState.ForeColor = Color.Magenta;
            PatchDwn.Location = new Point(250, 177);
            PatchDwn.Margin = new Padding(4, 3, 4, 3);
            PatchDwn.Name = "PatchDwn";
            PatchDwn.Size = new Size(233, 27);
            PatchDwn.TabIndex = 4;
            PatchDwn.Text = "Download";
            PatchDwn.Click += PatchDwn_Click;
            // 
            // DwnBar
            // 
            DwnBar.Animated = true;
            DwnBar.BackColor = Color.Transparent;
            DwnBar.Backwards = true;
            DwnBar.FillColor = Color.FromArgb(200, 213, 218, 223);
            DwnBar.FillThickness = 12;
            DwnBar.Font = new Font("Segoe UI", 12F);
            DwnBar.ForeColor = Color.Magenta;
            DwnBar.Location = new Point(765, 3);
            DwnBar.Margin = new Padding(4, 3, 4, 3);
            DwnBar.Minimum = 0;
            DwnBar.Name = "DwnBar";
            DwnBar.ProgressThickness = 12;
            DwnBar.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            DwnBar.ShowText = true;
            DwnBar.Size = new Size(108, 108);
            DwnBar.TabIndex = 3;
            DwnBar.Text = "TestProgress";
            DwnBar.Visible = false;
            // 
            // GamesWinLiveText
            // 
            GamesWinLiveText.Cursor = Cursors.IBeam;
            GamesWinLiveText.DefaultText = "Games For Windows Live Service is disabled by Microsoft here u can download the offline setup to start Games that needed This\r\n";
            GamesWinLiveText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            GamesWinLiveText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            GamesWinLiveText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            GamesWinLiveText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            GamesWinLiveText.FillColor = Color.Black;
            GamesWinLiveText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            GamesWinLiveText.Font = new Font("Segoe UI", 9F);
            GamesWinLiveText.ForeColor = Color.Fuchsia;
            GamesWinLiveText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            GamesWinLiveText.Location = new Point(9, 14);
            GamesWinLiveText.Margin = new Padding(4, 3, 4, 3);
            GamesWinLiveText.Multiline = true;
            GamesWinLiveText.Name = "GamesWinLiveText";
            GamesWinLiveText.PasswordChar = '\0';
            GamesWinLiveText.PlaceholderText = "";
            GamesWinLiveText.ReadOnly = true;
            GamesWinLiveText.SelectedText = "";
            GamesWinLiveText.Size = new Size(233, 156);
            GamesWinLiveText.TabIndex = 1;
            // 
            // GamesWinLiveDwn
            // 
            GamesWinLiveDwn.DisabledState.BorderColor = Color.DarkGray;
            GamesWinLiveDwn.DisabledState.CustomBorderColor = Color.DarkGray;
            GamesWinLiveDwn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            GamesWinLiveDwn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            GamesWinLiveDwn.FillColor = Color.Black;
            GamesWinLiveDwn.Font = new Font("Segoe UI", 9F);
            GamesWinLiveDwn.ForeColor = Color.White;
            GamesWinLiveDwn.HoverState.ForeColor = Color.Magenta;
            GamesWinLiveDwn.Location = new Point(9, 177);
            GamesWinLiveDwn.Margin = new Padding(4, 3, 4, 3);
            GamesWinLiveDwn.Name = "GamesWinLiveDwn";
            GamesWinLiveDwn.Size = new Size(233, 27);
            GamesWinLiveDwn.TabIndex = 0;
            GamesWinLiveDwn.Text = "Download";
            GamesWinLiveDwn.Click += GamesWinLiveDwn_Click;
            // 
            // About
            // 
            About.BackColor = Color.Black;
            About.Controls.Add(Repo2);
            About.Controls.Add(CPUStat);
            About.Controls.Add(MBoard);
            About.Controls.Add(CPU);
            About.Controls.Add(GPU);
            About.Controls.Add(TestLabel);
            About.Controls.Add(ConInfo);
            About.Controls.Add(StatusInfo);
            About.Controls.Add(AppVer);
            About.Controls.Add(DCCopyTag);
            About.Controls.Add(linkLabel1);
            About.Controls.Add(label2);
            About.Controls.Add(label1);
            About.Controls.Add(siticonePictureBox1);
            About.Location = new Point(4, 44);
            About.Margin = new Padding(4, 3, 4, 3);
            About.Name = "About";
            About.Padding = new Padding(4, 3, 4, 3);
            About.Size = new Size(906, 458);
            About.TabIndex = 4;
            About.Text = "About";
            // 
            // Repo2
            // 
            Repo2.AutoSize = true;
            Repo2.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Repo2.LinkColor = Color.Magenta;
            Repo2.Location = new Point(659, 429);
            Repo2.Margin = new Padding(4, 0, 4, 0);
            Repo2.Name = "Repo2";
            Repo2.Size = new Size(243, 22);
            Repo2.TabIndex = 42;
            Repo2.TabStop = true;
            Repo2.Text = " Click Here For GitHub Repo";
            Repo2.Click += GithubRepo_Click;
            // 
            // CPUStat
            // 
            CPUStat.AutoSize = true;
            CPUStat.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold);
            CPUStat.ForeColor = Color.Fuchsia;
            CPUStat.Location = new Point(4, 414);
            CPUStat.Margin = new Padding(4, 0, 4, 0);
            CPUStat.Name = "CPUStat";
            CPUStat.Size = new Size(112, 17);
            CPUStat.TabIndex = 25;
            CPUStat.Text = "CPU-Status: ???";
            // 
            // MBoard
            // 
            MBoard.AutoSize = true;
            MBoard.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold);
            MBoard.ForeColor = Color.Fuchsia;
            MBoard.Location = new Point(4, 435);
            MBoard.Margin = new Padding(4, 0, 4, 0);
            MBoard.Name = "MBoard";
            MBoard.Size = new Size(97, 17);
            MBoard.TabIndex = 24;
            MBoard.Text = "M-Board: ???";
            // 
            // CPU
            // 
            CPU.AutoSize = true;
            CPU.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold);
            CPU.ForeColor = Color.Fuchsia;
            CPU.Location = new Point(4, 393);
            CPU.Margin = new Padding(4, 0, 4, 0);
            CPU.Name = "CPU";
            CPU.Size = new Size(65, 17);
            CPU.TabIndex = 23;
            CPU.Text = "CPU: ???";
            // 
            // GPU
            // 
            GPU.AutoSize = true;
            GPU.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold);
            GPU.ForeColor = Color.Fuchsia;
            GPU.Location = new Point(4, 373);
            GPU.Margin = new Padding(4, 0, 4, 0);
            GPU.Name = "GPU";
            GPU.Size = new Size(66, 17);
            GPU.TabIndex = 22;
            GPU.Text = "GPU: ???";
            // 
            // TestLabel
            // 
            TestLabel.AutoSize = true;
            TestLabel.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold);
            TestLabel.ForeColor = Color.Fuchsia;
            TestLabel.Location = new Point(4, 356);
            TestLabel.Margin = new Padding(4, 0, 4, 0);
            TestLabel.Name = "TestLabel";
            TestLabel.Size = new Size(113, 17);
            TestLabel.TabIndex = 21;
            TestLabel.Text = "OS Version: ???";
            // 
            // ConInfo
            // 
            ConInfo.AutoSize = true;
            ConInfo.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConInfo.ForeColor = Color.White;
            ConInfo.Location = new Point(497, 217);
            ConInfo.Margin = new Padding(4, 0, 4, 0);
            ConInfo.Name = "ConInfo";
            ConInfo.Size = new Size(0, 18);
            ConInfo.TabIndex = 20;
            // 
            // StatusInfo
            // 
            StatusInfo.AutoSize = true;
            StatusInfo.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatusInfo.ForeColor = Color.White;
            StatusInfo.Location = new Point(352, 217);
            StatusInfo.Margin = new Padding(4, 0, 4, 0);
            StatusInfo.Name = "StatusInfo";
            StatusInfo.Size = new Size(146, 18);
            StatusInfo.TabIndex = 19;
            StatusInfo.Text = "Connection Status:";
            // 
            // AppVer
            // 
            AppVer.AutoSize = true;
            AppVer.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppVer.ForeColor = Color.Magenta;
            AppVer.Location = new Point(7, 437);
            AppVer.Margin = new Padding(4, 0, 4, 0);
            AppVer.Name = "AppVer";
            AppVer.Size = new Size(0, 18);
            AppVer.TabIndex = 18;
            // 
            // DCCopyTag
            // 
            DCCopyTag.AutoSize = true;
            DCCopyTag.Enabled = false;
            DCCopyTag.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DCCopyTag.LinkColor = Color.Magenta;
            DCCopyTag.Location = new Point(9, 25);
            DCCopyTag.Margin = new Padding(4, 0, 4, 0);
            DCCopyTag.Name = "DCCopyTag";
            DCCopyTag.Size = new Size(101, 18);
            DCCopyTag.TabIndex = 7;
            DCCopyTag.TabStop = true;
            DCCopyTag.Text = "Discord Tag: ";
            DCCopyTag.Visible = false;
            DCCopyTag.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Enabled = false;
            linkLabel1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            linkLabel1.LinkColor = Color.Magenta;
            linkLabel1.Location = new Point(9, 67);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(253, 18);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Discord Server: Dovahkiin Lounge";
            linkLabel1.Visible = false;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Magenta;
            label2.Location = new Point(9, 46);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 21);
            label2.TabIndex = 5;
            label2.Text = "▼ Click To Join▼";
            label2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Magenta;
            label1.Location = new Point(9, 4);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 3;
            label1.Text = "▼ Click To Copy▼";
            label1.Visible = false;
            // 
            // siticonePictureBox1
            // 
            siticonePictureBox1.BackgroundImage = (Image)resources.GetObject("siticonePictureBox1.BackgroundImage");
            siticonePictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            siticonePictureBox1.FillColor = Color.Transparent;
            siticonePictureBox1.ImageRotate = 0F;
            siticonePictureBox1.Location = new Point(352, 7);
            siticonePictureBox1.Margin = new Padding(4, 3, 4, 3);
            siticonePictureBox1.Name = "siticonePictureBox1";
            siticonePictureBox1.Size = new Size(217, 207);
            siticonePictureBox1.TabIndex = 0;
            siticonePictureBox1.TabStop = false;
            // 
            // siticoneTabControl1
            // 
            siticoneTabControl1.Controls.Add(About);
            siticoneTabControl1.Controls.Add(FixTool);
            siticoneTabControl1.Controls.Add(Settings);
            siticoneTabControl1.Controls.Add(Credits);
            siticoneTabControl1.ItemSize = new Size(125, 40);
            siticoneTabControl1.Location = new Point(0, 2);
            siticoneTabControl1.Margin = new Padding(4, 3, 4, 3);
            siticoneTabControl1.Name = "siticoneTabControl1";
            siticoneTabControl1.SelectedIndex = 0;
            siticoneTabControl1.Size = new Size(914, 506);
            siticoneTabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            siticoneTabControl1.TabButtonHoverState.FillColor = Color.Black;
            siticoneTabControl1.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            siticoneTabControl1.TabButtonHoverState.ForeColor = Color.Cyan;
            siticoneTabControl1.TabButtonHoverState.InnerColor = Color.Black;
            siticoneTabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            siticoneTabControl1.TabButtonIdleState.FillColor = Color.Black;
            siticoneTabControl1.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            siticoneTabControl1.TabButtonIdleState.ForeColor = Color.White;
            siticoneTabControl1.TabButtonIdleState.InnerColor = Color.Black;
            siticoneTabControl1.TabButtonSelectedState.BorderColor = Color.Empty;
            siticoneTabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            siticoneTabControl1.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            siticoneTabControl1.TabButtonSelectedState.ForeColor = Color.White;
            siticoneTabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            siticoneTabControl1.TabButtonSize = new Size(125, 40);
            siticoneTabControl1.TabIndex = 0;
            siticoneTabControl1.TabMenuBackColor = Color.Black;
            siticoneTabControl1.TabMenuOrientation = Siticone.Desktop.UI.WinForms.TabMenuOrientation.HorizontalTop;
            siticoneTabControl1.SelectedIndexChanged += siticoneTabControl1_SelectedIndexChanged;
            // 
            // Infos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(913, 508);
            Controls.Add(ExitBtn);
            Controls.Add(siticoneTabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Infos";
            Text = "Information";
            Load += Infos_Load;
            Credits.ResumeLayout(false);
            Credits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DCAV2).EndInit();
            ((System.ComponentModel.ISupportInitialize)DCAV1).EndInit();
            Settings.ResumeLayout(false);
            Settings.PerformLayout();
            FixTool.ResumeLayout(false);
            About.ResumeLayout(false);
            About.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).EndInit();
            siticoneTabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox ExitBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDeviceInfo DeviceInfo;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm BorderInfo;
        private Siticone.Desktop.UI.WinForms.SiticoneTaskBarProgress TaskPRogress;
        private System.Windows.Forms.FolderBrowserDialog FolderDial;
        private System.ComponentModel.BackgroundWorker Automation;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.LinkLabel Repo2;
        private System.Windows.Forms.Label CPUStat;
        private System.Windows.Forms.Label MBoard;
        private System.Windows.Forms.Label CPU;
        private System.Windows.Forms.Label GPU;
        private System.Windows.Forms.Label TestLabel;
        private System.Windows.Forms.Label ConInfo;
        private System.Windows.Forms.Label StatusInfo;
        private System.Windows.Forms.Label AppVer;
        private System.Windows.Forms.LinkLabel DCCopyTag;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private System.Windows.Forms.TabPage FixTool;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox RuntimesText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton RunTimeDwn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox PatchText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton PatchDwn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar DwnBar;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox GamesWinLiveText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton GamesWinLiveDwn;
        private System.Windows.Forms.TabPage Settings;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton AutoStartBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox WS;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox ConsoleHideBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox inittxt;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox KBListener;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox HotkeyTxT;
        private System.Windows.Forms.TabPage Credits;
        private System.Windows.Forms.Label CRA2;
        private System.Windows.Forms.Label CRA;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox PhilInfo;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox CeliInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DCName2;
        private System.Windows.Forms.PictureBox DCAV2;
        private System.Windows.Forms.Label DCName;
        private System.Windows.Forms.PictureBox DCAV1;
        private System.Windows.Forms.Label GLName;
        private System.Windows.Forms.Label GLName2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton RemovePatch;
        private Siticone.Desktop.UI.WinForms.SiticoneButton StateUpd;
        private Siticone.Desktop.UI.WinForms.SiticoneButton RemoveGWLD;
        private Siticone.Desktop.UI.WinForms.SiticoneButton RemoveRT;
        private Label DevBDGC;
        private Label DevBDGA;
    }
}