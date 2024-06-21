using Siticone.Desktop.UI;

namespace xCheats
{
    partial class LoaderMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaderMain));
            ExitBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(components);
            xCheats = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            FormMod = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(components);
            OnOff = new Label();
            xCheatsBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            Infos = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            AppVer = new Label();
            BWO = new System.ComponentModel.BackgroundWorker();
            Checking = new Label();
            OnImg = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            UpdateImg = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            OffImg = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            MoneyCheat = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            Admincheck = new Label();
            RDOLobby = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            Notify = new NotifyIcon(components);
            NotifyMenu = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            TmpCleaner = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            DynInjBtnNM = new ToolStripMenuItem();
            RDR2InjST = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            OpenNM = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ExitNM = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)OnImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OffImg).BeginInit();
            NotifyMenu.SuspendLayout();
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
            ExitBtn.Location = new Point(467, 10);
            ExitBtn.Margin = new Padding(4);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(52, 22);
            ExitBtn.TabIndex = 1;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // siticoneDragControl1
            // 
            siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            siticoneDragControl1.UseTransparentDrag = true;
            // 
            // xCheats
            // 
            xCheats.BackColor = Color.Transparent;
            xCheats.DrawMode = DrawMode.OwnerDrawFixed;
            xCheats.DropDownStyle = ComboBoxStyle.DropDownList;
            xCheats.FillColor = Color.Black;
            xCheats.FocusedColor = Color.FromArgb(94, 148, 255);
            xCheats.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            xCheats.Font = new Font("Segoe UI", 10F);
            xCheats.ForeColor = Color.FromArgb(192, 0, 192);
            xCheats.IntegralHeight = false;
            xCheats.ItemHeight = 30;
            xCheats.Location = new Point(19, 320);
            xCheats.Margin = new Padding(4);
            xCheats.Name = "xCheats";
            xCheats.Size = new Size(503, 36);
            xCheats.TabIndex = 3;
            xCheats.Visible = false;
            // 
            // FormMod
            // 
            FormMod.AnimateWindow = true;
            FormMod.AnimationInterval = 900;
            FormMod.AnimationType = Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm.AnimateWindowType.AW_CENTER;
            FormMod.BorderRadius = 30;
            FormMod.ContainerControl = this;
            FormMod.DockForm = false;
            FormMod.DockIndicatorTransparencyValue = 0.6D;
            FormMod.TransparentWhileDrag = true;
            // 
            // OnOff
            // 
            OnOff.AutoSize = true;
            OnOff.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OnOff.ForeColor = Color.White;
            OnOff.Location = new Point(351, 11);
            OnOff.Margin = new Padding(4, 0, 4, 0);
            OnOff.Name = "OnOff";
            OnOff.RightToLeft = RightToLeft.No;
            OnOff.Size = new Size(23, 16);
            OnOff.TabIndex = 5;
            OnOff.Text = "....";
            OnOff.TextAlign = ContentAlignment.MiddleCenter;
            OnOff.UseMnemonic = false;
            // 
            // xCheatsBtn
            // 
            xCheatsBtn.BackColor = Color.Black;
            xCheatsBtn.DisabledState.BorderColor = Color.DarkGray;
            xCheatsBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            xCheatsBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            xCheatsBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            xCheatsBtn.Dock = DockStyle.Bottom;
            xCheatsBtn.FillColor = Color.Transparent;
            xCheatsBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xCheatsBtn.ForeColor = Color.White;
            xCheatsBtn.HoverState.FillColor = Color.Transparent;
            xCheatsBtn.HoverState.ForeColor = Color.Green;
            xCheatsBtn.Location = new Point(0, 350);
            xCheatsBtn.Margin = new Padding(4);
            xCheatsBtn.Name = "xCheatsBtn";
            xCheatsBtn.Size = new Size(534, 52);
            xCheatsBtn.TabIndex = 7;
            xCheatsBtn.Text = "Start";
            xCheatsBtn.Visible = false;
            xCheatsBtn.Click += xCheatsBtn_Click;
            // 
            // Infos
            // 
            Infos.BackColor = Color.Violet;
            Infos.DisabledState.BorderColor = Color.DarkGray;
            Infos.DisabledState.CustomBorderColor = Color.DarkGray;
            Infos.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Infos.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Infos.FillColor = Color.Transparent;
            Infos.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Infos.ForeColor = Color.White;
            Infos.HoverState.FillColor = Color.Transparent;
            Infos.HoverState.ForeColor = Color.Green;
            Infos.ImageAlign = HorizontalAlignment.Left;
            Infos.Location = new Point(14, 8);
            Infos.Margin = new Padding(4);
            Infos.Name = "Infos";
            Infos.Size = new Size(112, 22);
            Infos.TabIndex = 14;
            Infos.Text = "More";
            Infos.TextFormatNoPrefix = true;
            Infos.Click += Infos_Click;
            // 
            // AppVer
            // 
            AppVer.AutoSize = true;
            AppVer.ForeColor = Color.Magenta;
            AppVer.Location = new Point(14, 266);
            AppVer.Margin = new Padding(4, 0, 4, 0);
            AppVer.Name = "AppVer";
            AppVer.Size = new Size(72, 15);
            AppVer.TabIndex = 17;
            AppVer.Text = "Version: ?.?.?";
            // 
            // BWO
            // 
            BWO.WorkerReportsProgress = true;
            BWO.DoWork += BWO_DoWork;
            // 
            // Checking
            // 
            Checking.AutoSize = true;
            Checking.ForeColor = Color.Magenta;
            Checking.Location = new Point(429, 45);
            Checking.Margin = new Padding(4, 0, 4, 0);
            Checking.Name = "Checking";
            Checking.Size = new Size(81, 15);
            Checking.TabIndex = 18;
            Checking.Text = "David Jackson";
            Checking.DoubleClick += Checking_DoubleClick;
            // 
            // OnImg
            // 
            OnImg.Image = (Image)resources.GetObject("OnImg.Image");
            OnImg.ImageRotate = 0F;
            OnImg.Location = new Point(327, 9);
            OnImg.Margin = new Padding(4);
            OnImg.Name = "OnImg";
            OnImg.Size = new Size(24, 24);
            OnImg.SizeMode = PictureBoxSizeMode.Zoom;
            OnImg.TabIndex = 22;
            OnImg.TabStop = false;
            // 
            // UpdateImg
            // 
            UpdateImg.Image = (Image)resources.GetObject("UpdateImg.Image");
            UpdateImg.ImageRotate = 0F;
            UpdateImg.Location = new Point(306, 9);
            UpdateImg.Margin = new Padding(4);
            UpdateImg.Name = "UpdateImg";
            UpdateImg.Size = new Size(24, 24);
            UpdateImg.SizeMode = PictureBoxSizeMode.Zoom;
            UpdateImg.TabIndex = 23;
            UpdateImg.TabStop = false;
            // 
            // OffImg
            // 
            OffImg.Image = (Image)resources.GetObject("OffImg.Image");
            OffImg.ImageRotate = 0F;
            OffImg.Location = new Point(327, 9);
            OffImg.Margin = new Padding(4);
            OffImg.Name = "OffImg";
            OffImg.Size = new Size(24, 24);
            OffImg.SizeMode = PictureBoxSizeMode.Zoom;
            OffImg.TabIndex = 24;
            OffImg.TabStop = false;
            // 
            // MoneyCheat
            // 
            MoneyCheat.AutoSize = true;
            MoneyCheat.BackColor = Color.Transparent;
            MoneyCheat.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            MoneyCheat.CheckedState.BorderRadius = 0;
            MoneyCheat.CheckedState.BorderThickness = 0;
            MoneyCheat.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            MoneyCheat.ForeColor = Color.Cornsilk;
            MoneyCheat.Location = new Point(14, 68);
            MoneyCheat.Margin = new Padding(4);
            MoneyCheat.Name = "MoneyCheat";
            MoneyCheat.Size = new Size(131, 19);
            MoneyCheat.TabIndex = 13;
            MoneyCheat.Text = "Show/Hide Console";
            MoneyCheat.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            MoneyCheat.UncheckedState.BorderRadius = 0;
            MoneyCheat.UncheckedState.BorderThickness = 0;
            MoneyCheat.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            MoneyCheat.UseVisualStyleBackColor = false;
            MoneyCheat.CheckedChanged += MoneyCheat_CheckedChanged;
            // 
            // Admincheck
            // 
            Admincheck.AutoSize = true;
            Admincheck.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Admincheck.ForeColor = Color.Magenta;
            Admincheck.Location = new Point(72, 322);
            Admincheck.Margin = new Padding(4, 0, 4, 0);
            Admincheck.Name = "Admincheck";
            Admincheck.Size = new Size(339, 24);
            Admincheck.TabIndex = 25;
            Admincheck.Text = "Cheats Disabled(Need Admin Start)";
            Admincheck.Visible = false;
            // 
            // RDOLobby
            // 
            RDOLobby.BackColor = Color.Violet;
            RDOLobby.DisabledState.BorderColor = Color.DarkGray;
            RDOLobby.DisabledState.CustomBorderColor = Color.DarkGray;
            RDOLobby.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            RDOLobby.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            RDOLobby.FillColor = Color.Transparent;
            RDOLobby.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RDOLobby.ForeColor = Color.White;
            RDOLobby.HoverState.FillColor = Color.Transparent;
            RDOLobby.HoverState.ForeColor = Color.Green;
            RDOLobby.ImageAlign = HorizontalAlignment.Left;
            RDOLobby.Location = new Point(14, 38);
            RDOLobby.Margin = new Padding(4);
            RDOLobby.Name = "RDOLobby";
            RDOLobby.Size = new Size(231, 22);
            RDOLobby.TabIndex = 26;
            RDOLobby.Text = "RDO Lobby Tool";
            RDOLobby.TextFormatNoPrefix = true;
            RDOLobby.Click += RDOLobby_Click;
            // 
            // Notify
            // 
            Notify.BalloonTipIcon = ToolTipIcon.Info;
            Notify.BalloonTipText = "I running now in the background.";
            Notify.BalloonTipTitle = "xCheats Information";
            Notify.ContextMenuStrip = NotifyMenu;
            Notify.Icon = (Icon)resources.GetObject("Notify.Icon");
            Notify.Text = "xCheats";
            Notify.Visible = true;
            Notify.MouseDoubleClick += Notify_MouseDoubleClick;
            // 
            // NotifyMenu
            // 
            NotifyMenu.BackColor = Color.Black;
            NotifyMenu.DropShadowEnabled = false;
            NotifyMenu.ImageScalingSize = new Size(24, 24);
            NotifyMenu.Items.AddRange(new ToolStripItem[] { TmpCleaner, toolStripSeparator3, DynInjBtnNM, toolStripSeparator2, OpenNM, toolStripSeparator1, ExitNM });
            NotifyMenu.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            NotifyMenu.Name = "NotifyMenu";
            NotifyMenu.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            NotifyMenu.RenderStyle.BorderColor = Color.Magenta;
            NotifyMenu.RenderStyle.ColorTable = null;
            NotifyMenu.RenderStyle.RoundedEdges = true;
            NotifyMenu.RenderStyle.SelectionArrowColor = Color.White;
            NotifyMenu.RenderStyle.SelectionBackColor = Color.Transparent;
            NotifyMenu.RenderStyle.SelectionForeColor = Color.Linen;
            NotifyMenu.RenderStyle.SeparatorColor = Color.FromArgb(64, 64, 64);
            NotifyMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            NotifyMenu.ShowImageMargin = false;
            NotifyMenu.Size = new Size(132, 110);
            // 
            // TmpCleaner
            // 
            TmpCleaner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TmpCleaner.ForeColor = Color.Fuchsia;
            TmpCleaner.Name = "TmpCleaner";
            TmpCleaner.Size = new Size(131, 22);
            TmpCleaner.Text = "Clean Temp";
            TmpCleaner.ToolTipText = "Clean Temp Folder";
            TmpCleaner.Click += TmpCleaner_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(128, 6);
            toolStripSeparator3.Visible = false;
            // 
            // DynInjBtnNM
            // 
            DynInjBtnNM.DropDownItems.AddRange(new ToolStripItem[] { RDR2InjST });
            DynInjBtnNM.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            DynInjBtnNM.ForeColor = Color.Magenta;
            DynInjBtnNM.Name = "DynInjBtnNM";
            DynInjBtnNM.Size = new Size(131, 22);
            DynInjBtnNM.Text = "Injections";
            DynInjBtnNM.Visible = false;
            // 
            // RDR2InjST
            // 
            RDR2InjST.BackColor = SystemColors.ActiveCaptionText;
            RDR2InjST.ForeColor = Color.Magenta;
            RDR2InjST.Name = "RDR2InjST";
            RDR2InjST.Size = new Size(109, 22);
            RDR2InjST.Text = "RDR2 ";
            RDR2InjST.Click += RDR2InjST_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(128, 6);
            // 
            // OpenNM
            // 
            OpenNM.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OpenNM.ForeColor = Color.Magenta;
            OpenNM.Name = "OpenNM";
            OpenNM.Size = new Size(131, 22);
            OpenNM.Text = "Open xCheats";
            OpenNM.Click += OpenNM_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(128, 6);
            // 
            // ExitNM
            // 
            ExitNM.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ExitNM.ForeColor = Color.Red;
            ExitNM.Name = "ExitNM";
            ExitNM.Size = new Size(131, 22);
            ExitNM.Text = "Exit";
            ExitNM.ToolTipText = "Terminate the Application";
            ExitNM.Click += ExitNM_Click;
            // 
            // LoaderMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(534, 402);
            Controls.Add(xCheats);
            Controls.Add(RDOLobby);
            Controls.Add(Admincheck);
            Controls.Add(OffImg);
            Controls.Add(UpdateImg);
            Controls.Add(OnImg);
            Controls.Add(Checking);
            Controls.Add(AppVer);
            Controls.Add(Infos);
            Controls.Add(MoneyCheat);
            Controls.Add(xCheatsBtn);
            Controls.Add(OnOff);
            Controls.Add(ExitBtn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "LoaderMain";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "xCheats Launcher";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            Shown += Main_Shown;
            ((System.ComponentModel.ISupportInitialize)OnImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)OffImg).EndInit();
            NotifyMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox ExitBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox xCheats;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm FormMod;
        private System.Windows.Forms.Label OnOff;
        private Siticone.Desktop.UI.WinForms.SiticoneButton xCheatsBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox MoneyCheat;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Infos;
        private System.Windows.Forms.Label AppVer;
        private System.ComponentModel.BackgroundWorker BWO;
        private System.Windows.Forms.Label Checking;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox OnImg;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox OffImg;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox UpdateImg;
        private System.Windows.Forms.Label Admincheck;
        private Siticone.Desktop.UI.WinForms.SiticoneButton RDOLobby;
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip NotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitNM;
        private System.Windows.Forms.ToolStripMenuItem OpenNM;
        private System.Windows.Forms.ToolStripMenuItem DynInjBtnNM;
        private System.Windows.Forms.ToolStripMenuItem RDR2InjST;
        public NotifyIcon Notify;
        private ToolStripMenuItem TmpCleaner;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
    }
}

