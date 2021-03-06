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

        private bool finishedLoading = false;
        frmStudentDetails frmStudentDetails;
        private List<infoConcept> ConceptList;
        private List<infoConcept> ConceptListAS;
        infoStudent selectedStudent = new infoStudent();
        infoStudent studentToPay = new infoStudent();

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            //Try to get account number
            frmStudentSearch frmSelectUserPayment = new frmStudentSearch("paymentSearch");
            //Show window to search for students
            frmSelectUserPayment.ShowDialog();

            //If a student was selected, show student ID on textbox
            if (frmSelectUserPayment.studentID != null && frmSelectUserPayment.studentID != "")
            {
                txtbAccNum.Text = frmSelectUserPayment.studentID;
            }

            //Dispose of search window
            frmSelectUserPayment.Dispose();
        }

        private void txtbAccNum_TextChanged(object sender, EventArgs e)
        {
            if (txtbAccNum.Text != "")
            {
                //Get the select student details (or try)
                selectedStudent = DAL.getStudentDetails(Int32.Parse(txtbAccNum.Text));
                studentToPay = selectedStudent;

                //If a student was actually found
                if (selectedStudent != null)
                {
                    //Flag to show that loading is in process
                    finishedLoading = false;

                    ConceptList = BAL.GetUnpayedConcepts(selectedStudent);

                    if (selectedStudent.paymentType == "Diferido")
                    {
                        BAL.ModifyDiferidoConcepts(ConceptList);
                    }

                    //Show the payment details box
                    gbxPaymentDetails.Visible = true;

                    //Load selected concept list depending on selected type
                    cbPaymentConcept.ValueMember = "Value";
                    cbPaymentConcept.DisplayMember = "Name";
                    cbPaymentConcept.DataSource = ConceptList;

                    //Enable controls and all that
                    cbPaymentConcept.Enabled = true;
                    picAccNumber.Image = (Image)CCMM.Properties.Resources.CheckMark;
                    llinkViewAccDetails.Visible = true;
                    llinkViewAccDetails.Text = "[" + selectedStudent.studentFistName + " " + selectedStudent.studentLastName + "]";
                    lblAccType.Text = "Tipo de Cuenta: " + selectedStudent.paymentType;
                                   
                    //Update amount
                    cbPaymentConcept_SelectedIndexChanged(null, null);
                    finishedLoading = true;
                    return;
                }
                else
                {
                    lblAccType.Text = "";
                    studentToPay = null;
                }
            }

            gbxPaymentDetails.Visible = false;
            llinkViewAccDetails.Visible = false;
            finishedLoading = false;
            picAccNumber.Image = (Image)Properties.Resources.Warning;
        }

        private void cbPaymentConcept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (finishedLoading || cbPaymentConcept.Items.Count > 0)
            {
                List<infoConcept> cList = new List<infoConcept>();
                cList = ConceptList;

                //Load selected concept list depending on selected type
                cbPaymentConcept.ValueMember = "Value";
                cbPaymentConcept.DisplayMember = "Name";
                cbPaymentConcept.DataSource = ConceptList;

                //Get base amounts for the selected concept
                foreach (infoConcept conceptEntry in cList)
                {
                    if (cbPaymentConcept.SelectedItem == conceptEntry)
                    {
                        //If the selected student has a discount, apply. Only works if a student is currently selected
                        if (studentToPay != null && studentToPay.paymentDiscount > 0)
                        {
                            double paymentAmount = conceptEntry.Amount - (conceptEntry.Amount * ((studentToPay.paymentDiscount) * .01));
                            txtbPaymentAmount.Text = paymentAmount.ToString();
                            picDiscountWarning.Image = (Image)Properties.Resources.Warning;
                        }
                        else
                        {
                            //If no student is selected, or student has no discount, just display the base amount
                            txtbPaymentAmount.Text = conceptEntry.Amount.ToString();
                            picDiscountWarning.Image = null;
                        }
                    }
                }

                double overcharge = BAL.CalculateOvercharge(selectedStudent);

                if (overcharge > 0)
                {
                    txtbPaymentAmount.Text = (double.Parse(txtbPaymentAmount.Text) + overcharge).ToString();
                    picDiscountWarning.Image = (Image)Properties.Resources.Warning;
                }
            }
        }

        private void frmNewPayment_Load(object sender, EventArgs e)
        {
        }

        private void cbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (finishedLoading)
            {
                //For normal payments, grab the concepts that a normal student would pay
                cbPaymentConcept.DataSource = null;
                cbPaymentConcept.Items.Clear();

                cbPaymentConcept.ValueMember = "Value";
                cbPaymentConcept.DisplayMember = "Name";

                cbPaymentConcept.DataSource = ConceptList;
                //cbPaymentConcept.DataSource = BAL.getAvailableConcepts(selectedStudent.studentID, "School", cbShowAllConcepts.Checked);
            }
        }

        private void llinkViewAccDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmStudentDetails = new frmStudentDetails(Int32.Parse(txtbAccNum.Text), false);
            frmStudentDetails.ShowDialog();
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            //Send list with different values to create a new payment
            List<string> paymentDetails = new List<string>();

            //Verify that the new [Folio] doesn't exist already
            if (txtbPaymentFolio.Text != "" && DAL.checkFolio(txtbPaymentFolio.Text))
            {
                MessageBox.Show("Este folio ya existe, por favor ingresar uno nuevo");
                return;
            }

            try
            {
                paymentDetails.Add(txtbPaymentFolio.Text);
                paymentDetails.Add(txtbPaymentAmount.Text);
                paymentDetails.Add(datePaymentDate.Value.ToString());
                paymentDetails.Add(cbPaymentComplete.Checked.ToString());
                paymentDetails.Add(selectedStudent.studentID.ToString());
                paymentDetails.Add(cbPaymentConcept.SelectedValue.ToString());

                //Send list to parse and then to insert on database
                BAL.CreateNewPayment(paymentDetails);

                DialogResult sameStudent = MessageBox.Show("Pago registrado - ¿Seguir con mismo alumno?", "Nuevo Pago", MessageBoxButtons.YesNo);
                if (sameStudent == System.Windows.Forms.DialogResult.No)
                    txtbAccNum.Clear();
                else
                {
                    txtbPaymentAmount.Clear();
                    datePaymentDate.Value = DateTime.Now;
                    ConceptList = BAL.GetUnpayedConcepts(selectedStudent);
                    ReloadLists();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error, por favor de verificar los datos");
                return;
            }
        }

        private void cbShowAllConcepts_CheckedChanged(object sender, EventArgs e)
        {
            finishedLoading = false;

            if (cbShowAllConcepts.Checked)
                ConceptList = DAL.getAvailableConcepts(studentToPay.studentGroup, studentToPay.studentLevel);
            else
                ConceptList = BAL.GetUnpayedConcepts(selectedStudent);
                        
            ReloadLists();
            
            finishedLoading = true;
            
        }

        private void ReloadLists()
        {
            cbPaymentConcept.DataSource = null;
            cbPaymentConcept.Items.Clear();
            cbPaymentConcept.Text = "";

            txtbPaymentAmount.Clear();
            cbPaymentConcept.DataSource = ConceptList;

            cbPaymentConcept.ValueMember = "Value";
            cbPaymentConcept.DisplayMember = "Name";

            cbPaymentConcept.SelectedIndex = 0;

        }

        private void txtbPaymentFolio_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
