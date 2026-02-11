namespace bookshopsystem.Forms
{
    partial class ucItemCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucItemCard));
            this.lblName = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnPlus = new System.Windows.Forms.PictureBox();
            this.btnMinus = new System.Windows.Forms.PictureBox();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(8, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(203, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "lblName";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQty
            // 
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.White;
            this.lblQty.Location = new System.Drawing.Point(248, 13);
            this.lblQty.Name = "lblQty";
            this.lblQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQty.Size = new System.Drawing.Size(30, 23);
            this.lblQty.TabIndex = 1;
            this.lblQty.Text = "10";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Orange;
            this.lblPrice.Location = new System.Drawing.Point(8, 26);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "lblPrice";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(87)))), ((int)(((byte)(75)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel1.BorderRadius = 25;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnPlus);
            this.bunifuPanel1.Controls.Add(this.btnMinus);
            this.bunifuPanel1.Controls.Add(this.lblPrice);
            this.bunifuPanel1.Controls.Add(this.lblQty);
            this.bunifuPanel1.Controls.Add(this.lblName);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(320, 50);
            this.bunifuPanel1.TabIndex = 5;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Image = global::bookshopsystem.Properties.Resources.plus_26px;
            this.btnPlus.Location = new System.Drawing.Point(284, 11);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(28, 28);
            this.btnPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlus.TabIndex = 6;
            this.btnPlus.TabStop = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.Image = global::bookshopsystem.Properties.Resources.minus_26px;
            this.btnMinus.Location = new System.Drawing.Point(214, 11);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(28, 28);
            this.btnMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinus.TabIndex = 5;
            this.btnMinus.TabStop = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // ucItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "ucItemCard";
            this.Size = new System.Drawing.Size(320, 50);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPrice;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.PictureBox btnMinus;
        private System.Windows.Forms.PictureBox btnPlus;
    }
}
