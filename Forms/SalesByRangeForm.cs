using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookshopsystem.Forms
{
    public partial class SalesByRangeForm : Form
    {
        public DateTime FromDate => dtpFrom.Value;
        public DateTime ToDate => dtpTo.Value;

        // ===================== SalesByRangeForm Constructor =====================
        public SalesByRangeForm()
        {
            InitializeComponent();
        }

        // ===================== FORM LOAD =====================
        private void SalesByRangeForm_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddDays(-7);
            dtpTo.Value = DateTime.Today;
        }

        // ===================== OK BUTTON =====================
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value > dtpTo.Value)
            {
                MessageBox.Show("From date cannot be after To date.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        
    }
}
