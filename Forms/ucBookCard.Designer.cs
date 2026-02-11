namespace bookshopsystem.Forms
{
    partial class ucBookCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBookCard));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pic_panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.picBookCover = new System.Windows.Forms.PictureBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bunifuPanel1.SuspendLayout();
            this.pic_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(87)))), ((int)(((byte)(75)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuPanel1.BorderRadius = 25;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.pic_panel);
            this.bunifuPanel1.Controls.Add(this.lblStock);
            this.bunifuPanel1.Controls.Add(this.lblPrice);
            this.bunifuPanel1.Controls.Add(this.lblTitle);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(150, 260);
            this.bunifuPanel1.TabIndex = 3;
            // 
            // pic_panel
            // 
            this.pic_panel.BackgroundColor = System.Drawing.Color.Transparent;
            this.pic_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_panel.BackgroundImage")));
            this.pic_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_panel.BorderColor = System.Drawing.Color.Silver;
            this.pic_panel.BorderRadius = 22;
            this.pic_panel.BorderThickness = 1;
            this.pic_panel.Controls.Add(this.picBookCover);
            this.pic_panel.Location = new System.Drawing.Point(13, 13);
            this.pic_panel.Name = "pic_panel";
            this.pic_panel.ShowBorders = true;
            this.pic_panel.Size = new System.Drawing.Size(124, 160);
            this.pic_panel.TabIndex = 3;
            // 
            // picBookCover
            // 
            this.picBookCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBookCover.ErrorImage = global::bookshopsystem.Properties.Resources.no_image;
            this.picBookCover.Location = new System.Drawing.Point(0, 0);
            this.picBookCover.Name = "picBookCover";
            this.picBookCover.Size = new System.Drawing.Size(124, 160);
            this.picBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBookCover.TabIndex = 1;
            this.picBookCover.TabStop = false;
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(87)))), ((int)(((byte)(75)))));
            this.lblStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.Coral;
            this.lblStock.Location = new System.Drawing.Point(13, 232);
            this.lblStock.Name = "lblStock";
            this.lblStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStock.Size = new System.Drawing.Size(124, 17);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "lblStock";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(87)))), ((int)(((byte)(75)))));
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblPrice.Location = new System.Drawing.Point(13, 215);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(121, 17);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "lblPrice";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(87)))), ((int)(((byte)(75)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 176);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucBookCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "ucBookCard";
            this.Size = new System.Drawing.Size(150, 260);
            this.bunifuPanel1.ResumeLayout(false);
            this.pic_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBookCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel pic_panel;
        private System.Windows.Forms.PictureBox picBookCover;
    }
}
