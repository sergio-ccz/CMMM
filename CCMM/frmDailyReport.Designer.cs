namespace CCMM
{
    partial class frmDailyReport
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
            this.lblDatePicker = new System.Windows.Forms.Label();
            this.dgridPaymentTable = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblWarnings = new System.Windows.Forms.TextBox();
            this.gbDates = new System.Windows.Forms.GroupBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate2 = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgridPaymentTable)).BeginInit();
            this.gbDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.Location = new System.Drawing.Point(12, 9);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(275, 20);
            this.lblInfo1.TabIndex = 0;
            this.lblInfo1.Text = "Reporte de Ingresos Escolares ";
            // 
            // lblDatePicker
            // 
            this.lblDatePicker.AutoSize = true;
            this.lblDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePicker.Location = new System.Drawing.Point(12, 38);
            this.lblDatePicker.Name = "lblDatePicker";
            this.lblDatePicker.Size = new System.Drawing.Size(197, 24);
            this.lblDatePicker.TabIndex = 1;
            this.lblDatePicker.Text = "Fecha(s) a imprimir:";
            // 
            // dgridPaymentTable
            // 
            this.dgridPaymentTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgridPaymentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridPaymentTable.Location = new System.Drawing.Point(12, 156);
            this.dgridPaymentTable.Name = "dgridPaymentTable";
            this.dgridPaymentTable.RowTemplate.Height = 24;
            this.dgridPaymentTable.Size = new System.Drawing.Size(583, 175);
            this.dgridPaymentTable.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::CCMM.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(510, 83);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 48);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblWarnings
            // 
            this.lblWarnings.BackColor = System.Drawing.SystemColors.Window;
            this.lblWarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnings.Location = new System.Drawing.Point(12, 192);
            this.lblWarnings.Multiline = true;
            this.lblWarnings.Name = "lblWarnings";
            this.lblWarnings.Size = new System.Drawing.Size(583, 70);
            this.lblWarnings.TabIndex = 9;
            this.lblWarnings.Text = "Este tipo de reportes no genera vista previa, por favor genera el achivo para ver" +
    " los datos";
            this.lblWarnings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblWarnings.Visible = false;
            // 
            // gbDates
            // 
            this.gbDates.Controls.Add(this.lblToDate);
            this.gbDates.Controls.Add(this.lblFromDate);
            this.gbDates.Controls.Add(this.dtpPaymentDate2);
            this.gbDates.Controls.Add(this.dtpPaymentDate);
            this.gbDates.Location = new System.Drawing.Point(75, 65);
            this.gbDates.Name = "gbDates";
            this.gbDates.Size = new System.Drawing.Size(417, 76);
            this.gbDates.TabIndex = 10;
            this.gbDates.TabStop = false;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(247, 18);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(68, 24);
            this.lblToDate.TabIndex = 14;
            this.lblToDate.Text = "Hasta:";
            // 
            // dtpPaymentDate2
            // 
            this.dtpPaymentDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate2.Location = new System.Drawing.Point(278, 45);
            this.dtpPaymentDate2.Name = "dtpPaymentDate2";
            this.dtpPaymentDate2.Size = new System.Drawing.Size(123, 22);
            this.dtpPaymentDate2.TabIndex = 13;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(40, 18);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(82, 24);
            this.lblFromDate.TabIndex = 12;
            this.lblFromDate.Text = "Desde: ";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(77, 45);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(123, 22);
            this.dtpPaymentDate.TabIndex = 11;
            // 
            // frmDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 343);
            this.Controls.Add(this.gbDates);
            this.Controls.Add(this.lblWarnings);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgridPaymentTable);
            this.Controls.Add(this.lblDatePicker);
            this.Controls.Add(this.lblInfo1);
            this.Name = "frmDailyReport";
            this.ShowIcon = false;
            this.Text = "Impresión Reporte por Fecha(s)";
            this.Load += new System.EventHandler(this.frmDailyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridPaymentTable)).EndInit();
            this.gbDates.ResumeLayout(false);
            this.gbDates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblDatePicker;
        private System.Windows.Forms.DataGridView dgridPaymentTable;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox lblWarnings;
        private System.Windows.Forms.GroupBox gbDates;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate2;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
    }
}