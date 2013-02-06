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
    public partial class frmConceptDetails : Form
    {
        public frmConceptDetails(int selectedConcept)
        {
            getInfo(selectedConcept);
            InitializeComponent();
        }

        private infoConcept _selectedConcept;

        private void getInfo(int selected)
        {
            _selectedConcept = DAL.getConceptInfo(selected);
        }

        private void frmConceptDetails_Load(object sender, EventArgs e)
        {
            txtbName.Text = _selectedConcept.Name;
            txtbAmount.Text = _selectedConcept.Amount.ToString();
            dateDueDate.Value = _selectedConcept.LimitDate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double it;
            List<string> lstErrors = new List<string>();

            if (!double.TryParse(txtbAmount.Text, out it))
                lstErrors.Add("[Cantidad]");

            if (txtbName.Text == string.Empty)
                lstErrors.Add(" [Nombre] ");

            if (lstErrors.Count > 0)
            {
                string error = "Verificar la informacion en: ";
                foreach (string err in lstErrors)
                {
                    error += err;
                }
                MessageBox.Show(error);
                return;
            }

            infoConcept updatedConcept = new infoConcept();

            updatedConcept = _selectedConcept;

            if (txtbName.Text != _selectedConcept.Name)
                updatedConcept.Name = txtbName.Text;

            if (float.Parse(txtbAmount.Text) != _selectedConcept.Amount)
                updatedConcept.Amount = float.Parse(txtbAmount.Text);

            if (dateDueDate.Value.Date != _selectedConcept.LimitDate.Date)
                updatedConcept.LimitDate = dateDueDate.Value.Date;

            try
            {
                if (updatedConcept != _selectedConcept)
                {
                    DAL.UpdateConcept(updatedConcept);
                    MessageBox.Show("Entrada actualizada");
                }
                else
                {
                    MessageBox.Show("No cambios registrados, regresando a busqueda");
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error - tratar de nuevo");
            }



        }
    }
}
