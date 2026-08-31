using bookshopsystem.Core.Patterns;
using bookshopsystem.Services;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace bookshopsystem.Forms
{
    public partial class ReportsForm : Form
    {
        private readonly ReportService _service = new ReportService();
        private string _fileName = "";

        // ===================== ReportsForm Constructor =====================
        public ReportsForm()
        {
            InitializeComponent();
            ConfigureGrid();
        }

        // ===================== Configure Grid =====================
        private void ConfigureGrid()
        {
            dgvReports.AutoGenerateColumns = true;
            dgvReports.ReadOnly = true;
            dgvReports.AllowUserToAddRows = false;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // ===================== LOAD BUTTON =====================
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cbType.Text == "Daily")
            {
                dgvReports.DataSource = _service.GetDailySales(dtpDate.Value);
                _fileName = "Daily";
            }
            else if (cbType.Text == "Monthly")
            {
                dgvReports.DataSource = _service.GetMonthlySales(
                    dtpDate.Value.Year,
                    dtpDate.Value.Month);
                _fileName = "Monthly";
            }
            else if (cbType.Text == "Yearly")
            {
                dgvReports.DataSource = _service.GetYearlySales(
                    dtpDate.Value.Year);
                _fileName = "Yearly";
            }
            else 
                MessageBox.Show("Please select a report type.");

            //else if (cbType.Text == "Range")
            //    dgvReports.DataSource = _service.GetSalesByRange(
            //        dtpFrom.Value,
            //        dtpTo.Value);
        }

        // ===================== ExportCSV BUTTON =====================
        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (dgvReports.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.FileName = $"{_fileName}Sales_{DateTime.Now:yyyyMMdd}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportGridToCsv(sfd.FileName);
                    MessageBox.Show("Exported successfully.");
                }
            }
        }

        // ===================== Export to CSV =====================
        private void ExportGridToCsv(string path)
        {
            var csv = new CsvAdapter().FromGrid(dgvReports);
            File.WriteAllText(path, csv, Encoding.UTF8);
        }

        // ===================== ExportPDF BUTTON =====================
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (dgvReports.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.FileName = $"{_fileName}Sales_{DateTime.Now:yyyyMMdd}.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                    ExportGridToPdf(sfd.FileName);
                MessageBox.Show("Exported successfully.");
            }
        }

        // ===================== LOAD RANGE BUTTON =====================
        private void btnLoadRange_Click(object sender, EventArgs e)
        {
            using (var frm = new SalesByRangeForm())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dgvReports.DataSource =
                        _service.GetSalesByRange(frm.FromDate, frm.ToDate);
                }
            }
        }

        // ===================== CLEAR BUTTON =====================
        private void btnClear_Click(object sender, EventArgs e)
        {
            cbType.SelectedIndex = -1;
            cbType.Text = "Select Type";
            dgvReports.DataSource = null;
            dtpDate.Value = DateTime.Today;
        }


        // ===================== Export to PDF =====================
        private void ExportGridToPdf(string path)
        {
            Document doc = new Document(PageSize.A4, 10, 10, 10, 10);
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

            doc.Open();

            PdfPTable table = new PdfPTable(dgvReports.Columns.Count);
            table.WidthPercentage = 100;

            // Header
            foreach (DataGridViewColumn col in dgvReports.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText))
                {
                    BackgroundColor = BaseColor.LIGHT_GRAY
                };
                table.AddCell(cell);
            }

            // Rows
            foreach (DataGridViewRow row in dgvReports.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(cell.Value?.ToString() ?? "");
                }
            }

            doc.Add(new Paragraph("Sales Report\n\n"));
            doc.Add(table);
            doc.Close();
        }

    }


}
