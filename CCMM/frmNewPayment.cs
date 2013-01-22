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

                    ReloadLists();

                    //Show the payment details box
                    gbxPaymentDetails.Visible = true;

                    //Load selected concept list depending on selected type
                    cbPaymentConcept.ValueMember = "Value";
                    cbPaymentConcept.DisplayMember = "Name";

                    if(cbPaymentType.SelectedItem.ToString() == "Pagos Escolares")
                        cbPaymentConcept.DataSource = ConceptList;
                    else
                        cbPaymentConcept.DataSource = ConceptListAS;

                    //Enable controls and all that
                    cbPaymentConcept.Enabled = true;
                    picAccNumber.Image = (Image)CCMM.Properties.Resources.CheckMark;
                    llinkViewAccDetails.Visible = true;
                    llinkViewAccDetails.Text = "[" + selectedStudent.studentFistName + " " + selectedStudent.studentLastName + "]";
                                   
                    //Update amount
                    cbPaymentConcept_SelectedIndexChanged(null, null);
                    finishedLoading = true;
                    return;
                }
                else
                {
                    studentToPay = null;
                }
            }

            gbxPaymentDetails.Visible = false;
            llinkViewAccDetails.Visible = false;
            finishedLoading = false;
            picAccNumber.Image = (Image)Properties.Resources.Warning;
        }

        private void LoadConceptLists(string loadOrder)
        {
            switch (loadOrder)
            {
                case "BT":
                    //Load both lists;
                    //ConceptList = DAL.getAvailableConcepts(selectedStudent.studentGroup, selectedStudent.studentLevel);
                    //ConceptListAS = DAL.getAfterSchoolConcepts();
                    ConceptList = BAL.getAvailableConcepts(selectedStudent.studentID, "School", cbShowAllConcepts.Checked);
                    ConceptListAS = BAL.getAvailableConcepts(selectedStudent.studentID, "MedioInternado", cbShowAllConcepts.Checked);
                    break;

                case "SC":
                    //Load only school-payments
                    //ConceptList = DAL.getAvailableConcepts(selectedStudent.studentGroup, selectedStudent.studentLevel);
                    ConceptList = BAL.getAvailableConcepts(selectedStudent.studentID, "School", cbShowAllConcepts.Checked);
                    break;

                case "MI":
                    //Load only after-school payments
                    ConceptListAS = DAL.getAfterSchoolConcepts();
                    ConceptListAS = BAL.getAvailableConcepts(selectedStudent.studentID, "MedioInternado", cbShowAllConcepts.Checked);
                    break;

            }
        }

        private void cbPaymentConcept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (finishedLoading)
            {
                List<infoConcept> cList = new List<infoConcept>();

                if (cbPaymentType.SelectedItem != null && cbPaymentType.SelectedItem.ToString() == "Medio Internado")
                    cList = ConceptListAS;
                else
                    cList = ConceptList;

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

                if (cbPaymentType.SelectedItem.ToString() == "Pagos Escolares")
                {
                    cbPaymentConcept.DataSource = ConceptList;
                    //cbPaymentConcept.DataSource = BAL.getAvailableConcepts(selectedStudent.studentID, "School", cbShowAllConcepts.Checked);
                }
                else
                {
                    cbPaymentConcept.DataSource = ConceptListAS;
                    //cbPaymentConcept.DataSource = BAL.getAvailableConcepts(selectedStudent.studentID, "MedioInternado", cbShowAllConcepts.Checked);
                } 
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
            ReloadLists();
            finishedLoading = true;
            
        }

        private void ReloadLists()
        {
            string loadOrder = "";

            //Clean concept list to add new ones for new student.
            cbPaymentType.Items.Clear();

            cbPaymentConcept.DataSource = null;
            cbPaymentConcept.Items.Clear();
            cbPaymentConcept.Text = "";

            txtbPaymentAmount.Clear();

            //Check if student is attending, after-school only or both. 
            if (selectedStudent.studentGroup == 99)
            {
                //After-school only
                loadOrder = "MI";
            }
            else if (selectedStudent.studentAfterSchool)
            {
                //Both concept lists
                loadOrder = "BT";
            }
            else
            {
                //Only school-payments
                loadOrder = "SC";
            }

            //Reload concept lists
            LoadConceptLists(loadOrder);

            switch (loadOrder)
            {
                case "BT":
                    //Load both lists;
                    cbPaymentType.Items.Insert(0, "Pagos Escolares");
                    cbPaymentType.Items.Insert(1, "Medio Internado");
                    cbPaymentType.SelectedIndex = 0;
                    cbPaymentConcept.DataSource = ConceptList;
                    break;

                case "SC":
                    //Load only school-payments
                    cbPaymentType.Items.Insert(0, "Pagos Escolares");
                    cbPaymentType.SelectedIndex = 0;
                    cbPaymentConcept.DataSource = ConceptList;
                    break;

                case "MI":
                    //Load only after-school payments
                    cbPaymentType.Items.Insert(0, "Medio Internado");
                    cbPaymentType.SelectedIndex = 0;
                    cbPaymentConcept.DataSource = ConceptListAS;
                    break;
            }

            cbPaymentConcept.ValueMember = "Value";
            cbPaymentConcept.DisplayMember = "Name";
        }

    }
}
