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
    public partial class frmPaymentDetails : Form
    {
        public frmPaymentDetails(List<string> paymentInfo)
        {
            InitializeComponent();
            PaymentInformation = paymentInfo;
            PaymentID = int.Parse(paymentInfo[5]);
            updatedInfo = false;
        }

        public List<string> PaymentInformation { get; set; }
        private int PaymentID;
        public bool updatedInfo { get; set; }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esto borrara el registro", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DAL.DeletePayment(PaymentID);
                updatedInfo = true;
                this.Close();
            }
        }

        private void frmPaymentDetails_Load(object sender, EventArgs e)
        {
            txtbFolio.Text = PaymentInformation[0];
            txtbAmount.Text = PaymentInformation[1];
            datePayment.Value = DateTime.Parse(PaymentInformation[2]);
            lblPaymentTitle.Text = "Concepto: " + PaymentInformation[4];
            chkCompleted.Checked = bool.Parse(PaymentInformation[3]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int coc;
            double cic;

            if (txtbFolio.Text == "" || !int.TryParse(txtbFolio.Text, out coc))
            {
                 lblInfo.Text = "Capturar un folio";
                 lblInfo.ForeColor = Color.Red;
                return;
            }

            if (txtbAmount.Text == "" || !double.TryParse(txtbAmount.Text, out cic))
            {
                 lblInfo.Text = "Capturar cantidad adecuada";
                 lblInfo.ForeColor = Color.Red;
                return;
            }

            //Verify that the new [Folio] doesn't exist already
            if (txtbFolio.Text != PaymentInformation[0] && DAL.checkFolio(txtbFolio.Text))
            {
                lblInfo.Text = "Este folio ya existe, por favor ingresar uno nuevo";
                lblInfo.ForeColor = Color.Red;
                return;
            }

            //Create updated values List<>
            //Folio, amount, value, concept, id

            List<string> updatedPayment = new List<string>();
            updatedPayment.Add(txtbFolio.Text);
            updatedPayment.Add(txtbAmount.Text);
            updatedPayment.Add(datePayment.Value.ToShortDateString());
            updatedPayment.Add(chkCompleted.Checked.ToString());
            updatedPayment.Add(PaymentInformation[4]);
            updatedPayment.Add(PaymentInformation[5]);

            try
            {
                DAL.UpdatePayment(updatedPayment);
                lblInfo.Text = "Entrada actualizada";
                lblInfo.ForeColor = Color.Green;
                updatedInfo = true;
            }
            catch
            {
                lblInfo.Text = "Ocurrio un error, tratar de nuevo";
                lblInfo.ForeColor = Color.Red;
            }

        }
    }
}
