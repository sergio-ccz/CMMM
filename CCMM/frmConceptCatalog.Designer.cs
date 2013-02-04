namespace CCMM
{
    partial class frmConceptCatalog
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
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.dGridConcepts = new System.Windows.Forms.DataGridView();
            this.lblDataFilter = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxLevel = new System.Windows.Forms.ComboBox();
            this.cbxGrade = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridConcepts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.Location = new System.Drawing.Point(7, 9);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(473, 25);
            this.lblInfo1.TabIndex = 0;
            this.lblInfo1.Text = "Seleccionar el concepto que se quiere modificar";
            // 
            // dGridConcepts
            // 
            this.dGridConcepts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGridConcepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridConcepts.Location = new System.Drawing.Point(12, 168);
            this.dGridConcepts.Name = "dGridConcepts";
            this.dGridConcepts.ReadOnly = true;
            this.dGridConcepts.RowTemplate.Height = 24;
            this.dGridConcepts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridConcepts.Size = new System.Drawing.Size(745, 147);
            this.dGridConcepts.TabIndex = 1;
            this.dGridConcepts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridConcepts_CellContentClick);
            // 
            // lblDataFilter
            // 
            this.lblDataFilter.AutoSize = true;
            this.lblDataFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFilter.Location = new System.Drawing.Point(29, 58);
            this.lblDataFilter.Name = "lblDataFilter";
            this.lblDataFilter.Size = new System.Drawing.Size(70, 24);
            this.lblDataFilter.TabIndex = 2;
            this.lblDataFilter.Text = "Filtros: ";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Ambos",
            "Colegio",
            "Medio Internado"});
            this.cbxType.Location = new System.Drawing.Point(137, 117);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 24);
            this.cbxType.TabIndex = 3;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // cbxLevel
            // 
            this.cbxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLevel.FormattingEnabled = true;
            this.cbxLevel.Location = new System.Drawing.Point(319, 117);
            this.cbxLevel.Name = "cbxLevel";
            this.cbxLevel.Size = new System.Drawing.Size(120, 24);
            this.cbxLevel.TabIndex = 4;
            this.cbxLevel.SelectedIndexChanged += new System.EventHandler(this.cbxLevel_SelectedIndexChanged);
            // 
            // cbxGrade
            // 
            this.cbxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrade.FormattingEnabled = true;
            this.cbxGrade.Location = new System.Drawing.Point(501, 117);
            this.cbxGrade.Name = "cbxGrade";
            this.cbxGrade.Size = new System.Drawing.Size(121, 24);
            this.cbxGrade.TabIndex = 5;
            this.cbxGrade.SelectedIndexChanged += new System.EventHandler(this.cbxGrade_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(133, 90);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(102, 24);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Tipo Pago:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(497, 90);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(67, 24);
            this.lblGrade.TabIndex = 8;
            this.lblGrade.Text = "Grado:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(315, 90);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(62, 24);
            this.lblLevel.TabIndex = 9;
            this.lblLevel.Text = "Nivel: ";
            // 
            // frmConceptCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 327);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbxGrade);
            this.Controls.Add(this.cbxLevel);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.lblDataFilter);
            this.Controls.Add(this.dGridConcepts);
            this.Controls.Add(this.lblInfo1);
            this.MinimumSize = new System.Drawing.Size(787, 374);
            this.Name = "frmConceptCatalog";
            this.ShowIcon = false;
            this.Text = "Catalogo de Conceptos";
            this.Load += new System.EventHandler(this.frmConceptCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridConcepts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.DataGridView dGridConcepts;
        private System.Windows.Forms.Label lblDataFilter;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cbxLevel;
        private System.Windows.Forms.ComboBox cbxGrade;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblLevel;
    }
}