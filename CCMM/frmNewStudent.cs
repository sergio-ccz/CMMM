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
    public partial class frmNewStudent : Form
    {
        public frmNewStudent()
        {
            InitializeComponent();
        }

        int[] levelValues = new int[5] { 0, 6, 9, 12, 20 };

        private void frmNewStudent_Load(object sender, EventArgs e)
        {
            //Set base values
            cbSchoolLevel.SelectedIndex = 0;
            cbGrade.SelectedIndex = 0;
            cbAccType.SelectedIndex = 0;
        }

        private void chkSpecialAcc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpecialAcc.Checked)
                txtbDiscount.Enabled = true;
            else
                txtbDiscount.Enabled = false;
        }

        private void btnSaveNewStudent_Click(object sender, EventArgs e)
        {
            List<string> errorList = new List<string>();
            infoStudent testStudent = new infoStudent();
            infoStudent newStudent = new infoStudent();
            int num;

            //Check for empty fields
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

            //Check that account number isn't being used
            testStudent = DAL.getStudentDetails(Int32.Parse(txtbAccNum.Text));

            if (testStudent != null)
            {
                MessageBox.Show("Ese numero de cuenta ya existe, pertenece a:  " + testStudent.studentFistName + " " + testStudent.studentLastName);
                return;
            }

            //Try to create new student object and send it to the database
            try
            {
                newStudent.studentID = Int32.Parse(txtbAccNum.Text);
                newStudent.studentFistName = txtbName.Text;
                newStudent.studentLastName = txtbLastName.Text;
                newStudent.studentLastName2 = txtbLastName2.Text;
                newStudent.studentGroup = cbGrade.SelectedIndex + levelValues[cbSchoolLevel.SelectedIndex] + 1;

                if (chkSpecialAcc.Checked)
                {
                    newStudent.paymentDiscount = int.Parse(txtbDiscount.Text);
                }
                else
                {
                    newStudent.paymentDiscount = 0;
                }

                newStudent.studentLevel = BAL.getLevelfromGrade(newStudent.studentGroup);
                newStudent.paymentType = cbAccType.Text;
            
                DAL.newStudentRecord(newStudent);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ocurrio un error, verificar informacion. Texto de error: " + exp.ToString());
                return;
            }

            MessageBox.Show("Registro creado");

            //Clean
            txtbAccNum.Clear();
            txtbDiscount.Clear();
            txtbLastName.Clear();
            txtbLastName2.Clear();
            txtbName.Clear();
            cbAccType.SelectedIndex = 0;
            cbSchoolLevel.SelectedIndex = 0;
            chkSpecialAcc.Checked = false;


            //If(OK) Show confirmation/reload (FALSE) Show what happened
        }

        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e){}
        private void cbAfterSchool_CheckedChanged(object sender, EventArgs e){}

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
    }
}
