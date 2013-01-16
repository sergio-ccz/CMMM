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
        frmStudentSearch frmSearchStudent;
        //frmNewStudent frmNewStudent;
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
            DAL.setWeeksforYear();
        }
    }
}
