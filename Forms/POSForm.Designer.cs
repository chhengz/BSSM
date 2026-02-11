namespace bookshopsystem.Forms
{
    partial class POSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.main_panel = new System.Windows.Forms.Panel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.flowLayout_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.cardItems_panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.itemlistFlowlayout_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.picBtnExit = new System.Windows.Forms.PictureBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.bottom_panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnFashCash = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.main_panel.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cardItems_panel.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.bottom_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.bunifuPanel2);
            this.main_panel.Controls.Add(this.cardItems_panel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(10, 60);
            this.main_panel.Name = "main_panel";
            this.main_panel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.main_panel.Size = new System.Drawing.Size(947, 405);
            this.main_panel.TabIndex = 4;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Silver;
            this.bunifuPanel2.BorderRadius = 25;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.flowLayout_Panel);
            this.bunifuPanel2.Controls.Add(this.panel1);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 10);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(597, 395);
            this.bunifuPanel2.TabIndex = 8;
            // 
            // flowLayout_Panel
            // 
            this.flowLayout_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout_Panel.Location = new System.Drawing.Point(10, 50);
            this.flowLayout_Panel.Name = "flowLayout_Panel";
            this.flowLayout_Panel.Size = new System.Drawing.Size(577, 335);
            this.flowLayout_Panel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(577, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReload.Image = global::bookshopsystem.Properties.Resources.synchronize_26px;
            this.btnReload.Location = new System.Drawing.Point(542, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(32, 32);
            this.btnReload.TabIndex = 11;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Image = global::bookshopsystem.Properties.Resources.search2_26px;
            this.btnSearch.Location = new System.Drawing.Point(298, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 25;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 8;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties8;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Search books / author / title / isbn";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(292, 35);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 3;
            this.txtSearch.TextMarginTop = 0;
            this.txtSearch.TextPlaceholder = "Search books / author / title / isbn";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            // 
            // cardItems_panel
            // 
            this.cardItems_panel.BackgroundColor = System.Drawing.Color.Transparent;
            this.cardItems_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardItems_panel.BackgroundImage")));
            this.cardItems_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardItems_panel.BorderColor = System.Drawing.Color.White;
            this.cardItems_panel.BorderRadius = 25;
            this.cardItems_panel.BorderThickness = 1;
            this.cardItems_panel.Controls.Add(this.itemlistFlowlayout_panel);
            this.cardItems_panel.Controls.Add(this.bunifuPanel3);
            this.cardItems_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.cardItems_panel.Location = new System.Drawing.Point(597, 10);
            this.cardItems_panel.Name = "cardItems_panel";
            this.cardItems_panel.Padding = new System.Windows.Forms.Padding(10);
            this.cardItems_panel.ShowBorders = true;
            this.cardItems_panel.Size = new System.Drawing.Size(350, 395);
            this.cardItems_panel.TabIndex = 7;
            // 
            // itemlistFlowlayout_panel
            // 
            this.itemlistFlowlayout_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemlistFlowlayout_panel.Location = new System.Drawing.Point(10, 10);
            this.itemlistFlowlayout_panel.Name = "itemlistFlowlayout_panel";
            this.itemlistFlowlayout_panel.Size = new System.Drawing.Size(330, 335);
            this.itemlistFlowlayout_panel.TabIndex = 1;
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.label1);
            this.bunifuPanel3.Controls.Add(this.lblTotal);
            this.bunifuPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuPanel3.Location = new System.Drawing.Point(10, 345);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(330, 40);
            this.bunifuPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(171, 3);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(159, 21);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "$2000";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 25;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.picBtnExit);
            this.bunifuPanel1.Controls.Add(this.lblStaffName);
            this.bunifuPanel1.Controls.Add(this.bunifuPictureBox1);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Controls.Add(this.lblDateTime);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(10, 10);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(947, 50);
            this.bunifuPanel1.TabIndex = 3;
            // 
            // picBtnExit
            // 
            this.picBtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBtnExit.BackColor = System.Drawing.Color.Transparent;
            this.picBtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("picBtnExit.Image")));
            this.picBtnExit.Location = new System.Drawing.Point(903, 6);
            this.picBtnExit.Name = "picBtnExit";
            this.picBtnExit.Size = new System.Drawing.Size(34, 38);
            this.picBtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBtnExit.TabIndex = 0;
            this.picBtnExit.TabStop = false;
            this.picBtnExit.Click += new System.EventHandler(this.picBtnExit_Click);
            // 
            // lblStaffName
            // 
            this.lblStaffName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaffName.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.ForeColor = System.Drawing.Color.White;
            this.lblStaffName.Location = new System.Drawing.Point(627, 15);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStaffName.Size = new System.Drawing.Size(224, 21);
            this.lblStaffName.TabIndex = 0;
            this.lblStaffName.Text = "Staff Name";
            this.lblStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 20;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(857, 5);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 3;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Gold;
            this.bunifuLabel1.Location = new System.Drawing.Point(13, 13);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(98, 25);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "Book Shop";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(140, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(162, 50);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "DateTime";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackgroundColor = System.Drawing.Color.Transparent;
            this.bottom_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottom_panel.BackgroundImage")));
            this.bottom_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottom_panel.BorderColor = System.Drawing.Color.Silver;
            this.bottom_panel.BorderRadius = 25;
            this.bottom_panel.BorderThickness = 1;
            this.bottom_panel.Controls.Add(this.btnPrev);
            this.bottom_panel.Controls.Add(this.btnNext);
            this.bottom_panel.Controls.Add(this.lblPage);
            this.bottom_panel.Controls.Add(this.btnFashCash);
            this.bottom_panel.Controls.Add(this.btnCheckout);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(10, 465);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.ShowBorders = true;
            this.bottom_panel.Size = new System.Drawing.Size(947, 50);
            this.bottom_panel.TabIndex = 5;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrev.Image = global::bookshopsystem.Properties.Resources.previous_26px;
            this.btnPrev.Location = new System.Drawing.Point(10, 9);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(32, 32);
            this.btnPrev.TabIndex = 15;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNext.Image = global::bookshopsystem.Properties.Resources.next_26px;
            this.btnNext.Location = new System.Drawing.Point(122, 9);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(32, 32);
            this.btnNext.TabIndex = 14;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPage
            // 
            this.lblPage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.White;
            this.lblPage.Location = new System.Drawing.Point(48, 9);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(68, 32);
            this.lblPage.TabIndex = 13;
            this.lblPage.Text = "Page {2}";
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFashCash
            // 
            this.btnFashCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFashCash.BackColor = System.Drawing.Color.SpringGreen;
            this.btnFashCash.FlatAppearance.BorderSize = 0;
            this.btnFashCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFashCash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFashCash.ForeColor = System.Drawing.Color.Black;
            this.btnFashCash.Image = ((System.Drawing.Image)(resources.GetObject("btnFashCash.Image")));
            this.btnFashCash.Location = new System.Drawing.Point(607, 5);
            this.btnFashCash.Name = "btnFashCash";
            this.btnFashCash.Size = new System.Drawing.Size(150, 38);
            this.btnFashCash.TabIndex = 1;
            this.btnFashCash.Text = "FashCash";
            this.btnFashCash.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFashCash.UseVisualStyleBackColor = false;
            this.btnFashCash.Click += new System.EventHandler(this.btnFashCash_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.ForeColor = System.Drawing.Color.Black;
            this.btnCheckout.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckout.Image")));
            this.btnCheckout.Location = new System.Drawing.Point(787, 6);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(150, 38);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(967, 525);
            this.ControlBox = false;
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bottom_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "POSForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "​​​​​​​POS Book Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.POSForm_Load);
            this.main_panel.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.cardItems_panel.ResumeLayout(false);
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.bottom_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblDateTime;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_Panel;
        private Bunifu.UI.WinForms.BunifuPanel cardItems_panel;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.FlowLayoutPanel itemlistFlowlayout_panel;
        private Bunifu.UI.WinForms.BunifuPanel bottom_panel;
        private System.Windows.Forms.PictureBox picBtnExit;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private System.Windows.Forms.Button btnFashCash;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnReload;
    }
}