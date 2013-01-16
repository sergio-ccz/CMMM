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

        public bool editedInfo { get; set; }

        private void fillInformation(int sId)
        {
            //DataAccess dObject = new DataAccess();

            ////Account_Num, First_Name, Last_Name, Last_Name2, Group, Discount
            //studentInfo = dObject.getStudentDetails(sId);

            ////Set form title
            //this.Text = "Detalles de " + studentInfo[1] + " " + studentInfo[2] + " " + studentInfo[3];

            ////Load information into controls/fields
            //txtbAccNum.Text = studentInfo[0];
            //txtbName.Text = studentInfo[1];
            //txtbLastName.Text = studentInfo[2];
            //txtbLastName2.Text = studentInfo[3];
            //txtbFalseGrade.Text = studentInfo[4];

            ////Check/uncheck the special/discount 
            //if (Int32.Parse(studentInfo[5]) > 0)
            //{
            //    chkSpecialAcc.Checked = true;
            //    txtbDiscount.Visible = true;
            //    lblDiscount.Visible = true;
            //    txtbDiscount.Text = studentInfo[5];
            //}

        }
    }
}
