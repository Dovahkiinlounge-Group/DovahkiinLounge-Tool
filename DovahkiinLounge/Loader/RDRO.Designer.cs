namespace xCheats.Loader
{
    partial class RDRO
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
            ExitBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            PfadBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            RDOContent = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            Pfad = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            RDOLCreate = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            GoPublicBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            WindowControll = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(components);
            Email = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            Password = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            emaillbl = new Label();
            pwlbl = new Label();
            SaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            wndName = new Label();
            exoName = new Label();
            Installlbl = new Label();
            ToolTip = new ToolTip(components);
            LC = new Label();
            LCApply = new LinkLabel();
            SuspendLayout();
            // 
            // ExitBtn
            // 
            ExitBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitBtn.Animated = true;
            ExitBtn.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            ExitBtn.FillColor = Color.Red;
            ExitBtn.IconColor = Color.Black;
            ExitBtn.Location = new Point(535, 12);
            ExitBtn.Margin = new Padding(4, 3, 4, 3);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(23, 23);
            ExitBtn.TabIndex = 3;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // PfadBtn
            // 
            PfadBtn.DisabledState.BorderColor = Color.DarkGray;
            PfadBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            PfadBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            PfadBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            PfadBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            PfadBtn.Font = new Font("Segoe UI", 9F);
            PfadBtn.ForeColor = Color.White;
            PfadBtn.Location = new Point(145, 185);
            PfadBtn.Margin = new Padding(4, 3, 4, 3);
            PfadBtn.Name = "PfadBtn";
            PfadBtn.Size = new Size(125, 29);
            PfadBtn.TabIndex = 4;
            PfadBtn.Text = "Get RDR2 Path";
            PfadBtn.Click += PfadBtn_Click;
            // 
            // RDOContent
            // 
            RDOContent.BorderColor = Color.Fuchsia;
            RDOContent.Cursor = Cursors.IBeam;
            RDOContent.DefaultText = "";
            RDOContent.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            RDOContent.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            RDOContent.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            RDOContent.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            RDOContent.FillColor = Color.Black;
            RDOContent.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            RDOContent.Font = new Font("Segoe UI", 9F);
            RDOContent.ForeColor = Color.Fuchsia;
            RDOContent.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            RDOContent.Location = new Point(12, 138);
            RDOContent.Margin = new Padding(4, 3, 4, 3);
            RDOContent.MaxLength = 9;
            RDOContent.Name = "RDOContent";
            RDOContent.PasswordChar = '\0';
            RDOContent.PlaceholderText = "Lobby Code";
            RDOContent.SelectedText = "";
            RDOContent.Size = new Size(125, 29);
            RDOContent.TabIndex = 5;
            // 
            // Pfad
            // 
            Pfad.Animated = true;
            Pfad.AutoRoundedCorners = true;
            Pfad.BorderColor = Color.Fuchsia;
            Pfad.BorderRadius = 23;
            Pfad.Cursor = Cursors.IBeam;
            Pfad.DefaultText = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Red Dead Redemption 2";
            Pfad.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Pfad.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Pfad.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Pfad.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Pfad.FillColor = Color.Black;
            Pfad.FocusedState.BorderColor = Color.Transparent;
            Pfad.Font = new Font("Segoe UI", 9F);
            Pfad.ForeColor = Color.Fuchsia;
            Pfad.HoverState.BorderColor = Color.Transparent;
            Pfad.Location = new Point(12, 54);
            Pfad.Margin = new Padding(4, 3, 4, 3);
            Pfad.Multiline = true;
            Pfad.Name = "Pfad";
            Pfad.PasswordChar = '\0';
            Pfad.PlaceholderForeColor = Color.Transparent;
            Pfad.PlaceholderText = "";
            Pfad.SelectedText = "";
            Pfad.Size = new Size(259, 49);
            Pfad.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            Pfad.TabIndex = 6;
            // 
            // RDOLCreate
            // 
            RDOLCreate.DisabledState.BorderColor = Color.DarkGray;
            RDOLCreate.DisabledState.CustomBorderColor = Color.DarkGray;
            RDOLCreate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            RDOLCreate.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            RDOLCreate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            RDOLCreate.Font = new Font("Segoe UI", 9F);
            RDOLCreate.ForeColor = Color.White;
            RDOLCreate.Location = new Point(12, 185);
            RDOLCreate.Margin = new Padding(4, 3, 4, 3);
            RDOLCreate.Name = "RDOLCreate";
            RDOLCreate.Size = new Size(125, 29);
            RDOLCreate.TabIndex = 7;
            RDOLCreate.Text = "Create Lobby";
            RDOLCreate.Click += RDOLCreate_Click;
            // 
            // GoPublicBtn
            // 
            GoPublicBtn.DisabledState.BorderColor = Color.DarkGray;
            GoPublicBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            GoPublicBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            GoPublicBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            GoPublicBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            GoPublicBtn.Font = new Font("Segoe UI", 9F);
            GoPublicBtn.ForeColor = Color.White;
            GoPublicBtn.Location = new Point(146, 138);
            GoPublicBtn.Margin = new Padding(4, 3, 4, 3);
            GoPublicBtn.Name = "GoPublicBtn";
            GoPublicBtn.Size = new Size(125, 29);
            GoPublicBtn.TabIndex = 8;
            GoPublicBtn.Text = "Go Public";
            GoPublicBtn.Click += GoPublicBtn_Click;
            // 
            // WindowControll
            // 
            WindowControll.AnimateWindow = true;
            WindowControll.ContainerControl = this;
            WindowControll.DockIndicatorTransparencyValue = 0.6D;
            WindowControll.TransparentWhileDrag = true;
            // 
            // Email
            // 
            Email.AutoRoundedCorners = true;
            Email.BorderColor = Color.Fuchsia;
            Email.BorderRadius = 20;
            Email.Cursor = Cursors.IBeam;
            Email.DefaultText = "";
            Email.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Email.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Email.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Email.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Email.FillColor = Color.Black;
            Email.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Email.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Email.ForeColor = Color.White;
            Email.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Email.Location = new Point(328, 73);
            Email.Margin = new Padding(6, 4, 6, 4);
            Email.Name = "Email";
            Email.PasswordChar = '\0';
            Email.PlaceholderForeColor = Color.White;
            Email.PlaceholderText = "Enter your email";
            Email.SelectedText = "";
            Email.Size = new Size(231, 42);
            Email.TabIndex = 9;
            // 
            // Password
            // 
            Password.AutoRoundedCorners = true;
            Password.BorderColor = Color.Fuchsia;
            Password.BorderRadius = 20;
            Password.Cursor = Cursors.IBeam;
            Password.DefaultText = "";
            Password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Password.FillColor = Color.Black;
            Password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Password.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.ForeColor = Color.Fuchsia;
            Password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Password.Location = new Point(328, 138);
            Password.Margin = new Padding(6, 4, 6, 4);
            Password.Name = "Password";
            Password.PasswordChar = '●';
            Password.PlaceholderForeColor = Color.White;
            Password.PlaceholderText = "Enter your password";
            Password.SelectedText = "";
            Password.Size = new Size(231, 42);
            Password.TabIndex = 10;
            Password.MouseDoubleClick += Password_MouseDoubleClick;
            // 
            // emaillbl
            // 
            emaillbl.AutoSize = true;
            emaillbl.Font = new Font("Arial", 9F, FontStyle.Bold);
            emaillbl.ForeColor = Color.White;
            emaillbl.Location = new Point(328, 54);
            emaillbl.Margin = new Padding(4, 0, 4, 0);
            emaillbl.Name = "emaillbl";
            emaillbl.Size = new Size(41, 15);
            emaillbl.TabIndex = 11;
            emaillbl.Text = "Email:";
            // 
            // pwlbl
            // 
            pwlbl.AutoSize = true;
            pwlbl.Font = new Font("Arial", 9F, FontStyle.Bold);
            pwlbl.ForeColor = Color.White;
            pwlbl.Location = new Point(328, 119);
            pwlbl.Margin = new Padding(4, 0, 4, 0);
            pwlbl.Name = "pwlbl";
            pwlbl.Size = new Size(86, 15);
            pwlbl.TabIndex = 12;
            pwlbl.Text = "(?) Password:";
            ToolTip.SetToolTip(pwlbl, "Double Click with mouse to show the Password");
            // 
            // SaveBtn
            // 
            SaveBtn.AutoRoundedCorners = true;
            SaveBtn.BorderColor = Color.Fuchsia;
            SaveBtn.BorderRadius = 12;
            SaveBtn.BorderThickness = 1;
            SaveBtn.DisabledState.BorderColor = Color.DarkGray;
            SaveBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            SaveBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SaveBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SaveBtn.FillColor = Color.Black;
            SaveBtn.Font = new Font("Segoe UI", 9F);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(328, 189);
            SaveBtn.Margin = new Padding(4, 3, 4, 3);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(231, 27);
            SaveBtn.TabIndex = 13;
            SaveBtn.Text = "Save";
            SaveBtn.Click += SaveBtn_Click;
            // 
            // wndName
            // 
            wndName.AutoSize = true;
            wndName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wndName.ForeColor = Color.Magenta;
            wndName.Location = new Point(12, 9);
            wndName.Margin = new Padding(4, 0, 4, 0);
            wndName.Name = "wndName";
            wndName.Size = new Size(229, 18);
            wndName.TabIndex = 14;
            wndName.Text = "Red Dead Online Lobby Tool:";
            // 
            // exoName
            // 
            exoName.AutoSize = true;
            exoName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            exoName.ForeColor = Color.Magenta;
            exoName.Location = new Point(328, 9);
            exoName.Margin = new Padding(4, 0, 4, 0);
            exoName.Name = "exoName";
            exoName.Size = new Size(117, 18);
            exoName.TabIndex = 15;
            exoName.Text = "Exodus Client:";
            // 
            // Installlbl
            // 
            Installlbl.AutoSize = true;
            Installlbl.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Installlbl.ForeColor = Color.White;
            Installlbl.Location = new Point(14, 33);
            Installlbl.Margin = new Padding(4, 0, 4, 0);
            Installlbl.Name = "Installlbl";
            Installlbl.Size = new Size(94, 18);
            Installlbl.TabIndex = 16;
            Installlbl.Text = "Installation:";
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.BackColor = SystemColors.Desktop;
            ToolTip.ForeColor = Color.Fuchsia;
            ToolTip.InitialDelay = 100;
            ToolTip.IsBalloon = true;
            ToolTip.OwnerDraw = true;
            ToolTip.ReshowDelay = 100;
            // 
            // LC
            // 
            LC.AutoSize = true;
            LC.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LC.ForeColor = Color.White;
            LC.Location = new Point(14, 111);
            LC.Margin = new Padding(4, 0, 4, 0);
            LC.Name = "LC";
            LC.Size = new Size(157, 18);
            LC.TabIndex = 17;
            LC.Text = "Last LobbyCode: ???";
            // 
            // LCApply
            // 
            LCApply.AutoSize = true;
            LCApply.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            LCApply.LinkColor = Color.Lime;
            LCApply.Location = new Point(222, 111);
            LCApply.Name = "LCApply";
            LCApply.Size = new Size(48, 18);
            LCApply.TabIndex = 18;
            LCApply.TabStop = true;
            LCApply.Text = "Apply";
            LCApply.LinkClicked += LCApply_LinkClicked;
            // 
            // RDRO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(571, 228);
            Controls.Add(LCApply);
            Controls.Add(LC);
            Controls.Add(Installlbl);
            Controls.Add(exoName);
            Controls.Add(wndName);
            Controls.Add(SaveBtn);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(GoPublicBtn);
            Controls.Add(RDOLCreate);
            Controls.Add(Pfad);
            Controls.Add(RDOContent);
            Controls.Add(PfadBtn);
            Controls.Add(ExitBtn);
            Controls.Add(pwlbl);
            Controls.Add(emaillbl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RDRO";
            ShowIcon = false;
            Text = "RDRO";
            Load += RDRO_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox ExitBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton PfadBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox RDOContent;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Pfad;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton RDOLCreate;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton GoPublicBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm WindowControll;
        private System.Windows.Forms.Label pwlbl;
        private System.Windows.Forms.Label emaillbl;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Password;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Email;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SaveBtn;
        private Label exoName;
        private Label wndName;
        private Label Installlbl;
        private ToolTip ToolTip;
        private Label LC;
        private LinkLabel LCApply;
    }
}