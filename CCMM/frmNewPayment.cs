﻿using System;
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
                DataAccess dAccessObject = new DataAccess();
                List<string> selectedStudent = dAccessObject.getStudentDetails(Int32.Parse(txtbAccNum.Text));
                studentToPay = selectedStudent;

                //Clean concept list to add new ones for new student.
                cbPaymentConcept.DataSource = null;
                cbPaymentConcept.Items.Clear();
                txtbPaymentAmount.Clear();
                cbPaymentConcept.Text = "";
                cbPaymentConcept.Enabled = false;

                if (selectedStudent.Count != 0)
                {
                    gbxPaymentDetails.Visible = true;

                    cbPaymentConcept.Enabled = true;
                    picAccNumber.Image = (Image)CCMM.Properties.Resources.CheckMark;
                    llinkViewAccDetails.Visible = true;
                    llinkViewAccDetails.Text = "[" + selectedStudent[1] + " " + selectedStudent[2] + "]";

                    //Load concept list into ComboBox [cbPaymentConcept]
                    ConceptList = dAccessObject.getAvailableConcepts(int.Parse(selectedStudent[4]), int.Parse(selectedStudent[5]));
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


    }
}