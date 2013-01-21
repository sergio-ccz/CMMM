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
            this.mbtnPaySearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnStudentSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnStudentRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnReports = new System.Windows.Forms.ToolStripMenuItem();
            this.diarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoCicloEscolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoDeConceptosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtnNewPayment,
            this.mbtnPaySearch,
            this.mbtnStudents,
            this.mbtnReports,
            this.mbtnSettings});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1131, 56);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // mbtnNewPayment
            // 
            this.mbtnNewPayment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnNewPayment.Image = global::CCMM.Properties.Resources.NewPayment;
            this.mbtnNewPayment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mbtnNewPayment.Name = "mbtnNewPayment";
            this.mbtnNewPayment.Size = new System.Drawing.Size(156, 52);
            this.mbtnNewPayment.Text = "Registrar Pago";
            this.mbtnNewPayment.Click += new System.EventHandler(this.mbtnNewPayment_Click);
            // 
            // mbtnPaySearch
            // 
            this.mbtnPaySearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnPaySearch.Image = global::CCMM.Properties.Resources.Search;
            this.mbtnPaySearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mbtnPaySearch.Name = "mbtnPaySearch";
            this.mbtnPaySearch.Size = new System.Drawing.Size(184, 52);
            this.mbtnPaySearch.Text = "Búsqueda Pagos";
            this.mbtnPaySearch.Click += new System.EventHandler(this.mbtnPaySearch_Click);
            // 
            // mbtnStudents
            // 
            this.mbtnStudents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtnStudentSearch,
            this.mbtnStudentRegistration});
            this.mbtnStudents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnStudents.Image = global::CCMM.Properties.Resources.Users;
            this.mbtnStudents.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mbtnStudents.Name = "mbtnStudents";
            this.mbtnStudents.Size = new System.Drawing.Size(132, 52);
            this.mbtnStudents.Text = "Alumnos";
            // 
            // mbtnStudentSearch
            // 
            this.mbtnStudentSearch.Name = "mbtnStudentSearch";
            this.mbtnStudentSearch.Size = new System.Drawing.Size(184, 24);
            this.mbtnStudentSearch.Text = "Búsqueda";
            this.mbtnStudentSearch.Click += new System.EventHandler(this.mbtnStudentSearch_Click);
            // 
            // mbtnStudentRegistration
            // 
            this.mbtnStudentRegistration.Name = "mbtnStudentRegistration";
            this.mbtnStudentRegistration.Size = new System.Drawing.Size(184, 24);
            this.mbtnStudentRegistration.Text = "Nuevo Alumno";
            this.mbtnStudentRegistration.Click += new System.EventHandler(this.mbtnStudentRegistration_Click);
            // 
            // mbtnReports
            // 
            this.mbtnReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diarioToolStripMenuItem,
            this.generalToolStripMenuItem});
            this.mbtnReports.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnReports.Image = global::CCMM.Properties.Resources.Report;
            this.mbtnReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mbtnReports.Name = "mbtnReports";
            this.mbtnReports.Size = new System.Drawing.Size(132, 52);
            this.mbtnReports.Text = "Reportes";
            // 
            // diarioToolStripMenuItem
            // 
            this.diarioToolStripMenuItem.Name = "diarioToolStripMenuItem";
            this.diarioToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.diarioToolStripMenuItem.Text = "Diario";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // mbtnSettings
            // 
            this.mbtnSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoCicloEscolarToolStripMenuItem,
            this.catalogoDeConceptosToolStripMenuItem});
            this.mbtnSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnSettings.Image = global::CCMM.Properties.Resources.Settings;
            this.mbtnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mbtnSettings.Name = "mbtnSettings";
            this.mbtnSettings.Size = new System.Drawing.Size(151, 52);
            this.mbtnSettings.Text = "Configuración";
            // 
            // nuevoCicloEscolarToolStripMenuItem
            // 
            this.nuevoCicloEscolarToolStripMenuItem.Name = "nuevoCicloEscolarToolStripMenuItem";
            this.nuevoCicloEscolarToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.nuevoCicloEscolarToolStripMenuItem.Text = "Nuevo Ciclo Escolar";
            // 
            // catalogoDeConceptosToolStripMenuItem
            // 
            this.catalogoDeConceptosToolStripMenuItem.Name = "catalogoDeConceptosToolStripMenuItem";
            this.catalogoDeConceptosToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.catalogoDeConceptosToolStripMenuItem.Text = "Catalogo de Conceptos";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 681);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "CMM";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mbtnNewPayment;
        private System.Windows.Forms.ToolStripMenuItem mbtnPaySearch;
        private System.Windows.Forms.ToolStripMenuItem mbtnStudents;
        private System.Windows.Forms.ToolStripMenuItem mbtnReports;
        private System.Windows.Forms.ToolStripMenuItem mbtnSettings;
        private System.Windows.Forms.ToolStripMenuItem mbtnStudentSearch;
        private System.Windows.Forms.ToolStripMenuItem mbtnStudentRegistration;
        private System.Windows.Forms.ToolStripMenuItem diarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoCicloEscolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoDeConceptosToolStripMenuItem;
    }
}

