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
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.dgridPaymentTable = new System.Windows.Forms.DataGridView();
            this.btnDataPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgridPaymentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.Location = new System.Drawing.Point(12, 9);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(253, 20);
            this.lblInfo1.TabIndex = 0;
            this.lblInfo1.Text = "Impresion de Reporte por día";
            // 
            // lblDatePicker
            // 
            this.lblDatePicker.AutoSize = true;
            this.lblDatePicker.Location = new System.Drawing.Point(13, 54);
            this.lblDatePicker.Name = "lblDatePicker";
            this.lblDatePicker.Size = new System.Drawing.Size(102, 17);
            this.lblDatePicker.TabIndex = 1;
            this.lblDatePicker.Text = "Día a imprimir: ";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(121, 54);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(271, 22);
            this.dtpPaymentDate.TabIndex = 2;
            // 
            // dgridPaymentTable
            // 
            this.dgridPaymentTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgridPaymentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridPaymentTable.Location = new System.Drawing.Point(12, 97);
            this.dgridPaymentTable.Name = "dgridPaymentTable";
            this.dgridPaymentTable.RowTemplate.Height = 24;
            this.dgridPaymentTable.Size = new System.Drawing.Size(584, 191);
            this.dgridPaymentTable.TabIndex = 3;
            // 
            // btnDataPreview
            // 
            this.btnDataPreview.Location = new System.Drawing.Point(408, 50);
            this.btnDataPreview.Name = "btnDataPreview";
            this.btnDataPreview.Size = new System.Drawing.Size(126, 34);
            this.btnDataPreview.TabIndex = 4;
            this.btnDataPreview.Text = "Mostrar pagos";
            this.btnDataPreview.UseVisualStyleBackColor = true;
            this.btnDataPreview.Click += new System.EventHandler(this.btnDataPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::CCMM.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(549, 43);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(47, 48);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 300);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDataPreview);
            this.Controls.Add(this.dgridPaymentTable);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.lblDatePicker);
            this.Controls.Add(this.lblInfo1);
            this.Name = "frmDailyReport";
            this.Text = "Impresión Reporte Diario";
            this.Load += new System.EventHandler(this.frmDailyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridPaymentTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblDatePicker;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.DataGridView dgridPaymentTable;
        private System.Windows.Forms.Button btnDataPreview;
        private System.Windows.Forms.Button btnPrint;
    }
}