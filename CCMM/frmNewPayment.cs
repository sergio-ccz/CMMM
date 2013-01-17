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
    public partial class frmNewPayment : Form
    {
        public frmNewPayment()
        {
            InitializeComponent();
        }

        frmStudentDetails frmStudentDetails;
        private List<GenericObject> ConceptList;
        private List<string> studentToPay = null;

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            //Try to get account number
            frmStudentSearch frmSelectUserPayment = new frmStudentSearch("paymentSearch");
            frmSelectUserPayment.ShowDialog();

            if (frmSelectUserPayment.studentID != null && frmSelectUserPayment.studentID != "")
            {
                txtbAccNum.Text = frmSelectUserPayment.studentID;
            }
            frmSelectUserPayment.Dispose();
        }

        private void txtbAccNum_TextChanged(object sender, EventArgs e)
        {
            if (txtbAccNum.Text != "")
            {
                //Get the select student details (or try)
                List<string> selectedStudent = DAL.getStudentDetails(Int32.Parse(txtbAccNum.Text));
                studentToPay = selectedStudent;
                cbPaymentType.SelectedIndex = 0;

                //Clean concept list to add new ones for new student.
                cbPaymentConcept.DataSource = null;
                cbPaymentConcept.Items.Clear();
                txtbPaymentAmount.Clear();
                cbPaymentConcept.Text = "";
                cbPaymentConcept.Enabled = false;

                //If a student was actually found
                if (selectedStudent.Count != 0)
                {
                    //Show the payment details box
                    gbxPaymentDetails.Visible = true;

                    //Enable controls and all that
                    cbPaymentConcept.Enabled = true;
                    picAccNumber.Image = (Image)CCMM.Properties.Resources.CheckMark;
                    llinkViewAccDetails.Visible = true;
                    llinkViewAccDetails.Text = "[" + selectedStudent[1] + " " + selectedStudent[2] + "]";

                    //Load concept list into ComboBox [cbPaymentConcept]
                    ConceptList = DAL.getAvailableConcepts(int.Parse(selectedStudent[4]), int.Parse(selectedStudent[5]));
                    cbPaymentConcept.ValueMember = "Value";
                    cbPaymentConcept.DisplayMember = "Name";
                    cbPaymentConcept.DataSource = ConceptList;


                    //Update amount
                    cbPaymentConcept_SelectedIndexChanged(null, null);
                    return;
                }
                else
                {
                    studentToPay = null;
                }
            }

            gbxPaymentDetails.Visible = false;
            llinkViewAccDetails.Visible = false;
            picAccNumber.Image = (Image)Properties.Resources.Warning;
        }

        private void cbPaymentConcept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmNewPayment_Load(object sender, EventArgs e)
        {
            cbPaymentType.Items.Add("Escolar");
            cbPaymentType.Items.Add("Medio Internado");

            cbPaymentType.SelectedIndex = 0;
        }

        private void cbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //For normal payments, grab the concepts that a normal student would pay
            if (cbPaymentType.SelectedText == "Escolar")
            {

            }

            if (cbPaymentType.SelectedText == "Medio Internado")
            {
            }
        }

        private void llinkViewAccDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmStudentDetails = new frmStudentDetails(Int32.Parse(txtbAccNum.Text), false);
            frmStudentDetails.ShowDialog();
        }


    }
}
