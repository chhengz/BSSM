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
    public partial class QRPayForm : Form
    {
        public QRPayForm(String total)
        {
            InitializeComponent();
            lblTotal.Text = $"${total}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
