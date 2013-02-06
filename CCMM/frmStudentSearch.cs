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
    public partial class frmStudentSearch : Form
    {
        string searchType;
        frmStudentDetails frmStudentDetails;

        public string studentID { set; get; }
        int[] levelValues = new int[5] { 0, 6, 9, 12, 20 };

        public frmStudentSearch(string type)
        {
            InitializeComponent();

            //Save intended use code for future use
            searchType = type;

            //Depending on the inteded use, change the form's title
            switch (type)
            {
                case "normalSearch":
                    lblSearchTips.Text = "Da doble click a un alumno para visualizar y editar sus detalles";
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //List<> to save parameters
            List<string> parameters = new List<string>();

            string accNum = "";
            int num;

            //Get values from controls and save to list<>
            //If account number is entered, use that only. Otherwise use the other parameters
            if (txtbAccNum.Text != "" && txtbAccNum.Enabled)
            {
                accNum = txtbAccNum.Text;
            }

            if (cbParameteresActive.Checked)
            {
                //Save parameters to parameter list
                if (txtbName.Text != "")
                {
                    parameters.Add("(Students.First_Name LIKE '%" + txtbName.Text + "%')");
                }

                if (txtbLastName.Text != "")
                {
                    parameters.Add("(Students.Last_Name LIKE '%" + txtbLastName.Text + "%')");
                }

                if (txtbLastName2.Text != "")
                {
                    parameters.Add("(Students.Last_Name2 LIKE '%" + txtbLastName2.Text + "%')");
                }

                if (cbGrade.Enabled && cbGrade.SelectedIndex != 0)
                {
                    int sGrade = Int32.Parse(cbGrade.SelectedItem.ToString());
                    sGrade = sGrade + levelValues[cbLevel.SelectedIndex - 1];
                    parameters.Add("(Students.[Group] = " + sGrade + ")");
                }
                else if(cbLevel.SelectedIndex != 0)
                {
                    parameters.Add("(Students.School_Level = " + BAL.getLevelbyName(cbLevel.SelectedItem.ToString()).ToString() + ")");
                }
            }

            //Fill dataGridView using the DataAccess class
            dGridStudentResults.DataSource = null;
            dGridStudentResults.DataSource = DAL.SearchStudent(parameters, txtbAccNum.Text);
            dGridStudentResults.AutoResizeColumns();
        }

        //If user has account number, it can be used to select student. Otherwise search using
        //parameters
        private void cbParameteresActive_CheckedChanged(object sender, EventArgs e)
        {
            if (cbParameteresActive.Checked)
            {
                txtbAccNum.Enabled = false;
                groupBParameters.Enabled = true;
                cbLevel.SelectedIndex = 0;
            }
            else
            {
                txtbAccNum.Enabled = true;
                groupBParameters.Enabled = false;
            }
        }

        private void dGridStudentResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGridStudentResults.SelectedCells.Count > 0)
            {
                //Get selected ID
                string id = dGridStudentResults.SelectedCells[0].Value.ToString();

                switch (searchType)
                {
                    //Launch form with Student Details
                    case "normalSearch":

                        if (frmStudentDetails == null || frmStudentDetails.Visible == false)
                        {
                            frmStudentDetails = new frmStudentDetails(Int32.Parse(id), true);
                            frmStudentDetails.ShowDialog();
                            if (frmStudentDetails.editedInfo)
                            {
                                //If information was edited, do another search
                                btnSearch.PerformClick();
                            }
                            frmStudentDetails.Dispose();
                        }
                        break;

                    //Returns account information to frmNewPayment
                    case "paymentSearch":
                        studentID = id;
                        this.Close();
                        break;
                }
            }
        }

        private void frmStudentSearch_Load(object sender, EventArgs e)
        {
            //Load School Levels
            
        }

        //Load school years depending on selected school level
        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numGrades = 0;
            cbGrade.Items.Clear();
            cbGrade.Items.Add("Todos");

            switch (cbLevel.SelectedItem.ToString())
            {
                case "Todos":
                    cbGrade.Enabled = false;
                    break;

                case "Medio Internado":
                    numGrades = 3;
                    cbGrade.Enabled = true;
                    break;

                case "Primaria":
                    numGrades = 6;
                    cbGrade.Enabled = true;
                    break;

                case "Secundaria":
                    numGrades = 3;
                    cbGrade.Enabled = true;
                    break;

                case "Preparatoria":
                    numGrades = 3;
                    cbGrade.Enabled = true;
                    break;

                case "Universidad":
                    numGrades = 5;
                    cbGrade.Enabled = true;
                    break;
            }

            for (int i = 1; i <= numGrades; i++)
                cbGrade.Items.Add(i);

            cbGrade.SelectedIndex = 0;
        }

        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
