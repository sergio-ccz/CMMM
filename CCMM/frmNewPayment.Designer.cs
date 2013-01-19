namespace CCMM
{
    partial class frmNewPayment
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
            this.llinkViewAccDetails = new System.Windows.Forms.LinkLabel();
            this.gbxPaymentDetails = new System.Windows.Forms.GroupBox();
            this.picDiscountWarning = new System.Windows.Forms.PictureBox();
            this.txtbPaymentAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.txtbPaymentFolio = new System.Windows.Forms.TextBox();
            this.lblPaymentFolio = new System.Windows.Forms.Label();
            this.lblPaymentComplete = new System.Windows.Forms.Label();
            this.cbPaymentComplete = new System.Windows.Forms.CheckBox();
            this.btnSavePayment = new System.Windows.Forms.Button();
            this.datePaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbPaymentConcept = new System.Windows.Forms.ComboBox();
            this.lblPaymentConcept = new System.Windows.Forms.Label();
            this.btnStudentSearch = new System.Windows.Forms.Button();
            this.txtbAccNum = new System.Windows.Forms.TextBox();
            this.lblAccNum = new System.Windows.Forms.Label();
            this.picUsers = new System.Windows.Forms.PictureBox();
            this.picAccNumber = new System.Windows.Forms.PictureBox();
            this.gbxPaymentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDiscountWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // llinkViewAccDetails
            // 
            this.llinkViewAccDetails.AutoSize = true;
            this.llinkViewAccDetails.Location = new System.Drawing.Point(10, 74);
            this.llinkViewAccDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llinkViewAccDetails.Name = "llinkViewAccDetails";
            this.llinkViewAccDetails.Size = new System.Drawing.Size(156, 17);
            this.llinkViewAccDetails.TabIndex = 36;
            this.llinkViewAccDetails.TabStop = true;
            this.llinkViewAccDetails.Text = "Ver detalles del alumno";
            this.llinkViewAccDetails.Visible = false;
            this.llinkViewAccDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llinkViewAccDetails_LinkClicked);
            // 
            // gbxPaymentDetails
            // 
            this.gbxPaymentDetails.Controls.Add(this.picDiscountWarning);
            this.gbxPaymentDetails.Controls.Add(this.txtbPaymentAmount);
            this.gbxPaymentDetails.Controls.Add(this.lblPaymentAmount);
            this.gbxPaymentDetails.Controls.Add(this.cbPaymentType);
            this.gbxPaymentDetails.Controls.Add(this.lblPaymentType);
            this.gbxPaymentDetails.Controls.Add(this.txtbPaymentFolio);
            this.gbxPaymentDetails.Controls.Add(this.lblPaymentFolio);
            this.gbxPaymentDetails.Controls.Add(this.lblPaymentComplete);
            this.gbxPaymentDetails.Controls.Add(this.cbPaymentComplete);
            this.gbxPaymentDetails.Controls.Add(this.btnSavePayment);
            this.gbxPaymentDetails.Controls.Add(this.datePaymentDate);
            this.gbxPaymentDetails.Controls.Add(this.lblDate);
            this.gbxPaymentDetails.Controls.Add(this.cbPaymentConcept);
            this.gbxPaymentDetails.Controls.Add(this.lblPaymentConcept);
            this.gbxPaymentDetails.Location = new System.Drawing.Point(10, 107);
            this.gbxPaymentDetails.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPaymentDetails.Name = "gbxPaymentDetails";
            this.gbxPaymentDetails.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPaymentDetails.Size = new System.Drawing.Size(624, 274);
            this.gbxPaymentDetails.TabIndex = 35;
            this.gbxPaymentDetails.TabStop = false;
            this.gbxPaymentDetails.Text = "Detalles de Pago";
            // 
            // picDiscountWarning
            // 
            this.picDiscountWarning.Location = new System.Drawing.Point(210, 169);
            this.picDiscountWarning.Margin = new System.Windows.Forms.Padding(4);
            this.picDiscountWarning.Name = "picDiscountWarning";
            this.picDiscountWarning.Size = new System.Drawing.Size(31, 25);
            this.picDiscountWarning.TabIndex = 39;
            this.picDiscountWarning.TabStop = false;
            // 
            // txtbPaymentAmount
            // 
            this.txtbPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPaymentAmount.Location = new System.Drawing.Point(46, 172);
            this.txtbPaymentAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtbPaymentAmount.Name = "txtbPaymentAmount";
            this.txtbPaymentAmount.Size = new System.Drawing.Size(156, 24);
            this.txtbPaymentAmount.TabIndex = 38;
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentAmount.Location = new System.Drawing.Point(23, 144);
            this.lblPaymentAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(115, 24);
            this.lblPaymentAmount.TabIndex = 37;
            this.lblPaymentAmount.Text = "Cantidad $:";
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Location = new System.Drawing.Point(52, 103);
            this.cbPaymentType.Margin = new System.Windows.Forms.Padding(4);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(208, 26);
            this.cbPaymentType.TabIndex = 36;
            this.cbPaymentType.SelectedIndexChanged += new System.EventHandler(this.cbPaymentType_SelectedIndexChanged);
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(23, 75);
            this.lblPaymentType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(142, 24);
            this.lblPaymentType.TabIndex = 35;
            this.lblPaymentType.Text = "Tipo de Pago:";
            // 
            // txtbPaymentFolio
            // 
            this.txtbPaymentFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPaymentFolio.Location = new System.Drawing.Point(52, 47);
            this.txtbPaymentFolio.Margin = new System.Windows.Forms.Padding(4);
            this.txtbPaymentFolio.Name = "txtbPaymentFolio";
            this.txtbPaymentFolio.Size = new System.Drawing.Size(132, 24);
            this.txtbPaymentFolio.TabIndex = 34;
            // 
            // lblPaymentFolio
            // 
            this.lblPaymentFolio.AutoSize = true;
            this.lblPaymentFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentFolio.Location = new System.Drawing.Point(23, 19);
            this.lblPaymentFolio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentFolio.Name = "lblPaymentFolio";
            this.lblPaymentFolio.Size = new System.Drawing.Size(80, 24);
            this.lblPaymentFolio.TabIndex = 33;
            this.lblPaymentFolio.Text = "# Folio:";
            // 
            // lblPaymentComplete
            // 
            this.lblPaymentComplete.AutoSize = true;
            this.lblPaymentComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentComplete.Location = new System.Drawing.Point(27, 213);
            this.lblPaymentComplete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentComplete.Name = "lblPaymentComplete";
            this.lblPaymentComplete.Size = new System.Drawing.Size(108, 24);
            this.lblPaymentComplete.TabIndex = 31;
            this.lblPaymentComplete.Text = "Liquidado:";
            // 
            // cbPaymentComplete
            // 
            this.cbPaymentComplete.AutoSize = true;
            this.cbPaymentComplete.Location = new System.Drawing.Point(143, 219);
            this.cbPaymentComplete.Margin = new System.Windows.Forms.Padding(4);
            this.cbPaymentComplete.Name = "cbPaymentComplete";
            this.cbPaymentComplete.Size = new System.Drawing.Size(18, 17);
            this.cbPaymentComplete.TabIndex = 30;
            this.cbPaymentComplete.UseVisualStyleBackColor = true;
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePayment.Location = new System.Drawing.Point(402, 201);
            this.btnSavePayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.Size = new System.Drawing.Size(214, 35);
            this.btnSavePayment.TabIndex = 29;
            this.btnSavePayment.Text = "Guardar Pago";
            this.btnSavePayment.UseVisualStyleBackColor = true;
            this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click);
            // 
            // datePaymentDate
            // 
            this.datePaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePaymentDate.Location = new System.Drawing.Point(293, 45);
            this.datePaymentDate.Margin = new System.Windows.Forms.Padding(4);
            this.datePaymentDate.Name = "datePaymentDate";
            this.datePaymentDate.Size = new System.Drawing.Size(192, 24);
            this.datePaymentDate.TabIndex = 27;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(283, 19);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(165, 24);
            this.lblDate.TabIndex = 26;
            this.lblDate.Text = "Fecha de Pago: ";
            // 
            // cbPaymentConcept
            // 
            this.cbPaymentConcept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentConcept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentConcept.FormattingEnabled = true;
            this.cbPaymentConcept.Location = new System.Drawing.Point(293, 103);
            this.cbPaymentConcept.Margin = new System.Windows.Forms.Padding(4);
            this.cbPaymentConcept.Name = "cbPaymentConcept";
            this.cbPaymentConcept.Size = new System.Drawing.Size(323, 26);
            this.cbPaymentConcept.TabIndex = 21;
            this.cbPaymentConcept.SelectedIndexChanged += new System.EventHandler(this.cbPaymentConcept_SelectedIndexChanged);
            // 
            // lblPaymentConcept
            // 
            this.lblPaymentConcept.AutoSize = true;
            this.lblPaymentConcept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentConcept.Location = new System.Drawing.Point(283, 75);
            this.lblPaymentConcept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentConcept.Name = "lblPaymentConcept";
            this.lblPaymentConcept.Size = new System.Drawing.Size(112, 24);
            this.lblPaymentConcept.TabIndex = 20;
            this.lblPaymentConcept.Text = "Concepto: ";
            // 
            // btnStudentSearch
            // 
            this.btnStudentSearch.Location = new System.Drawing.Point(263, 36);
            this.btnStudentSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentSearch.Name = "btnStudentSearch";
            this.btnStudentSearch.Size = new System.Drawing.Size(161, 28);
            this.btnStudentSearch.TabIndex = 33;
            this.btnStudentSearch.Text = "Buscar Alumno";
            this.btnStudentSearch.UseVisualStyleBackColor = true;
            this.btnStudentSearch.Click += new System.EventHandler(this.btnStudentSearch_Click);
            // 
            // txtbAccNum
            // 
            this.txtbAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAccNum.Location = new System.Drawing.Point(72, 41);
            this.txtbAccNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtbAccNum.Name = "txtbAccNum";
            this.txtbAccNum.Size = new System.Drawing.Size(132, 24);
            this.txtbAccNum.TabIndex = 32;
            this.txtbAccNum.TextChanged += new System.EventHandler(this.txtbAccNum_TextChanged);
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNum.Location = new System.Drawing.Point(68, 13);
            this.lblAccNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(99, 24);
            this.lblAccNum.TabIndex = 31;
            this.lblAccNum.Text = "#Cuenta: ";
            // 
            // picUsers
            // 
            this.picUsers.Image = global::CCMM.Properties.Resources.Users;
            this.picUsers.Location = new System.Drawing.Point(13, 13);
            this.picUsers.Margin = new System.Windows.Forms.Padding(4);
            this.picUsers.Name = "picUsers";
            this.picUsers.Size = new System.Drawing.Size(51, 51);
            this.picUsers.TabIndex = 37;
            this.picUsers.TabStop = false;
            // 
            // picAccNumber
            // 
            this.picAccNumber.Location = new System.Drawing.Point(212, 26);
            this.picAccNumber.Margin = new System.Windows.Forms.Padding(4);
            this.picAccNumber.Name = "picAccNumber";
            this.picAccNumber.Size = new System.Drawing.Size(43, 39);
            this.picAccNumber.TabIndex = 34;
            this.picAccNumber.TabStop = false;
            // 
            // frmNewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 394);
            this.Controls.Add(this.picUsers);
            this.Controls.Add(this.llinkViewAccDetails);
            this.Controls.Add(this.gbxPaymentDetails);
            this.Controls.Add(this.picAccNumber);
            this.Controls.Add(this.btnStudentSearch);
            this.Controls.Add(this.txtbAccNum);
            this.Controls.Add(this.lblAccNum);
            this.Name = "frmNewPayment";
            this.ShowIcon = false;
            this.Text = "Nuevo Pago";
            this.Load += new System.EventHandler(this.frmNewPayment_Load);
            this.gbxPaymentDetails.ResumeLayout(false);
            this.gbxPaymentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDiscountWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picUsers;
        private System.Windows.Forms.LinkLabel llinkViewAccDetails;
        private System.Windows.Forms.GroupBox gbxPaymentDetails;
        private System.Windows.Forms.TextBox txtbPaymentFolio;
        private System.Windows.Forms.Label lblPaymentFolio;
        private System.Windows.Forms.Label lblPaymentComplete;
        private System.Windows.Forms.CheckBox cbPaymentComplete;
        private System.Windows.Forms.Button btnSavePayment;
        private System.Windows.Forms.DateTimePicker datePaymentDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbPaymentConcept;
        private System.Windows.Forms.Label lblPaymentConcept;
        private System.Windows.Forms.PictureBox picAccNumber;
        private System.Windows.Forms.Button btnStudentSearch;
        private System.Windows.Forms.TextBox txtbAccNum;
        private System.Windows.Forms.Label lblAccNum;
        private System.Windows.Forms.PictureBox picDiscountWarning;
        private System.Windows.Forms.TextBox txtbPaymentAmount;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.ComboBox cbPaymentType;
        private System.Windows.Forms.Label lblPaymentType;
    }
}