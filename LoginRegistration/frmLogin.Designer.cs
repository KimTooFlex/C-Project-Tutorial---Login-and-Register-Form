namespace LoginRegistration
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassw = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = false;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(435, 54);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(395, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 22);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // txtUser
            // 
            this.txtUser.AcceptsReturn = false;
            this.txtUser.AcceptsTab = false;
            this.txtUser.AnimationSpeed = 220;
            this.txtUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUser.BackgroundImage")));
            this.txtUser.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtUser.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtUser.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtUser.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtUser.BorderRadius = 1;
            this.txtUser.BorderThickness = 1;
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtUser.DefaultText = "";
            this.txtUser.FillColor = System.Drawing.Color.White;
            this.txtUser.HideSelection = true;
            this.txtUser.IconLeft = null;
            this.txtUser.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.IconPadding = 10;
            this.txtUser.IconRight = null;
            this.txtUser.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(26, 114);
            this.txtUser.MaxLength = 32767;
            this.txtUser.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtUser.Modified = false;
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUser.PlaceholderText = "Enter Username";
            this.txtUser.ReadOnly = false;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(374, 35);
            this.txtUser.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtUser.TabIndex = 1;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.TextMarginLeft = 5;
            this.txtUser.TextMarginTop = 0;
            this.txtUser.TextPlaceholder = "Enter Username";
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(29, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // txtPassw
            // 
            this.txtPassw.AcceptsReturn = false;
            this.txtPassw.AcceptsTab = false;
            this.txtPassw.AnimationSpeed = 220;
            this.txtPassw.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassw.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassw.BackColor = System.Drawing.Color.Transparent;
            this.txtPassw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassw.BackgroundImage")));
            this.txtPassw.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPassw.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPassw.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPassw.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPassw.BorderRadius = 1;
            this.txtPassw.BorderThickness = 1;
            this.txtPassw.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassw.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtPassw.DefaultText = "";
            this.txtPassw.FillColor = System.Drawing.Color.White;
            this.txtPassw.HideSelection = true;
            this.txtPassw.IconLeft = null;
            this.txtPassw.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassw.IconPadding = 10;
            this.txtPassw.IconRight = null;
            this.txtPassw.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassw.Lines = new string[0];
            this.txtPassw.Location = new System.Drawing.Point(26, 199);
            this.txtPassw.MaxLength = 32767;
            this.txtPassw.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtPassw.Modified = false;
            this.txtPassw.Multiline = false;
            this.txtPassw.Name = "txtPassw";
            this.txtPassw.PasswordChar = '●';
            this.txtPassw.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassw.PlaceholderText = "Enter Password";
            this.txtPassw.ReadOnly = false;
            this.txtPassw.SelectedText = "";
            this.txtPassw.SelectionLength = 0;
            this.txtPassw.SelectionStart = 0;
            this.txtPassw.ShortcutsEnabled = true;
            this.txtPassw.Size = new System.Drawing.Size(374, 35);
            this.txtPassw.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPassw.TabIndex = 3;
            this.txtPassw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassw.TextMarginLeft = 5;
            this.txtPassw.TextMarginTop = 0;
            this.txtPassw.TextPlaceholder = "Enter Password";
            this.txtPassw.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationSpeed = 220;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "LOGIN";
            this.btnLogin.ButtonTextMarginLeft = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnLogin.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnLogin.DisabledForecolor = System.Drawing.Color.White;
            this.btnLogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.IconPadding = 10;
            this.btnLogin.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.IdleBorderRadius = 1;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.IdleIconLeftImage = null;
            this.btnLogin.IdleIconRightImage = null;
            this.btnLogin.IndicateFocus = true;
            this.btnLogin.Location = new System.Drawing.Point(255, 268);
            this.btnLogin.Name = "btnLogin";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnLogin.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnLogin.OnPressedState = stateProperties2;
            this.btnLogin.Size = new System.Drawing.Size(145, 50);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.TextMarginLeft = 0;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(435, 368);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogin;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtPassw;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtUser;
    }
}

