namespace bookshopsystem.Forms
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoadRange = new System.Windows.Forms.Button();
            this.dtpDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReports
            // 
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReports.GridColor = System.Drawing.Color.White;
            this.dgvReports.Location = new System.Drawing.Point(0, 0);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.Size = new System.Drawing.Size(886, 346);
            this.dgvReports.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportPDF);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnLoadRange);
            this.panel1.Controls.Add(this.cbType);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.btnExportCSV);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 104);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvReports);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 346);
            this.panel2.TabIndex = 5;
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.DarkCyan;
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.ForeColor = System.Drawing.Color.White;
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 21;
            this.cbType.Items.AddRange(new object[] {
            "Daily",
            "Monthly",
            "Yearly"});
            this.cbType.Location = new System.Drawing.Point(238, 15);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(220, 29);
            this.cbType.TabIndex = 5;
            this.cbType.Text = "Reporting Period";
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPDF.BackColor = System.Drawing.Color.Brown;
            this.btnExportPDF.FlatAppearance.BorderSize = 0;
            this.btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPDF.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportPDF.Image = global::bookshopsystem.Properties.Resources.pdf_18px;
            this.btnExportPDF.Location = new System.Drawing.Point(724, 50);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(150, 32);
            this.btnExportPDF.TabIndex = 10;
            this.btnExportPDF.Text = "Export to PDF";
            this.btnExportPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExportPDF.UseVisualStyleBackColor = false;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::bookshopsystem.Properties.Resources.broom_26px;
            this.btnClear.Location = new System.Drawing.Point(168, 59);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 32);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Data";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoadRange
            // 
            this.btnLoadRange.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoadRange.FlatAppearance.BorderSize = 0;
            this.btnLoadRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadRange.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadRange.ForeColor = System.Drawing.Color.White;
            this.btnLoadRange.Image = global::bookshopsystem.Properties.Resources.filter_18px;
            this.btnLoadRange.Location = new System.Drawing.Point(12, 59);
            this.btnLoadRange.Name = "btnLoadRange";
            this.btnLoadRange.Size = new System.Drawing.Size(150, 32);
            this.btnLoadRange.TabIndex = 8;
            this.btnLoadRange.Text = "Sales By Range";
            this.btnLoadRange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadRange.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLoadRange.UseVisualStyleBackColor = false;
            this.btnLoadRange.Click += new System.EventHandler(this.btnLoadRange_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpDate.BorderRadius = 12;
            this.dtpDate.Color = System.Drawing.Color.Silver;
            this.dtpDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpDate.DisabledColor = System.Drawing.Color.Gray;
            this.dtpDate.DisplayWeekNumbers = false;
            this.dtpDate.DPHeight = 0;
            this.dtpDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDate.FillDatePicker = false;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.ForeColor = System.Drawing.Color.White;
            this.dtpDate.Icon = ((System.Drawing.Image)(resources.GetObject("dtpDate.Icon")));
            this.dtpDate.IconColor = System.Drawing.Color.White;
            this.dtpDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpDate.LeftTextMargin = 5;
            this.dtpDate.Location = new System.Drawing.Point(12, 12);
            this.dtpDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(220, 32);
            this.dtpDate.TabIndex = 4;
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCSV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExportCSV.FlatAppearance.BorderSize = 0;
            this.btnExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCSV.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportCSV.ForeColor = System.Drawing.Color.White;
            this.btnExportCSV.Image = global::bookshopsystem.Properties.Resources.csv_18px;
            this.btnExportCSV.Location = new System.Drawing.Point(724, 12);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(150, 32);
            this.btnExportCSV.TabIndex = 3;
            this.btnExportCSV.Text = "Export to CSV";
            this.btnExportCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExportCSV.UseVisualStyleBackColor = false;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Tomato;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Image = global::bookshopsystem.Properties.Resources.add_list_18px;
            this.btnLoad.Location = new System.Drawing.Point(464, 15);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(150, 32);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpDate;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnLoadRange;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExportPDF;
    }
}