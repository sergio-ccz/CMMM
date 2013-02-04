namespace CCMM
{
    partial class frmConceptDetails
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
            this.lblGeneralInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.dateDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbAmount = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGeneralInfo
            // 
            this.lblGeneralInfo.AutoSize = true;
            this.lblGeneralInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralInfo.Location = new System.Drawing.Point(12, 9);
            this.lblGeneralInfo.Name = "lblGeneralInfo";
            this.lblGeneralInfo.Size = new System.Drawing.Size(254, 25);
            this.lblGeneralInfo.TabIndex = 0;
            this.lblGeneralInfo.Text = "Actualiza la información: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(176, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre Concepto: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 150);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(207, 24);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Fecha limite para pago:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(254, 70);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(94, 24);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Cantidad: ";
            // 
            // dateDueDate
            // 
            this.dateDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDueDate.Location = new System.Drawing.Point(47, 177);
            this.dateDueDate.Name = "dateDueDate";
            this.dateDueDate.Size = new System.Drawing.Size(329, 27);
            this.dateDueDate.TabIndex = 4;
            // 
            // txtbName
            // 
            this.txtbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbName.Location = new System.Drawing.Point(47, 100);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(172, 27);
            this.txtbName.TabIndex = 5;
            // 
            // txtbAmount
            // 
            this.txtbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAmount.Location = new System.Drawing.Point(276, 100);
            this.txtbAmount.Name = "txtbAmount";
            this.txtbAmount.Size = new System.Drawing.Size(100, 27);
            this.txtbAmount.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::CCMM.Properties.Resources.CheckMark;
            this.btnSave.Location = new System.Drawing.Point(399, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 66);
            this.btnSave.TabIndex = 7;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmConceptDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 222);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtbAmount);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.dateDueDate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGeneralInfo);
            this.MaximumSize = new System.Drawing.Size(519, 269);
            this.MinimumSize = new System.Drawing.Size(519, 269);
            this.Name = "frmConceptDetails";
            this.ShowIcon = false;
            this.Text = "Detalles de Concepto";
            this.Load += new System.EventHandler(this.frmConceptDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGeneralInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.DateTimePicker dateDueDate;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbAmount;
        private System.Windows.Forms.Button btnSave;
    }
}