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
    public partial class frmConceptCatalog : Form
    {
        public frmConceptCatalog()
        {
            InitializeComponent();
        }

        private void frmConceptCatalog_Load(object sender, EventArgs e)
        {
            cbxType.SelectedIndex = 0;
            UpdateGridResults();
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxLevel.Items.Clear();
            cbxLevel.Items.Add("Todos");

            switch (cbxType.SelectedIndex)
            {
                case 0:
                    cbxLevel.Items.Add("Primaria");
                    cbxLevel.Items.Add("Secundaria");
                    cbxLevel.Items.Add("Preparatoria");
                    cbxLevel.Items.Add("Universidad");
                    cbxLevel.Items.Add("Medio Internado");
                    break;

                case 1:
                    cbxLevel.Items.Add("Primaria");
                    cbxLevel.Items.Add("Secundaria");
                    cbxLevel.Items.Add("Preparatoria");
                    cbxLevel.Items.Add("Universidad");
                    break;

                case 2:
                    cbxLevel.Items.Clear();
                    cbxLevel.Items.Add("Medio Internado");
                    break;
            }

            cbxLevel.SelectedIndex = 0;
            UpdateGridResults();
        }

        private void cbxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sLevel = cbxLevel.SelectedItem.ToString();
            int numGrades = 0;

            cbxGrade.Items.Clear();
            cbxGrade.Items.Add("Todos");

            if (sLevel == "Primaria")
                numGrades = 6;

            if (sLevel == "Secundaria" || sLevel == "Preparatoria")
                numGrades = 3;

            if (sLevel == "Universidad")
                numGrades = 5;

            for (int i = 1; i <= numGrades; i++)
                cbxGrade.Items.Add(i);

            cbxGrade.SelectedIndex = 0;
            UpdateGridResults();
        }

        private void UpdateGridResults()
        {
            dGridConcepts.DataSource = DAL.GetConcepts(CreateParameterString());
            dGridConcepts.AutoResizeColumns();
        }

        private string CreateParameterString()
        {
            StringBuilder para = new StringBuilder();
            string parameters = string.Empty;

            if (cbxGrade.SelectedItem.ToString() != "Todos")
            {
                int level = BAL.getLevelbyName(cbxLevel.SelectedItem.ToString());
                int grade = BAL.getGradeLevel(level, int.Parse(cbxGrade.SelectedItem.ToString()));
                para.AppendFormat(" WHERE (Rel_GL_Concept.FK_Group_ID = {0})", grade);
                return para.ToString();
            }

            if (cbxLevel.SelectedItem.ToString() != "Todos")
            {
                int level = BAL.getLevelbyName(cbxLevel.SelectedItem.ToString());
                para.AppendFormat(" WHERE (Rel_GL_Concept.FK_Level_ID = {0})", level);
                return para.ToString();
            }

            if (cbxType.SelectedItem.ToString() != "Todos")
            {
                if (cbxType.SelectedItem.ToString() == "Colegio")
                {
                    para.Append(" WHERE (Rel_GL_Concept.FK_Level_ID <> 5) OR (Rel_GL_Concept.FK_Level_ID IS NULL)");
                    return para.ToString();
                }

                if (cbxType.SelectedItem.ToString() == "Medio Internado")
                {
                    para.Append(" WHERE (Rel_GL_Concept.FK_Level_ID = 5)");
                    return para.ToString();
                }
            }

            return "";
        }

        private void cbxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGridResults();
        }

        private void dGridConcepts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGridConcepts.SelectedCells.Count > 0)
            {
                //Get selected ID
                string id = dGridConcepts.SelectedCells[0].Value.ToString();
                frmConceptDetails frmConceptDetails = new frmConceptDetails(int.Parse(id));
                frmConceptDetails.ShowDialog();
                UpdateGridResults();
            }
        }
    }
}
