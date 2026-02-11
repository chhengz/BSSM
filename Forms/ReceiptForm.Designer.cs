namespace bookshopsystem.Forms
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lvReceipt = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_ST = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.receipt_ID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_TAX = new System.Windows.Forms.Label();
            this.lb_GKH = new System.Windows.Forms.Label();
            this.lb_GUSD = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.receipt_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 74);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOOK SHOP";
            // 
            // lvReceipt
            // 
            this.lvReceipt.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvReceipt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Title,
            this.Qty,
            this.Price,
            this.Total});
            this.lvReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvReceipt.FullRowSelect = true;
            this.lvReceipt.GridLines = true;
            this.lvReceipt.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvReceipt.LabelWrap = false;
            this.lvReceipt.Location = new System.Drawing.Point(4, 78);
            this.lvReceipt.MultiSelect = false;
            this.lvReceipt.Name = "lvReceipt";
            this.lvReceipt.Size = new System.Drawing.Size(356, 499);
            this.lvReceipt.TabIndex = 3;
            this.lvReceipt.UseCompatibleStateImageBehavior = false;
            this.lvReceipt.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "#";
            this.No.Width = 24;
            // 
            // Title
            // 
            this.Title.Text = "Item";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Title.Width = 150;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_GUSD);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lb_GKH);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lb_TAX);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lb_ST);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(4, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 139);
            this.panel2.TabIndex = 4;
            // 
            // lb_ST
            // 
            this.lb_ST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ST.AutoSize = true;
            this.lb_ST.Location = new System.Drawing.Point(311, 10);
            this.lb_ST.Name = "lb_ST";
            this.lb_ST.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_ST.Size = new System.Drawing.Size(44, 13);
            this.lb_ST.TabIndex = 0;
            this.lb_ST.Text = "subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subtotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tax (10%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grand Total (KHR):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grand Total (USD):";
            // 
            // receipt_ID
            // 
            this.receipt_ID.AutoSize = true;
            this.receipt_ID.Location = new System.Drawing.Point(0, 50);
            this.receipt_ID.Name = "receipt_ID";
            this.receipt_ID.Size = new System.Drawing.Size(54, 13);
            this.receipt_ID.TabIndex = 5;
            this.receipt_ID.Text = "Receipt #";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Thank you! Come again ❤️";
            // 
            // lb_TAX
            // 
            this.lb_TAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TAX.AutoSize = true;
            this.lb_TAX.Location = new System.Drawing.Point(334, 30);
            this.lb_TAX.Name = "lb_TAX";
            this.lb_TAX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_TAX.Size = new System.Drawing.Size(21, 13);
            this.lb_TAX.TabIndex = 6;
            this.lb_TAX.Text = "tax";
            // 
            // lb_GKH
            // 
            this.lb_GKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_GKH.AutoSize = true;
            this.lb_GKH.Location = new System.Drawing.Point(311, 50);
            this.lb_GKH.Name = "lb_GKH";
            this.lb_GKH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_GKH.Size = new System.Drawing.Size(44, 13);
            this.lb_GKH.TabIndex = 7;
            this.lb_GKH.Text = "lb_GKH";
            // 
            // lb_GUSD
            // 
            this.lb_GUSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_GUSD.AutoSize = true;
            this.lb_GUSD.Location = new System.Drawing.Point(303, 70);
            this.lb_GUSD.Name = "lb_GUSD";
            this.lb_GUSD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_GUSD.Size = new System.Drawing.Size(52, 13);
            this.lb_GUSD.TabIndex = 8;
            this.lb_GUSD.Text = "lb_GUSD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tell: 099601858";
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lvReceipt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceiptForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvReceipt;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_ST;
        private System.Windows.Forms.Label receipt_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_TAX;
        private System.Windows.Forms.Label lb_GUSD;
        private System.Windows.Forms.Label lb_GKH;
        private System.Windows.Forms.Label label6;
    }
}