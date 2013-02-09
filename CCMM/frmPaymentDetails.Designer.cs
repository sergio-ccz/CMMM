namespace CCMM
{
    partial class frmPaymentDetails
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
            this.txtbFolio = new System.Windows.Forms.TextBox();
            this.txtbAmount = new System.Windows.Forms.TextBox();
            this.datePayment = new System.Windows.Forms.DateTimePicker();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPaymentTitle = new System.Windows.Forms.Label();
            this.lblPayDate = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblComplete = new System.Windows.Forms.Label();
            this.chkCompleted = new System.Windows.Forms.CheckBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbFolio
            // 
            this.txtbFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFolio.Location = new System.Drawing.Point(198, 54);
            this.txtbFolio.Name = "txtbFolio";
            this.txtbFolio.Size = new System.Drawing.Size(100, 27);
            this.txtbFolio.TabIndex = 1;
            // 
            // txtbAmount
            // 
            this.txtbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAmount.Location = new System.Drawing.Point(198, 92);
            this.txtbAmount.Name = "txtbAmount";
            this.txtbAmount.Size = new System.Drawing.Size(100, 27);
            this.txtbAmount.TabIndex = 2;
            // 
            // datePayment
            // 
            this.datePayment.Location = new System.Drawing.Point(199, 176);
            this.datePayment.Name = "datePayment";
            this.datePayment.Size = new System.Drawing.Size(244, 22);
            this.datePayment.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(12, 92);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(174, 24);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Cantidad Pagada:";
            // 
            // lblPaymentTitle
            // 
            this.lblPaymentTitle.AutoSize = true;
            this.lblPaymentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTitle.Location = new System.Drawing.Point(12, 9);
            this.lblPaymentTitle.Name = "lblPaymentTitle";
            this.lblPaymentTitle.Size = new System.Drawing.Size(236, 25);
            this.lblPaymentTitle.TabIndex = 5;
            this.lblPaymentTitle.Text = "Detalles para pago de: ";
            // 
            // lblPayDate
            // 
            this.lblPayDate.AutoSize = true;
            this.lblPayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayDate.Location = new System.Drawing.Point(13, 176);
            this.lblPayDate.Name = "lblPayDate";
            this.lblPayDate.Size = new System.Drawing.Size(159, 24);
            this.lblPayDate.TabIndex = 6;
            this.lblPayDate.Text = "Fecha de Pago:";
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(12, 54);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(57, 24);
            this.lblFolio.TabIndex = 7;
            this.lblFolio.Text = "Folio";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::CCMM.Properties.Resources.CheckMark;
            this.btnSave.Location = new System.Drawing.Point(460, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 75);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Guardar Cambios";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::CCMM.Properties.Resources.Error;
            this.btnDelete.Location = new System.Drawing.Point(460, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 65);
            this.btnDelete.TabIndex = 90;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplete.Location = new System.Drawing.Point(12, 134);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(162, 24);
            this.lblComplete.TabIndex = 91;
            this.lblComplete.Text = "Pago liquidado: ";
            // 
            // chkCompleted
            // 
            this.chkCompleted.AutoSize = true;
            this.chkCompleted.Location = new System.Drawing.Point(199, 140);
            this.chkCompleted.Name = "chkCompleted";
            this.chkCompleted.Size = new System.Drawing.Size(18, 17);
            this.chkCompleted.TabIndex = 92;
            this.chkCompleted.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 209);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(20, 25);
            this.lblInfo.TabIndex = 93;
            this.lblInfo.Text = "-";
            // 
            // frmPaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 243);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.chkCompleted);
            this.Controls.Add(this.lblComplete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.lblPayDate);
            this.Controls.Add(this.lblPaymentTitle);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.datePayment);
            this.Controls.Add(this.txtbAmount);
            this.Controls.Add(this.txtbFolio);
            this.Controls.Add(this.btnSave);
            this.Name = "frmPaymentDetails";
            this.ShowIcon = false;
            this.Text = "Detalles de pago";
            this.Load += new System.EventHandler(this.frmPaymentDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtbFolio;
        private System.Windows.Forms.TextBox txtbAmount;
        private System.Windows.Forms.DateTimePicker datePayment;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPaymentTitle;
        private System.Windows.Forms.Label lblPayDate;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.CheckBox chkCompleted;
        private System.Windows.Forms.Label lblInfo;
    }
}