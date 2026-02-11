namespace bookshopsystem.Forms
{
    partial class SalesByRangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesByRangeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpTo = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dtpFrom = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Datetime Range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(254, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "To";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(495, 77);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(144, 32);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "Apply";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(87)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 40);
            this.panel1.TabIndex = 14;
            // 
            // dtpTo
            // 
            this.dtpTo.BackColor = System.Drawing.Color.Transparent;
            this.dtpTo.BorderRadius = 12;
            this.dtpTo.Color = System.Drawing.Color.Silver;
            this.dtpTo.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpTo.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpTo.DisabledColor = System.Drawing.Color.Gray;
            this.dtpTo.DisplayWeekNumbers = false;
            this.dtpTo.DPHeight = 0;
            this.dtpTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpTo.FillDatePicker = false;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.ForeColor = System.Drawing.Color.White;
            this.dtpTo.Icon = ((System.Drawing.Image)(resources.GetObject("dtpTo.Icon")));
            this.dtpTo.IconColor = System.Drawing.Color.White;
            this.dtpTo.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpTo.LeftTextMargin = 5;
            this.dtpTo.Location = new System.Drawing.Point(249, 77);
            this.dtpTo.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(220, 32);
            this.dtpTo.TabIndex = 9;
            // 
            // dtpFrom
            // 
            this.dtpFrom.BackColor = System.Drawing.Color.Transparent;
            this.dtpFrom.BorderRadius = 12;
            this.dtpFrom.Color = System.Drawing.Color.Silver;
            this.dtpFrom.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpFrom.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpFrom.DisabledColor = System.Drawing.Color.Gray;
            this.dtpFrom.DisplayWeekNumbers = false;
            this.dtpFrom.DPHeight = 0;
            this.dtpFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFrom.FillDatePicker = false;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.ForeColor = System.Drawing.Color.White;
            this.dtpFrom.Icon = ((System.Drawing.Image)(resources.GetObject("dtpFrom.Icon")));
            this.dtpFrom.IconColor = System.Drawing.Color.White;
            this.dtpFrom.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpFrom.LeftTextMargin = 5;
            this.dtpFrom.Location = new System.Drawing.Point(7, 77);
            this.dtpFrom.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(220, 32);
            this.dtpFrom.TabIndex = 8;
            // 
            // SalesByRangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(651, 135);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesByRangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Date Form";
            this.Load += new System.EventHandler(this.SalesByRangeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDatePicker dtpTo;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
    }
}