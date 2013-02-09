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
        /// <summary>
        /// Constructor for the report printing form
        /// </summary>
        /// <param name="levelReport">"School" or "Medio Internado"</param>
        /// <param name="typeReport">"Debt" or "Earnings"</param>
        public frmDailyReport(string levelReport, string typeReport )
        {
            LevelReport = levelReport;
            TypeReport = typeReport;
            InitializeComponent();
            LoadTexts();
        }

        private void frmDailyReport_Load(object sender, EventArgs e)
        {
            UpdateGridResults();
        }

        private void LoadTexts()
        {
            string infoLabelText = string.Empty;

            if (TypeReport == "Earnings")
            {
                infoLabelText += "Reporte de Ingresos ";
                gbDates.Visible = true;
            }
            else
            {
                infoLabelText += "Reporte de Adeudos ";
                gbDates.Visible = false;
            }

            if (LevelReport == "School")
            {
                infoLabelText += "Escolares";
            }
            else
            {
                infoLabelText += "de Medio Internado";
            }

            lblInfo1.Text = infoLabelText;
        }

        //Level = School/Medio Internado
        public string LevelReport { get; set; }
        
        //Earnings or Debt report
        public string TypeReport { get; set; }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DateTime? toDate = dtpPaymentDate2.Value.Date;
            if (toDate == dtpPaymentDate.Value.Date)
                toDate = null;

            int msReport = 1;

            if (LevelReport == "Medio Internado")
                msReport = 2;

            if (TypeReport == "Earnings")
            {
                //Last parameter = (T) School (F) Medio Internado
                bool schoolOnlyReport = true;

                if (LevelReport != "School")
                    schoolOnlyReport = false;


                List<string[]> reportInfo = DAL.SchoolPaymentsInfo(dtpPaymentDate.Value.Date, toDate, schoolOnlyReport);

                if (reportInfo.Count < 1)
                {
                    MessageBox.Show("No hay datos para imprimir en la(s) fecha(s) seleccionada");
                    return;
                }

                Printing.PrintReport(reportInfo, TypeReport, dtpPaymentDate.Value.Date, LevelReport);
            }
            else
            {
                //Debt Report
                List<string[]> reportInfo = BAL.getExpiredConceptsAll(msReport);

                if (reportInfo.Count < 1)
                {
                    MessageBox.Show("No hay datos para imprimir en la(s) fecha(s) seleccionada");
                    return;
                }

                Printing.PrintReport(reportInfo, TypeReport, dtpPaymentDate.Value.Date, LevelReport);
            }
        }

        private void dtpPaymentDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateGridResults();
        }

        private void dtpPaymentDate2_ValueChanged(object sender, EventArgs e)
        {
            UpdateGridResults();
        }

        private void UpdateGridResults()
        {
            try
            {
                if (TypeReport == "Debt")
                {
                    dgridPaymentTable.Visible = false;
                    lblWarnings.Visible = true;
                }
                bool schoolOnly = true;

                if (LevelReport != "School")
                    schoolOnly = false;

                DateTime? toDate = dtpPaymentDate2.Value.Date;

                if (toDate == dtpPaymentDate.Value.Date)
                    toDate = null;

                DateTime selectedDate = dtpPaymentDate.Value.Date;
                dgridPaymentTable.DataSource = DAL.getPaymentsByDate(selectedDate, toDate, schoolOnly);
            }
            catch
            {
                dgridPaymentTable.DataSource = null;
            }
        }

        private void dtpPaymentDate_ValueChanged_1(object sender, EventArgs e)
        {
            UpdateGridResults();
        }

        private void dtpPaymentDate2_ValueChanged_1(object sender, EventArgs e)
        {
            UpdateGridResults();
        }
    }
}
