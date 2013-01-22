using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CCMM
{
    public partial class frmDailyReport : Form
    {
        public frmDailyReport()
        {
            InitializeComponent();
        }

        private void frmDailyReport_Load(object sender, EventArgs e)
        {
            dgridPaymentTable.DataSource = DAL.getPaymentsByDate(DateTime.Now.Date, null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        { 
        }

        private void btnDataPreview_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpPaymentDate.Value;
            dgridPaymentTable.DataSource = DAL.getPaymentsByDate(selectedDate, null);
        }
    }
}
