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
    public partial class frmStudentDetails : Form
    {
        public frmStudentDetails(int _selectedAccount, bool editEnabled)
        {
            InitializeComponent();
            geditEnabled = editEnabled;
            fillInformation(_selectedAccount);
            selectedAccount = _selectedAccount;
        }

        //Flag to know if user enabled information editing

        bool toSave = false;
        bool geditEnabled = true;
        private double selectedAccount;
        private bool showingPayments = true;

        int[] levelValues = new int[5] { 0, 6, 9, 12, 20 };

        //Global object with current student information
        infoStudent selectedStudent = new infoStudent();

        public bool editedInfo { get; set; }

        private void loadPayments(DateTime? startDate, DateTime? endDate, bool updateGrid = false)
        {
            gDataPayments.DataSource = DAL.getPaymentsByStudent(selectedAccount, startDate, endDate, updateGrid);
        }

        private void fillInformation(int sId)
        {
            //Account_Num, First_Name, Last_Name, Last_Name2, Group, Discount
            selectedStudent = DAL.getStudentDetails(sId);

            //Set form title
            this.Text = "Detalles de " + selectedStudent.studentFistName + " " + selectedStudent.studentLastName + " " + selectedStudent.studentLastName2;

            //Load information into controls/fields
            txtbAccNum.Text = selectedStudent.studentID.ToString();
            txtbName.Text = selectedStudent.studentFistName;
            txtbLastName.Text = selectedStudent.studentLastName;
            txtbLastName2.Text = selectedStudent.studentLastName2;

            //Load payment type
            if (selectedStudent.paymentType == "Normal")
                cbAccType.SelectedIndex = 0;
            else
                cbAccType.SelectedIndex = 1;

            //Load school level
            cbSchoolLevel.SelectedIndex = selectedStudent.studentLevel - 1;

            cbGrade.SelectedIndex = (selectedStudent.studentGroup - levelValues[selectedStudent.studentLevel - 1]) - 1;

            //Check/uncheck the special/discount 
            if (selectedStudent.paymentDiscount > 0)
            {
                chkSpecialAcc.Checked = true;
                txtbDiscount.Visible = true;
                lblDiscount.Visible = true;
                txtbDiscount.Text = selectedStudent.paymentDiscount.ToString();
            }
        }

        private void frmStudentDetails_Load(object sender, EventArgs e)
        {
            //If coming from new payment hide edit and print buttons
            if (!geditEnabled)
            {
                btnEditSaveAcc.Visible = false;
                btnPrintGrid.Visible = false;
            }

            //Load payment history
            loadPayments(null, null);
        }

        private void btnEditSaveAcc_Click(object sender, EventArgs e)
        {
            int num;
            List<string> errorList = new List<string>();

            if (!toSave)
            {
                //Changes button text
                btnEditSaveAcc.Text = "Guardar Cambios";
                btnDelete.Visible = true;

                toSave = true;

                //Activates controls
                txtbAccNum.ReadOnly = false;
                txtbName.ReadOnly = false;
                txtbLastName.ReadOnly = false;
                txtbLastName2.ReadOnly = false;
                cbGrade.Visible = true;
                cbAccType.Enabled = true;

                txtbDiscount.ReadOnly = false;
                chkSpecialAcc.Enabled = true;

                cbSchoolLevel.Enabled = true;
                cbGrade.Enabled = true;

                return;

            }
            else
            {
                //Verify that all fields are filled
                if (txtbAccNum.Text == "" || !(Int32.TryParse(txtbAccNum.Text, out num)))
                    errorList.Add("Numero de Cuenta");

                if (txtbName.Text == "")
                    errorList.Add("Nombre");

                if (txtbLastName.Text == "" || txtbLastName2.Text == "")
                    errorList.Add("Apellidos");

                if (chkSpecialAcc.Checked)
                {
                    if (txtbDiscount.Text == "" || !(Int32.TryParse(txtbDiscount.Text, out num)))
                        errorList.Add("Descuento");
                }

                if (errorList.Count > 0)
                {
                    string errorString = "Verifica los siguientes campos: ";

                    foreach (string fieldName in errorList)
                        errorString += "[" + fieldName + "] ";

                    MessageBox.Show(errorString);
                    return;
                }


                //Verify that (if changed) the new account number does not exist
                if (Int32.Parse(txtbAccNum.Text) != selectedAccount)
                {
                    infoStudent testStudent = DAL.getStudentDetails(Int32.Parse(txtbAccNum.Text));

                    if (testStudent != null)
                    {
                        MessageBox.Show("Ese numero de cuenta ya existe, pertenece a:  " + testStudent.studentFistName + " " + testStudent.studentLastName);
                        return;
                    }
                }

                //Try to insert the information
                //If working, disable controls - otherwise keep enabled and show error

                

                //Create object to save new values
                infoStudent editedStudent = new infoStudent();
                editedStudent.studentID = int.Parse(txtbAccNum.Text);
                editedStudent.studentFistName = txtbName.Text;
                editedStudent.studentLastName = txtbLastName.Text;
                editedStudent.studentLastName2 = txtbLastName2.Text;

                if (chkSpecialAcc.Checked)
                    editedStudent.paymentDiscount = int.Parse(txtbDiscount.Text);
                else
                    editedStudent.paymentDiscount = 0;

                editedStudent.paymentType = cbAccType.SelectedItem.ToString() ;

                //If student is after-school only, assign the group 99, otherwise just a normal group
                editedStudent.studentGroup = (cbGrade.SelectedIndex + levelValues[cbSchoolLevel.SelectedIndex]) + 1;
                editedStudent.studentLevel = BAL.getLevelfromGrade(editedStudent.studentGroup);
                
                //Send the edited information, alongside the current account number
                if (DAL.updateStudentRecord(editedStudent, selectedStudent.studentID) == "OK")
                {
                    MessageBox.Show("Entrada actualizada");
                    editedInfo = true;

                    //Makes controls read-only again
                    txtbAccNum.ReadOnly = true;
                    txtbName.ReadOnly = true;
                    txtbLastName.ReadOnly = true;
                    txtbLastName2.ReadOnly = true;
                    cbGrade.Enabled = false;
                    btnDelete.Visible = false;
                    cbSchoolLevel.Enabled = false;
                    cbAccType.Enabled = false;

                    txtbDiscount.ReadOnly = true;
                    chkSpecialAcc.Enabled = false;
                }
            }
        }

        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPrintGrid_Click(object sender, EventArgs e)
        {
            List<string[]> reportData = new List<string[]>();

            if (showingPayments)
            {
                //Payment history
                reportData = BAL.CreateStudentReport(selectedStudent, DAL.getPaymentsByStudent(selectedAccount, null, null, false));
                if (reportData.Count == 0)
                {
                    MessageBox.Show("No hay datos que imprimir");
                    return;
                }

                Printing.PrintReport(reportData, "Personal Payments", DateTime.Now.Date, "Personal");
            }
            else
            {
                //Debt history
                reportData = BAL.CreateStudentReport(selectedStudent, BAL.getExpiredSchoolConcepts(selectedStudent.studentGroup, selectedStudent.studentLevel, selectedStudent.studentID));
                if (reportData.Count == 0)
                {
                    MessageBox.Show("No hay datos que imprimir");
                    return;
                }
                Printing.PrintReport(reportData, "Personal Debt", DateTime.Now.Date, "Personal");
            }
        }

        private void cbAfterSchool_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void updatePaymentsGrid()
        {
            if (datePaymentFrom.Value.Date < datePaymentTo.Value.Date)
            {
                loadPayments(datePaymentFrom.Value.Date, datePaymentTo.Value.Date, true);
            }
        }

        private void datePaymentFrom_ValueChanged(object sender, EventArgs e)
        {
            updatePaymentsGrid();
        }

        private void datePaymentTo_ValueChanged(object sender, EventArgs e)
        {
            updatePaymentsGrid();
        }

        private void chkSpecialAcc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpecialAcc.Checked)
                txtbDiscount.Show();
            else
                txtbDiscount.Hide();
        }

        private void lnlblExpPayments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            datePaymentFrom.Enabled = false;
            datePaymentTo.Enabled = false;
            gDataPayments.DataSource = null;

            gDataPayments.DataSource = BAL.getExpiredSchoolConcepts(selectedStudent.studentGroup, selectedStudent.studentLevel, selectedStudent.studentID);
            gDataPayments.AutoResizeColumns();
            showingPayments = false;
        }

        private void llblResetGrid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            datePaymentFrom.Enabled = true;
            datePaymentTo.Enabled = true;
            loadPayments(null, null);
            showingPayments = true;
        }

        private void cbSchoolLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGrade.Items.Clear();

            if (cbSchoolLevel.Text == "Primaria")
            {
                for (int i = 1; i <= 6; i++)
                    cbGrade.Items.Add(i);
            }
            else if (cbSchoolLevel.Text == "Universidad")
            {
                for (int i = 1; i <= 5; i++)
                    cbGrade.Items.Add(i);
            }
            else
            {
                for (int i = 1; i <= 3; i++)
                    cbGrade.Items.Add(i);
            }

            cbGrade.SelectedIndex = 0;
        }

        private void lblLevel_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esto borrara el registro y pagos de: " + selectedStudent.studentFistName + " " + selectedStudent.studentLastName, "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Delete account

                BAL.DeleteAccount(selectedStudent);
                editedInfo = true;
                this.Close();
            }
        }

        private void gDataPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showingPayments)
            {
                if(gDataPayments.SelectedCells.Count > 0)
                {
                    //Create payment list with information
                    List<string> paymentInfo = new List<string>();

                    paymentInfo.Add(gDataPayments.SelectedCells[1].Value.ToString());
                    paymentInfo.Add(gDataPayments.SelectedCells[2].Value.ToString());
                    paymentInfo.Add(gDataPayments.SelectedCells[3].Value.ToString());
                    paymentInfo.Add(gDataPayments.SelectedCells[4].Value.ToString());
                    paymentInfo.Add(gDataPayments.SelectedCells[5].Value.ToString());
                    paymentInfo.Add(gDataPayments.SelectedCells[0].Value.ToString());

                    frmPaymentDetails frmPaymentDetails = new frmPaymentDetails(paymentInfo);
                    frmPaymentDetails.ShowDialog();


                    if(frmPaymentDetails.updatedInfo)
                    {
                        datePaymentFrom.Enabled = true;
                        datePaymentTo.Enabled = true;
                        loadPayments(null, null);
                        showingPayments = true;
                    }
                }
            }
        }
    }
}
