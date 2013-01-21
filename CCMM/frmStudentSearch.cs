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

            if (cbGrade.Enabled)
            {
                //If a grade is selected
                if (Int32.TryParse(cbGrade.SelectedItem.ToString(), out num))
                {
                    parameters.Add("(Students.[Group] = " + Int32.Parse(cbGrade.SelectedItem.ToString()) + ")");
                }
                else if (cbLevel.SelectedItem.ToString() == "Medio Internado")
                {
                    //If only after-school students
                    parameters.Add("(Students.[Group] = 99)");
                }
                else
                {
                    parameters.Add("(Students.School_Level = " + BAL.getLevelbyName(cbLevel.SelectedItem.ToString()).ToString() + ")");
                }
            }


            //Fill dataGridView using the DataAccess class
            dGridStudentResults.DataSource = null;
            dGridStudentResults.DataSource = DAL.SearchStudent(parameters, txtbAccNum.Text);
        }

        //If user has account number, it can be used to select student. Otherwise search using
        //parameters
        private void cbParameteresActive_CheckedChanged(object sender, EventArgs e)
        {
            if (cbParameteresActive.Checked)
            {
                txtbAccNum.Enabled = false;
                groupBParameters.Enabled = true;
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
            cbGrade.Items.Clear();

            switch (cbLevel.SelectedItem.ToString())
            {
                case "Todos":
                    cbGrade.Items.Add("Todos");
                    cbGrade.Enabled = false;
                    break;

                case "Medio Internado":
                    cbGrade.Items.Add("Solo Medio Internado");
                    cbAfterSchool.Checked = true;
                    cbGrade.Enabled = true;
                    break;

                case "Primaria":
                    cbGrade.Items.Add("Todos");
                    for (int i = 1; i <= 6; i++)
                        cbGrade.Items.Add(i.ToString());
                    cbGrade.Enabled = true;
                    break;

                case "Secundaria":
                    cbGrade.Items.Add("Todos");
                    for (int i = 7; i <= 9; i++)
                        cbGrade.Items.Add(i.ToString());
                    cbGrade.Enabled = true;
                    break;

                case "Preparatoria":
                    cbGrade.Items.Add("Todos");
                    for (int i = 10; i <= 12; i++)
                        cbGrade.Items.Add(i.ToString());
                    cbGrade.Enabled = true;
                    break;

                case "Universidad":
                    cbGrade.Items.Add("Todos");
                    for (int i = 13; i <= 17; i++)
                        cbGrade.Items.Add(i.ToString());
                    cbGrade.Enabled = true;
                    break;
            }

            cbGrade.SelectedIndex = 0;
        }

        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
