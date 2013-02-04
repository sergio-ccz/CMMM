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
    public partial class frmConceptDetails : Form
    {
        public frmConceptDetails(int selectedConcept)
        {
            getInfo(selectedConcept);
            InitializeComponent();
        }

        private infoConcept _selectedConcept;

        private void getInfo(int selected)
        {
            _selectedConcept = DAL.getConceptInfo(selected);
        }

        private void frmConceptDetails_Load(object sender, EventArgs e)
        {
            txtbName.Text = _selectedConcept.Name;
            txtbAmount.Text = _selectedConcept.Amount.ToString();
            dateDueDate.Value = _selectedConcept.LimitDate;
        }
    }
}
