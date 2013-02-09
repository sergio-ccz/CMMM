namespace CCMM
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mbtnNewPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnStudentSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnStudentRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtDateReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mBtnSchoolEarnings = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnMedioEarnings = new System.Windows.Forms.ToolStripMenuItem();
            this.mtbCombReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnSchoolDebts = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnMedioDebts = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoCicloEscolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnConceptCatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtnNewPayment,
            this.mbtnStudents,
            this.mbtnReports,
            this.mbtnSettings});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(1192, 56);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // mbtnNewPayment
            // 
            this.mbtnNewPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnNewPayment.Image = global::CCMM.Properties.Resources.NewPayment;
            this.mbtnNewPayment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mbtnNewPayment.Name = "mbtnNewPayment";
            this.mbtnNewPayment.Size = new System.Drawing.Size(195, 52);
            this.mbtnNewPayment.Text = "Registrar Pago";
            this.mbtnNewPayment.Click += new System.EventHandler(this.mbtnNewPayment_Click);
            // 
            // mbtnStudents
            // 
            this.mbtnStudents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtnStudentSearch,
            this.mbtnStudentRegistration});
            this.mbtnStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnStudents.Image = global::CCMM.Properties.Resources.Users;
            this.mbtnStudents.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mbtnStudents.Name = "mbtnStudents";
            this.mbtnStudents.Size = new System.Drawing.Size(155, 52);
            this.mbtnStudents.Text = "Alumnos";
            // 
            // mbtnStudentSearch
            // 
            this.mbtnStudentSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnStudentSearch.Name = "mbtnStudentSearch";
            this.mbtnStudentSearch.Size = new System.Drawing.Size(226, 32);
            this.mbtnStudentSearch.Text = "Búsqueda";
            this.mbtnStudentSearch.Click += new System.EventHandler(this.mbtnStudentSearch_Click);
            // 
            // mbtnStudentRegistration
            // 
            this.mbtnStudentRegistration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnStudentRegistration.Name = "mbtnStudentRegistration";
            this.mbtnStudentRegistration.Size = new System.Drawing.Size(226, 32);
            this.mbtnStudentRegistration.Text = "Nuevo Alumno";
            this.mbtnStudentRegistration.Click += new System.EventHandler(this.mbtnStudentRegistration_Click);
            // 
            // mbtnReports
            // 
            this.mbtnReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtDateReport,
            this.mtbCombReport});
            this.mbtnReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnReports.Image = global::CCMM.Properties.Resources.Report;
            this.mbtnReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mbtnReports.Name = "mbtnReports";
            this.mbtnReports.Size = new System.Drawing.Size(157, 52);
            this.mbtnReports.Text = "Reportes";
            this.mbtnReports.Click += new System.EventHandler(this.mbtnReports_Click);
            // 
            // mbtDateReport
            // 
            this.mbtDateReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mBtnSchoolEarnings,
            this.mbtnMedioEarnings});
            this.mbtDateReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtDateReport.Name = "mbtDateReport";
            this.mbtDateReport.Size = new System.Drawing.Size(166, 32);
            this.mbtDateReport.Text = "Ingresos";
            this.mbtDateReport.Click += new System.EventHandler(this.mbtnDailyReport_Click);
            // 
            // mBtnSchoolEarnings
            // 
            this.mBtnSchoolEarnings.Name = "mBtnSchoolEarnings";
            this.mBtnSchoolEarnings.Size = new System.Drawing.Size(242, 32);
            this.mBtnSchoolEarnings.Text = "Escolares";
            this.mBtnSchoolEarnings.Click += new System.EventHandler(this.mBtnSchoolEarnings_Click);
            // 
            // mbtnMedioEarnings
            // 
            this.mbtnMedioEarnings.Name = "mbtnMedioEarnings";
            this.mbtnMedioEarnings.Size = new System.Drawing.Size(242, 32);
            this.mbtnMedioEarnings.Text = "Medio Internado";
            this.mbtnMedioEarnings.Click += new System.EventHandler(this.mbtnMedioEarnings_Click);
            // 
            // mtbCombReport
            // 
            this.mtbCombReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtnSchoolDebts,
            this.mbtnMedioDebts});
            this.mtbCombReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCombReport.Name = "mtbCombReport";
            this.mtbCombReport.Size = new System.Drawing.Size(166, 32);
            this.mtbCombReport.Text = "Adeudos";
            this.mtbCombReport.Click += new System.EventHandler(this.mtbCombReport_Click);
            // 
            // mbtnSchoolDebts
            // 
            this.mbtnSchoolDebts.Name = "mbtnSchoolDebts";
            this.mbtnSchoolDebts.Size = new System.Drawing.Size(242, 32);
            this.mbtnSchoolDebts.Text = "Escolares";
            this.mbtnSchoolDebts.Click += new System.EventHandler(this.mbtnSchoolDebts_Click);
            // 
            // mbtnMedioDebts
            // 
            this.mbtnMedioDebts.Name = "mbtnMedioDebts";
            this.mbtnMedioDebts.Size = new System.Drawing.Size(242, 32);
            this.mbtnMedioDebts.Text = "Medio Internado";
            this.mbtnMedioDebts.Click += new System.EventHandler(this.mbtnMedioDebts_Click);
            // 
            // mbtnSettings
            // 
            this.mbtnSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoCicloEscolarToolStripMenuItem,
            this.mbtnConceptCatalog});
            this.mbtnSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnSettings.Image = global::CCMM.Properties.Resources.Settings;
            this.mbtnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mbtnSettings.Name = "mbtnSettings";
            this.mbtnSettings.Size = new System.Drawing.Size(189, 52);
            this.mbtnSettings.Text = "Configuración";
            // 
            // nuevoCicloEscolarToolStripMenuItem
            // 
            this.nuevoCicloEscolarToolStripMenuItem.Name = "nuevoCicloEscolarToolStripMenuItem";
            this.nuevoCicloEscolarToolStripMenuItem.Size = new System.Drawing.Size(301, 32);
            this.nuevoCicloEscolarToolStripMenuItem.Text = "Nuevo Ciclo Escolar";
            this.nuevoCicloEscolarToolStripMenuItem.Visible = false;
            this.nuevoCicloEscolarToolStripMenuItem.Click += new System.EventHandler(this.nuevoCicloEscolarToolStripMenuItem_Click);
            // 
            // mbtnConceptCatalog
            // 
            this.mbtnConceptCatalog.Name = "mbtnConceptCatalog";
            this.mbtnConceptCatalog.Size = new System.Drawing.Size(301, 32);
            this.mbtnConceptCatalog.Text = "Catalogo de Conceptos";
            this.mbtnConceptCatalog.Click += new System.EventHandler(this.mbtnConceptCatalog_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 681);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Registro de ingresos y adeudos";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mbtnNewPayment;
        private System.Windows.Forms.ToolStripMenuItem mbtnStudents;
        private System.Windows.Forms.ToolStripMenuItem mbtnReports;
        private System.Windows.Forms.ToolStripMenuItem mbtnSettings;
        private System.Windows.Forms.ToolStripMenuItem mbtnStudentSearch;
        private System.Windows.Forms.ToolStripMenuItem mbtnStudentRegistration;
        private System.Windows.Forms.ToolStripMenuItem mbtDateReport;
        private System.Windows.Forms.ToolStripMenuItem mtbCombReport;
        private System.Windows.Forms.ToolStripMenuItem nuevoCicloEscolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mbtnConceptCatalog;
        private System.Windows.Forms.ToolStripMenuItem mBtnSchoolEarnings;
        private System.Windows.Forms.ToolStripMenuItem mbtnMedioEarnings;
        private System.Windows.Forms.ToolStripMenuItem mbtnSchoolDebts;
        private System.Windows.Forms.ToolStripMenuItem mbtnMedioDebts;
    }
}

