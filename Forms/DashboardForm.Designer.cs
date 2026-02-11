namespace bookshopsystem.Forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.mainForm_panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.sidebar_panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnStaffForm = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSaleForm = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnBookForm = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.picBtnExit = new System.Windows.Forms.PictureBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.sidebar_panel.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // mainForm_panel
            // 
            this.mainForm_panel.BackgroundColor = System.Drawing.Color.Transparent;
            this.mainForm_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainForm_panel.BackgroundImage")));
            this.mainForm_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainForm_panel.BorderColor = System.Drawing.Color.Transparent;
            this.mainForm_panel.BorderRadius = 3;
            this.mainForm_panel.BorderThickness = 0;
            this.mainForm_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainForm_panel.Location = new System.Drawing.Point(10, 50);
            this.mainForm_panel.Name = "mainForm_panel";
            this.mainForm_panel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.mainForm_panel.ShowBorders = false;
            this.mainForm_panel.Size = new System.Drawing.Size(798, 515);
            this.mainForm_panel.TabIndex = 1;
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(87)))), ((int)(((byte)(75)))));
            this.sidebar_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidebar_panel.BackgroundImage")));
            this.sidebar_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidebar_panel.BorderColor = System.Drawing.Color.Transparent;
            this.sidebar_panel.BorderRadius = 25;
            this.sidebar_panel.BorderThickness = 1;
            this.sidebar_panel.Controls.Add(this.btnStaffForm);
            this.sidebar_panel.Controls.Add(this.btnSaleForm);
            this.sidebar_panel.Controls.Add(this.btnBookForm);
            this.sidebar_panel.Controls.Add(this.bunifuPanel3);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar_panel.Location = new System.Drawing.Point(10, 10);
            this.sidebar_panel.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.ShowBorders = true;
            this.sidebar_panel.Size = new System.Drawing.Size(120, 575);
            this.sidebar_panel.TabIndex = 0;
            // 
            // btnStaffForm
            // 
            this.btnStaffForm.BackColor = System.Drawing.Color.Transparent;
            this.btnStaffForm.color = System.Drawing.Color.Transparent;
            this.btnStaffForm.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.btnStaffForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffForm.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnStaffForm.ForeColor = System.Drawing.Color.White;
            this.btnStaffForm.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffForm.Image")));
            this.btnStaffForm.ImagePosition = 10;
            this.btnStaffForm.ImageZoom = 48;
            this.btnStaffForm.LabelPosition = 40;
            this.btnStaffForm.LabelText = "Staffs";
            this.btnStaffForm.Location = new System.Drawing.Point(10, 344);
            this.btnStaffForm.Margin = new System.Windows.Forms.Padding(6);
            this.btnStaffForm.Name = "btnStaffForm";
            this.btnStaffForm.Size = new System.Drawing.Size(100, 100);
            this.btnStaffForm.TabIndex = 2;
            this.btnStaffForm.Click += new System.EventHandler(this.btnStaffForm_Click);
            // 
            // btnSaleForm
            // 
            this.btnSaleForm.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleForm.color = System.Drawing.Color.Transparent;
            this.btnSaleForm.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.btnSaleForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaleForm.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnSaleForm.ForeColor = System.Drawing.Color.White;
            this.btnSaleForm.Image = ((System.Drawing.Image)(resources.GetObject("btnSaleForm.Image")));
            this.btnSaleForm.ImagePosition = 10;
            this.btnSaleForm.ImageZoom = 48;
            this.btnSaleForm.LabelPosition = 40;
            this.btnSaleForm.LabelText = "Sales";
            this.btnSaleForm.Location = new System.Drawing.Point(10, 232);
            this.btnSaleForm.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaleForm.Name = "btnSaleForm";
            this.btnSaleForm.Size = new System.Drawing.Size(100, 100);
            this.btnSaleForm.TabIndex = 1;
            this.btnSaleForm.Click += new System.EventHandler(this.btnSaleForm_Click);
            // 
            // btnBookForm
            // 
            this.btnBookForm.BackColor = System.Drawing.Color.Transparent;
            this.btnBookForm.color = System.Drawing.Color.Transparent;
            this.btnBookForm.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.btnBookForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookForm.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnBookForm.ForeColor = System.Drawing.Color.White;
            this.btnBookForm.Image = ((System.Drawing.Image)(resources.GetObject("btnBookForm.Image")));
            this.btnBookForm.ImagePosition = 10;
            this.btnBookForm.ImageZoom = 48;
            this.btnBookForm.LabelPosition = 40;
            this.btnBookForm.LabelText = "Book";
            this.btnBookForm.Location = new System.Drawing.Point(10, 120);
            this.btnBookForm.Margin = new System.Windows.Forms.Padding(6);
            this.btnBookForm.Name = "btnBookForm";
            this.btnBookForm.Size = new System.Drawing.Size(100, 100);
            this.btnBookForm.TabIndex = 0;
            this.btnBookForm.Click += new System.EventHandler(this.btnBookForm_Click);
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 25;
            this.bunifuPanel3.BorderThickness = 0;
            this.bunifuPanel3.Controls.Add(this.bunifuPictureBox1);
            this.bunifuPanel3.Location = new System.Drawing.Point(10, 11);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(100, 100);
            this.bunifuPanel3.TabIndex = 0;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 40;
            this.bunifuPictureBox1.Image = global::bookshopsystem.Properties.Resources.RUPP_logo;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(10, 10);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(80, 80);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 3;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainForm_panel);
            this.panel1.Controls.Add(this.bunifuPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(130, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(818, 575);
            this.panel1.TabIndex = 2;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 25;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.lblDateTime);
            this.bunifuPanel1.Controls.Add(this.picBtnExit);
            this.bunifuPanel1.Controls.Add(this.lblStaffName);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(10, 10);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(798, 40);
            this.bunifuPanel1.TabIndex = 4;
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(126, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(321, 40);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "DateTime";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picBtnExit
            // 
            this.picBtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBtnExit.BackColor = System.Drawing.Color.Transparent;
            this.picBtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("picBtnExit.Image")));
            this.picBtnExit.Location = new System.Drawing.Point(760, 5);
            this.picBtnExit.Name = "picBtnExit";
            this.picBtnExit.Size = new System.Drawing.Size(30, 30);
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
            this.lblStaffName.Location = new System.Drawing.Point(524, 10);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStaffName.Size = new System.Drawing.Size(224, 21);
            this.lblStaffName.TabIndex = 0;
            this.lblStaffName.Text = "Staff Name";
            this.lblStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Gold;
            this.bunifuLabel1.Location = new System.Drawing.Point(13, 8);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(98, 25);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "Book Shop";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(958, 595);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "DashboardForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Shop | Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sidebar_panel.ResumeLayout(false);
            this.bunifuPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel sidebar_panel;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuPanel mainForm_panel;
        private Bunifu.Framework.UI.BunifuTileButton btnBookForm;
        private Bunifu.Framework.UI.BunifuTileButton btnStaffForm;
        private Bunifu.Framework.UI.BunifuTileButton btnSaleForm;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.PictureBox picBtnExit;
        private System.Windows.Forms.Label lblStaffName;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Label lblDateTime;
    }
}