namespace bookshopsystem.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtUsername = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 25;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.lblError);
            this.bunifuPanel1.Controls.Add(this.btnLogin);
            this.bunifuPanel1.Controls.Add(this.label5);
            this.bunifuPanel1.Controls.Add(this.label4);
            this.bunifuPanel1.Controls.Add(this.txtPassword);
            this.bunifuPanel1.Controls.Add(this.txtUsername);
            this.bunifuPanel1.Controls.Add(this.label3);
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Location = new System.Drawing.Point(400, 12);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(372, 537);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(47, 438);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(278, 37);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "lblError";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.AllowAnimations = true;
            this.btnLogin.AllowMouseEffects = true;
            this.btnLogin.AllowToggling = false;
            this.btnLogin.AnimationSpeed = 200;
            this.btnLogin.AutoGenerateColors = false;
            this.btnLogin.AutoRoundBorders = false;
            this.btnLogin.AutoSizeLeftIcon = true;
            this.btnLogin.AutoSizeRightIcon = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(138)))), ((int)(((byte)(87)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.ButtonText = "login";
            this.btnLogin.ButtonTextMarginLeft = 0;
            this.btnLogin.ColorContrastOnClick = 45;
            this.btnLogin.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLogin.CustomizableEdges = borderEdges1;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogin.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogin.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogin.IconMarginLeft = 11;
            this.btnLogin.IconPadding = 10;
            this.btnLogin.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogin.IconSize = 25;
            this.btnLogin.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.IdleBorderRadius = 35;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(138)))), ((int)(((byte)(87)))));
            this.btnLogin.IdleIconLeftImage = null;
            this.btnLogin.IdleIconRightImage = null;
            this.btnLogin.IndicateFocus = false;
            this.btnLogin.Location = new System.Drawing.Point(48, 381);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogin.OnDisabledState.BorderRadius = 35;
            this.btnLogin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnDisabledState.BorderThickness = 1;
            this.btnLogin.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogin.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogin.OnDisabledState.IconLeftImage = null;
            this.btnLogin.OnDisabledState.IconRightImage = null;
            this.btnLogin.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(104)))), ((int)(((byte)(76)))));
            this.btnLogin.onHoverState.BorderRadius = 35;
            this.btnLogin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.onHoverState.BorderThickness = 1;
            this.btnLogin.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(104)))), ((int)(((byte)(76)))));
            this.btnLogin.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.onHoverState.IconLeftImage = null;
            this.btnLogin.onHoverState.IconRightImage = null;
            this.btnLogin.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.OnIdleState.BorderRadius = 35;
            this.btnLogin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnIdleState.BorderThickness = 1;
            this.btnLogin.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(138)))), ((int)(((byte)(87)))));
            this.btnLogin.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.OnIdleState.IconLeftImage = null;
            this.btnLogin.OnIdleState.IconRightImage = null;
            this.btnLogin.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLogin.OnPressedState.BorderRadius = 35;
            this.btnLogin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnPressedState.BorderThickness = 1;
            this.btnLogin.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLogin.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.OnPressedState.IconLeftImage = null;
            this.btnLogin.OnPressedState.IconRightImage = null;
            this.btnLogin.Size = new System.Drawing.Size(278, 39);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.TextMarginLeft = 0;
            this.btnLogin.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLogin.UseDefaultRadiusAndThickness = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.AnimationSpeed = 200;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPassword.BorderRadius = 25;
            this.txtPassword.BorderThickness = 0;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(47, 297);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Modified = false;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnIdleState = stateProperties4;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(3);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassword.PlaceholderText = "Enter password";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(278, 37);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginBottom = 0;
            this.txtPassword.TextMarginLeft = 3;
            this.txtPassword.TextMarginTop = 0;
            this.txtPassword.TextPlaceholder = "Enter password";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WordWrap = true;
            // 
            // txtUsername
            // 
            this.txtUsername.AcceptsReturn = false;
            this.txtUsername.AcceptsTab = false;
            this.txtUsername.AnimationSpeed = 200;
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUsername.BackgroundImage")));
            this.txtUsername.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtUsername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUsername.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtUsername.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtUsername.BorderRadius = 25;
            this.txtUsername.BorderThickness = 0;
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtUsername.DefaultText = "";
            this.txtUsername.FillColor = System.Drawing.Color.White;
            this.txtUsername.HideSelection = true;
            this.txtUsername.IconLeft = null;
            this.txtUsername.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.IconPadding = 10;
            this.txtUsername.IconRight = null;
            this.txtUsername.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(47, 215);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUsername.Modified = false;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnIdleState = stateProperties8;
            this.txtUsername.Padding = new System.Windows.Forms.Padding(3);
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUsername.PlaceholderText = "Enter username";
            this.txtUsername.ReadOnly = false;
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(278, 37);
            this.txtUsername.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.TextMarginBottom = 0;
            this.txtUsername.TextMarginLeft = 3;
            this.txtUsername.TextMarginTop = 0;
            this.txtUsername.TextPlaceholder = "Enter username";
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.WordWrap = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please enter your details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "login Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Shop";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 75;
            this.bunifuPictureBox1.Image = global::bookshopsystem.Properties.Resources.RUPP_logo;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(116, 83);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(150, 150);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 2;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuPictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 350);
            this.panel1.TabIndex = 3;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bookshopsystem.Properties.Resources.LIBRARY_BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuTextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogin;
        private System.Windows.Forms.Label lblError;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}