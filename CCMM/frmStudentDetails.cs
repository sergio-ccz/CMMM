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

        //Global array with the current student information
        List<string> studentInfo;

        public bool editedInfo { get; set; }

        private void fillInformation(int sId)
        {
            //Account_Num, First_Name, Last_Name, Last_Name2, Group, Discount
            studentInfo = DAL.getStudentDetails(sId);

            //Set form title
            this.Text = "Detalles de " + studentInfo[1] + " " + studentInfo[2] + " " + studentInfo[3];

            //Load information into controls/fields
            txtbAccNum.Text = studentInfo[0];
            txtbName.Text = studentInfo[1];
            txtbLastName.Text = studentInfo[2];
            txtbLastName2.Text = studentInfo[3];

            //If person is enrolled in school show grade, otherwise (when it's after-school only) just N/A
            if (studentInfo[4] == "99")
                txtbFalseGrade.Text = "N/A";
            else
                txtbFalseGrade.Text = studentInfo[4];

            //Check/uncheck the special/discount 
            if (Int32.Parse(studentInfo[5]) > 0)
            {
                chkSpecialAcc.Checked = true;
                txtbDiscount.Visible = true;
                lblDiscount.Visible = true;
                txtbDiscount.Text = studentInfo[5];
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

        private void loadPayments(DateTime? startDate, DateTime? endDate, bool updateGrid = false)
        {
            DataTable payTable = DAL.getPaymentsByStudent(selectedAccount, startDate, endDate, updateGrid);

            gDataPayments.DataSource = payTable;

        }

        private void btnEditSaveAcc_Click(object sender, EventArgs e)
        {
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
                cbGrade.SelectedIndex = 3;

                txtbDiscount.ReadOnly = false;
                chkSpecialAcc.Enabled = true;

                return;

            }
            else
            {
                //Makes controls read-only again
                txtbAccNum.ReadOnly = true;
                txtbName.ReadOnly = true;
                txtbLastName.ReadOnly = true;
                txtbLastName2.ReadOnly = true;
                txtbFalseGrade.Text = cbGrade.Text;
                txtbFalseGrade.Visible = true;
                cbGrade.Visible = false;
                cbGrade.SelectedIndex = 3;

                txtbDiscount.ReadOnly = true;
                chkSpecialAcc.Enabled = false;

                //Save values from each textbox into array
                List<string> editedValues = new List<string>();
                editedValues.Add(txtbAccNum.Text);
                editedValues.Add(txtbName.Text);
                editedValues.Add(txtbLastName.Text);
                editedValues.Add(txtbLastName2.Text);
                editedValues.Add(cbGrade.Text);
                editedValues.Add(txtbDiscount.Text);

                //Create interface to modify DB

                if (DAL.updateStudentRecord(editedValues, studentInfo[0]) == "OK")
                {
                    MessageBox.Show("Entrada actualizada");
                    editedInfo = true;
                }
            }
        }

    }
}
