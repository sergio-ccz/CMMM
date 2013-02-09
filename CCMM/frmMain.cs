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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Creates needed forms
        frmNewPayment frmNewPayment;
        frmStudentSearch frmStudentSearch;
        frmNewStudent frmNewStudent;
        frmDailyReport frmDailyReport;
        frmReportCreation frmReportCreation;
        frmConceptCatalog frmConceptCatalog;
        //frmPaymentSearch frmPaymentSearch;
        //frmConceptConfiguration frmConceptConfiguration;

        private void mbtnNewPayment_Click(object sender, EventArgs e)
        {
            if (frmNewPayment == null || frmNewPayment.Visible == false)
            {
                frmNewPayment = new frmNewPayment();
                frmNewPayment.MdiParent = this;
                frmNewPayment.Show();
            }
        }

        private void mbtnPaySearch_Click(object sender, EventArgs e)
        {
        }

        private void mbtnStudentSearch_Click(object sender, EventArgs e)
        {
            if (frmStudentSearch == null || frmStudentSearch.Visible == false)
            {
                frmStudentSearch = new frmStudentSearch("normalSearch");
                frmStudentSearch.MdiParent = this;
                frmStudentSearch.Show();
            }
        }

        private void mbtnStudentRegistration_Click(object sender, EventArgs e)
        {
            if (frmNewStudent == null || frmNewStudent.Visible == false)
            {
                frmNewStudent = new frmNewStudent();
                frmNewStudent.MdiParent = this;
                frmNewStudent.Show();
            }
        }

        private void mbtnReports_Click(object sender, EventArgs e)
        {
        }

        private void mbtnDailyReport_Click(object sender, EventArgs e)
        {
            
        }

        private void mtbCombReport_Click(object sender, EventArgs e)
        {

        }

        private void mBtnSchoolEarnings_Click(object sender, EventArgs e)
        {
            if (frmDailyReport == null || frmDailyReport.Visible == false)
            {
                frmDailyReport = new frmDailyReport("School", "Earnings");
                frmDailyReport.MdiParent = this;
                frmDailyReport.Show();
            }
        }

        private void mbtnMedioEarnings_Click(object sender, EventArgs e)
        {
            if (frmDailyReport == null || frmDailyReport.Visible == false)
            {
                frmDailyReport = new frmDailyReport("Medio Internado", "Earnings");
                frmDailyReport.MdiParent = this;
                frmDailyReport.Show();
            }
        }

        private void mbtnSchoolDebts_Click(object sender, EventArgs e)
        {
            if (frmDailyReport == null || frmDailyReport.Visible == false)
            {
                frmDailyReport = new frmDailyReport("School", "Debt");
                frmDailyReport.MdiParent = this;
                frmDailyReport.Show();
            }
        }

        private void mbtnMedioDebts_Click(object sender, EventArgs e)
        {
            if (frmDailyReport == null || frmDailyReport.Visible == false)
            {
                frmDailyReport = new frmDailyReport("Medio Internado", "Debt");
                frmDailyReport.MdiParent = this;
                frmDailyReport.Show();
            }
        }

        private void mbtnConceptCatalog_Click(object sender, EventArgs e)
        {
            if (frmConceptCatalog == null || frmConceptCatalog.Visible == false)
            {
                frmConceptCatalog = new frmConceptCatalog();
                frmConceptCatalog.MdiParent = this;
                frmConceptCatalog.Show();
            }
        }

        private void nuevoCicloEscolarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
