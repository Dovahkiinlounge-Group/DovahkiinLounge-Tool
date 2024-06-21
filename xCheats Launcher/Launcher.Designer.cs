namespace xCheats_Launcher
{
    partial class Launcher
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            Window = new Zeroit.Framework.Form.ZeroitChromeForm();
            AdminTggl = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox();
            OffTggl = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox();
            BGTggl = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox();
            zeroitLollipopButton1 = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            AppText = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel();
            StartBtn = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            Window.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Window
            // 
            Window.BackColor = System.Drawing.Color.Black;
            Window.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Window.ColorBackground1 = System.Drawing.Color.Violet;
            Window.ColorBackground2 = System.Drawing.Color.LightSeaGreen;
            Window.Controls.Add(AdminTggl);
            Window.Controls.Add(OffTggl);
            Window.Controls.Add(BGTggl);
            Window.Controls.Add(zeroitLollipopButton1);
            Window.Controls.Add(pictureBox1);
            Window.Controls.Add(AppText);
            Window.Controls.Add(StartBtn);
            Window.Customization = "AAAA//////8AAP//";
            Window.Dock = System.Windows.Forms.DockStyle.Fill;
            Window.Font = new System.Drawing.Font("Segoe UI", 9F);
            Window.Image = null;
            Window.Location = new System.Drawing.Point(0, 0);
            Window.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Window.Movable = false;
            Window.Name = "Window";
            Window.NoRounding = true;
            Window.Sizable = false;
            Window.Size = new System.Drawing.Size(898, 538);
            Window.SmartBounds = true;
            Window.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Window.TabIndex = 0;
            Window.Text = "xCheats";
            Window.TransparencyKey = System.Drawing.Color.Empty;
            Window.Transparent = false;
            Window.MouseDown += MainForm_MouseDown;
            Window.MouseMove += MainForm_MouseMove;
            Window.MouseUp += MainForm_MouseUp;
            // 
            // AdminTggl
            // 
            AdminTggl.AllowTransparency = true;
            AdminTggl.Checked = false;
            AdminTggl.CheckedColor = System.Drawing.Color.FromArgb(80, 142, 245);
            AdminTggl.ForeColor = System.Drawing.Color.Green;
            AdminTggl.Location = new System.Drawing.Point(29, 195);
            AdminTggl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            AdminTggl.Name = "AdminTggl";
            AdminTggl.RectangleWidth = 1;
            AdminTggl.Size = new System.Drawing.Size(123, 20);
            AdminTggl.TabIndex = 8;
            AdminTggl.Text = "Admin Mode";
            AdminTggl.UncheckedColor = System.Drawing.Color.White;
            AdminTggl.Click += AdminTggl_Click;
            // 
            // OffTggl
            // 
            OffTggl.AllowTransparency = true;
            OffTggl.Checked = false;
            OffTggl.CheckedColor = System.Drawing.Color.FromArgb(80, 142, 245);
            OffTggl.ForeColor = System.Drawing.Color.Magenta;
            OffTggl.Location = new System.Drawing.Point(29, 115);
            OffTggl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            OffTggl.Name = "OffTggl";
            OffTggl.RectangleWidth = 1;
            OffTggl.Size = new System.Drawing.Size(77, 20);
            OffTggl.TabIndex = 7;
            OffTggl.Text = "Offline";
            OffTggl.UncheckedColor = System.Drawing.Color.White;
            OffTggl.Click += OffTggl_Click;
            // 
            // BGTggl
            // 
            BGTggl.AllowTransparency = true;
            BGTggl.Checked = false;
            BGTggl.CheckedColor = System.Drawing.Color.FromArgb(80, 142, 245);
            BGTggl.ForeColor = System.Drawing.Color.Green;
            BGTggl.Location = new System.Drawing.Point(29, 155);
            BGTggl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BGTggl.Name = "BGTggl";
            BGTggl.RectangleWidth = 1;
            BGTggl.Size = new System.Drawing.Size(118, 20);
            BGTggl.TabIndex = 6;
            BGTggl.Text = "Background";
            BGTggl.UncheckedColor = System.Drawing.Color.White;
            BGTggl.Click += BGTggl_Click;
            // 
            // zeroitLollipopButton1
            // 
            zeroitLollipopButton1.AllowTransparency = true;
            zeroitLollipopButton1.AnimationInterval = 1;
            zeroitLollipopButton1.BackColor = System.Drawing.Color.Transparent;
            zeroitLollipopButton1.BGColor = "#508ef5";
            zeroitLollipopButton1.Corners = 1F;
            zeroitLollipopButton1.DisabledBGColor = System.Drawing.Color.FromArgb(176, 178, 181);
            zeroitLollipopButton1.DoubleRipple = false;
            zeroitLollipopButton1.EnabledBGColor = System.Drawing.Color.Black;
            zeroitLollipopButton1.FontColor = "#ffffff";
            zeroitLollipopButton1.ForeColor = System.Drawing.Color.Red;
            zeroitLollipopButton1.Location = new System.Drawing.Point(1035, 0);
            zeroitLollipopButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            zeroitLollipopButton1.Name = "zeroitLollipopButton1";
            zeroitLollipopButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            zeroitLollipopButton1.RippleEffectColor = System.Drawing.Color.Black;
            zeroitLollipopButton1.RippleOpacity = 25;
            zeroitLollipopButton1.Size = new System.Drawing.Size(32, 34);
            zeroitLollipopButton1.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            zeroitLollipopButton1.TabIndex = 3;
            zeroitLollipopButton1.Text = "X";
            zeroitLollipopButton1.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            zeroitLollipopButton1.Click += zeroitLollipopButton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(336, 155);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(224, 220);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // AppText
            // 
            AppText.AllowTransparency = false;
            AppText.AutoSize = true;
            AppText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            AppText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            AppText.ForeColor = System.Drawing.Color.Fuchsia;
            AppText.Location = new System.Drawing.Point(256, 83);
            AppText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AppText.Name = "AppText";
            AppText.Size = new System.Drawing.Size(391, 52);
            AppText.TabIndex = 1;
            AppText.Text = "xCheats Launcher";
            // 
            // StartBtn
            // 
            StartBtn.AllowTransparency = true;
            StartBtn.AnimationInterval = 1;
            StartBtn.BackColor = System.Drawing.Color.Transparent;
            StartBtn.BGColor = "#fffff";
            StartBtn.Corners = 1F;
            StartBtn.DisabledBGColor = System.Drawing.Color.FromArgb(176, 178, 181);
            StartBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            StartBtn.DoubleRipple = false;
            StartBtn.EnabledBGColor = System.Drawing.Color.Transparent;
            StartBtn.FontColor = "#ffffff";
            StartBtn.ForeColor = System.Drawing.Color.FromArgb(192, 0, 192);
            StartBtn.Location = new System.Drawing.Point(0, 503);
            StartBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            StartBtn.Name = "StartBtn";
            StartBtn.RippleEffectColor = System.Drawing.Color.Black;
            StartBtn.RippleOpacity = 25;
            StartBtn.Size = new System.Drawing.Size(898, 35);
            StartBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            StartBtn.TabIndex = 0;
            StartBtn.Text = "Start xCheats";
            StartBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            StartBtn.Click += StartBtn_Click;
            // 
            // Launcher
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(898, 538);
            Controls.Add(Window);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Launcher";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "zeroitGradientForm1";
            Window.ResumeLayout(false);
            Window.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton StartBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel AppText;
        public Zeroit.Framework.Form.ZeroitChromeForm Window;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton zeroitLollipopButton1;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox OffTggl;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox BGTggl;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopCheckBox AdminTggl;
    }
}

