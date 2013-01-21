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
            cbAfterSchool.Checked = selectedStudent.studentAfterSchool;

            //Load payment type
            if (selectedStudent.paymentType == "Normal")
                cbAccType.SelectedIndex = 0;
            else
                cbAccType.SelectedIndex = 1;

            //If person is enrolled in school -> show grade, otherwise (when it's after-school only) just N/A
            if (selectedStudent.studentGroup == 99)
            {
                txtbFalseGrade.Text = "Solo M.I.";
                cbGrade.SelectedIndex = 17;
            }
            else
            {
                txtbFalseGrade.Text = selectedStudent.studentGroup.ToString();
                cbGrade.SelectedIndex = selectedStudent.studentGroup - 1;
            }

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

                toSave = true;

                //Activates controls
                txtbAccNum.ReadOnly = false;
                txtbName.ReadOnly = false;
                txtbLastName.ReadOnly = false;
                txtbLastName2.ReadOnly = false;
                txtbFalseGrade.Visible = false;
                cbGrade.Visible = true;
                cbAccType.Enabled = true;
                cbAfterSchool.Enabled = true;

                txtbDiscount.ReadOnly = false;
                chkSpecialAcc.Enabled = true;

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

                editedStudent.paymentType = cbAccType.SelectedText;
                editedStudent.studentAfterSchool = cbAfterSchool.Checked;

                //If student is after-school only, assign the group 99, otherwise just a normal group
                if (cbGrade.Text != "Solo MI")
                    editedStudent.studentGroup = int.Parse(cbGrade.Text);
                else
                    editedStudent.studentGroup = 99;

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
                    txtbFalseGrade.Text = cbGrade.Text;
                    txtbFalseGrade.Visible = true;
                    cbGrade.Visible = false;
                    cbAfterSchool.Enabled = false;

                    txtbDiscount.ReadOnly = true;
                    chkSpecialAcc.Enabled = false;
                }
            }
        }

        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGrade.SelectedItem.ToString() == "Solo MI")
                cbAfterSchool.Checked = true;
        }

        private void btnPrintGrid_Click(object sender, EventArgs e)
        {

        }

        private void cbAfterSchool_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGrade.SelectedItem.ToString() == "Solo MI")
                cbAfterSchool.Checked = true;
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
    }
}
