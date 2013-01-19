namespace CCMM
{
    partial class frmStudentDetails
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
            this.llblResetGrid = new System.Windows.Forms.LinkLabel();
            this.txtbFalseGrade = new System.Windows.Forms.TextBox();
            this.datePaymentTo = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentDateTo = new System.Windows.Forms.Label();
            this.datePaymentFrom = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentDateFrom = new System.Windows.Forms.Label();
            this.btnPrintGrid = new System.Windows.Forms.Button();
            this.lblPaymentHistory = new System.Windows.Forms.Label();
            this.gDataPayments = new System.Windows.Forms.DataGridView();
            this.btnEditSaveAcc = new System.Windows.Forms.Button();
            this.txtbDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.chkSpecialAcc = new System.Windows.Forms.CheckBox();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtbLastName2 = new System.Windows.Forms.TextBox();
            this.lblLastName2 = new System.Windows.Forms.Label();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbAccNum = new System.Windows.Forms.TextBox();
            this.lblAccNum = new System.Windows.Forms.Label();
            this.picUsers = new System.Windows.Forms.PictureBox();
            this.picAccNumber = new System.Windows.Forms.PictureBox();
            this.lblAccType = new System.Windows.Forms.Label();
            this.cbAccType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gDataPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // llblResetGrid
            // 
            this.llblResetGrid.AutoSize = true;
            this.llblResetGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblResetGrid.Location = new System.Drawing.Point(621, 251);
            this.llblResetGrid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblResetGrid.Name = "llblResetGrid";
            this.llblResetGrid.Size = new System.Drawing.Size(82, 18);
            this.llblResetGrid.TabIndex = 81;
            this.llblResetGrid.TabStop = true;
            this.llblResetGrid.Text = "[Ver todo]";
            // 
            // txtbFalseGrade
            // 
            this.txtbFalseGrade.Location = new System.Drawing.Point(510, 35);
            this.txtbFalseGrade.Margin = new System.Windows.Forms.Padding(4);
            this.txtbFalseGrade.Name = "txtbFalseGrade";
            this.txtbFalseGrade.ReadOnly = true;
            this.txtbFalseGrade.Size = new System.Drawing.Size(57, 22);
            this.txtbFalseGrade.TabIndex = 79;
            // 
            // datePaymentTo
            // 
            this.datePaymentTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePaymentTo.Location = new System.Drawing.Point(294, 251);
            this.datePaymentTo.Margin = new System.Windows.Forms.Padding(4);
            this.datePaymentTo.Name = "datePaymentTo";
            this.datePaymentTo.Size = new System.Drawing.Size(120, 22);
            this.datePaymentTo.TabIndex = 78;
            // 
            // lblPaymentDateTo
            // 
            this.lblPaymentDateTo.AutoSize = true;
            this.lblPaymentDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDateTo.Location = new System.Drawing.Point(233, 253);
            this.lblPaymentDateTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentDateTo.Name = "lblPaymentDateTo";
            this.lblPaymentDateTo.Size = new System.Drawing.Size(53, 17);
            this.lblPaymentDateTo.TabIndex = 77;
            this.lblPaymentDateTo.Text = "hasta:";
            // 
            // datePaymentFrom
            // 
            this.datePaymentFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePaymentFrom.Location = new System.Drawing.Point(110, 251);
            this.datePaymentFrom.Margin = new System.Windows.Forms.Padding(4);
            this.datePaymentFrom.Name = "datePaymentFrom";
            this.datePaymentFrom.Size = new System.Drawing.Size(120, 22);
            this.datePaymentFrom.TabIndex = 76;
            // 
            // lblPaymentDateFrom
            // 
            this.lblPaymentDateFrom.AutoSize = true;
            this.lblPaymentDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDateFrom.Location = new System.Drawing.Point(4, 251);
            this.lblPaymentDateFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentDateFrom.Name = "lblPaymentDateFrom";
            this.lblPaymentDateFrom.Size = new System.Drawing.Size(112, 17);
            this.lblPaymentDateFrom.TabIndex = 75;
            this.lblPaymentDateFrom.Text = "Pagos desde: ";
            // 
            // btnPrintGrid
            // 
            this.btnPrintGrid.Location = new System.Drawing.Point(618, 15);
            this.btnPrintGrid.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintGrid.Name = "btnPrintGrid";
            this.btnPrintGrid.Size = new System.Drawing.Size(89, 85);
            this.btnPrintGrid.TabIndex = 74;
            this.btnPrintGrid.Text = "Imprimir Historial";
            this.btnPrintGrid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrintGrid.UseVisualStyleBackColor = true;
            // 
            // lblPaymentHistory
            // 
            this.lblPaymentHistory.AutoSize = true;
            this.lblPaymentHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentHistory.Location = new System.Drawing.Point(4, 226);
            this.lblPaymentHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentHistory.Name = "lblPaymentHistory";
            this.lblPaymentHistory.Size = new System.Drawing.Size(146, 17);
            this.lblPaymentHistory.TabIndex = 73;
            this.lblPaymentHistory.Text = "Historial de Pagos:";
            // 
            // gDataPayments
            // 
            this.gDataPayments.AllowUserToDeleteRows = false;
            this.gDataPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gDataPayments.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.gDataPayments.Location = new System.Drawing.Point(7, 281);
            this.gDataPayments.Margin = new System.Windows.Forms.Padding(4);
            this.gDataPayments.MultiSelect = false;
            this.gDataPayments.Name = "gDataPayments";
            this.gDataPayments.ReadOnly = true;
            this.gDataPayments.Size = new System.Drawing.Size(696, 211);
            this.gDataPayments.TabIndex = 72;
            // 
            // btnEditSaveAcc
            // 
            this.btnEditSaveAcc.Location = new System.Drawing.Point(618, 110);
            this.btnEditSaveAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditSaveAcc.Name = "btnEditSaveAcc";
            this.btnEditSaveAcc.Size = new System.Drawing.Size(89, 30);
            this.btnEditSaveAcc.TabIndex = 71;
            this.btnEditSaveAcc.Text = "Editar";
            this.btnEditSaveAcc.UseVisualStyleBackColor = true;
            this.btnEditSaveAcc.Click += new System.EventHandler(this.btnEditSaveAcc_Click);
            // 
            // txtbDiscount
            // 
            this.txtbDiscount.Location = new System.Drawing.Point(468, 110);
            this.txtbDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtbDiscount.Name = "txtbDiscount";
            this.txtbDiscount.ReadOnly = true;
            this.txtbDiscount.Size = new System.Drawing.Size(113, 22);
            this.txtbDiscount.TabIndex = 64;
            this.txtbDiscount.Visible = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(482, 90);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(99, 18);
            this.lblDiscount.TabIndex = 70;
            this.lblDiscount.Text = "Descuento: ";
            // 
            // chkSpecialAcc
            // 
            this.chkSpecialAcc.AutoSize = true;
            this.chkSpecialAcc.Enabled = false;
            this.chkSpecialAcc.Location = new System.Drawing.Point(454, 89);
            this.chkSpecialAcc.Margin = new System.Windows.Forms.Padding(4);
            this.chkSpecialAcc.Name = "chkSpecialAcc";
            this.chkSpecialAcc.Size = new System.Drawing.Size(18, 17);
            this.chkSpecialAcc.TabIndex = 63;
            this.chkSpecialAcc.UseVisualStyleBackColor = true;
            // 
            // cbGrade
            // 
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "Solo MI"});
            this.cbGrade.Location = new System.Drawing.Point(510, 35);
            this.cbGrade.Margin = new System.Windows.Forms.Padding(4);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(57, 24);
            this.cbGrade.TabIndex = 62;
            this.cbGrade.Visible = false;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(492, 15);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(65, 18);
            this.lblGrade.TabIndex = 69;
            this.lblGrade.Text = "Grado: ";
            // 
            // txtbLastName2
            // 
            this.txtbLastName2.Location = new System.Drawing.Point(239, 110);
            this.txtbLastName2.Margin = new System.Windows.Forms.Padding(4);
            this.txtbLastName2.Name = "txtbLastName2";
            this.txtbLastName2.ReadOnly = true;
            this.txtbLastName2.Size = new System.Drawing.Size(180, 22);
            this.txtbLastName2.TabIndex = 61;
            // 
            // lblLastName2
            // 
            this.lblLastName2.AutoSize = true;
            this.lblLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName2.Location = new System.Drawing.Point(224, 89);
            this.lblLastName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName2.Name = "lblLastName2";
            this.lblLastName2.Size = new System.Drawing.Size(144, 18);
            this.lblLastName2.TabIndex = 68;
            this.lblLastName2.Text = "Apellido Materno: ";
            // 
            // txtbLastName
            // 
            this.txtbLastName.Location = new System.Drawing.Point(35, 112);
            this.txtbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.ReadOnly = true;
            this.txtbLastName.Size = new System.Drawing.Size(167, 22);
            this.txtbLastName.TabIndex = 60;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(20, 90);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(141, 18);
            this.lblLastName.TabIndex = 67;
            this.lblLastName.Text = "Apellido Paterno: ";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(292, 38);
            this.txtbName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbName.Name = "txtbName";
            this.txtbName.ReadOnly = true;
            this.txtbName.Size = new System.Drawing.Size(180, 22);
            this.txtbName.TabIndex = 59;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(280, 15);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 18);
            this.lblName.TabIndex = 66;
            this.lblName.Text = "Nombre: ";
            // 
            // txtbAccNum
            // 
            this.txtbAccNum.Location = new System.Drawing.Point(124, 38);
            this.txtbAccNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtbAccNum.Name = "txtbAccNum";
            this.txtbAccNum.ReadOnly = true;
            this.txtbAccNum.Size = new System.Drawing.Size(95, 22);
            this.txtbAccNum.TabIndex = 58;
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNum.Location = new System.Drawing.Point(107, 15);
            this.lblAccNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(66, 18);
            this.lblAccNum.TabIndex = 65;
            this.lblAccNum.Text = "Cuenta:";
            // 
            // picUsers
            // 
            this.picUsers.Image = global::CCMM.Properties.Resources.Users;
            this.picUsers.Location = new System.Drawing.Point(24, 15);
            this.picUsers.Margin = new System.Windows.Forms.Padding(4);
            this.picUsers.Name = "picUsers";
            this.picUsers.Size = new System.Drawing.Size(64, 59);
            this.picUsers.TabIndex = 82;
            this.picUsers.TabStop = false;
            // 
            // picAccNumber
            // 
            this.picAccNumber.Location = new System.Drawing.Point(227, 35);
            this.picAccNumber.Margin = new System.Windows.Forms.Padding(4);
            this.picAccNumber.Name = "picAccNumber";
            this.picAccNumber.Size = new System.Drawing.Size(31, 25);
            this.picAccNumber.TabIndex = 80;
            this.picAccNumber.TabStop = false;
            // 
            // lblAccType
            // 
            this.lblAccType.AutoSize = true;
            this.lblAccType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccType.Location = new System.Drawing.Point(21, 146);
            this.lblAccType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(127, 18);
            this.lblAccType.TabIndex = 83;
            this.lblAccType.Text = "Tipo de Cuenta:";
            // 
            // cbAccType
            // 
            this.cbAccType.Enabled = false;
            this.cbAccType.FormattingEnabled = true;
            this.cbAccType.Location = new System.Drawing.Point(35, 167);
            this.cbAccType.Name = "cbAccType";
            this.cbAccType.Size = new System.Drawing.Size(126, 24);
            this.cbAccType.TabIndex = 84;
            // 
            // frmStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 505);
            this.Controls.Add(this.cbAccType);
            this.Controls.Add(this.lblAccType);
            this.Controls.Add(this.picUsers);
            this.Controls.Add(this.llblResetGrid);
            this.Controls.Add(this.picAccNumber);
            this.Controls.Add(this.txtbFalseGrade);
            this.Controls.Add(this.datePaymentTo);
            this.Controls.Add(this.lblPaymentDateTo);
            this.Controls.Add(this.datePaymentFrom);
            this.Controls.Add(this.lblPaymentDateFrom);
            this.Controls.Add(this.btnPrintGrid);
            this.Controls.Add(this.lblPaymentHistory);
            this.Controls.Add(this.gDataPayments);
            this.Controls.Add(this.btnEditSaveAcc);
            this.Controls.Add(this.txtbDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.chkSpecialAcc);
            this.Controls.Add(this.cbGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtbLastName2);
            this.Controls.Add(this.lblLastName2);
            this.Controls.Add(this.txtbLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtbAccNum);
            this.Controls.Add(this.lblAccNum);
            this.Name = "frmStudentDetails";
            this.ShowIcon = false;
            this.Text = "Detalles para [Estudiante]";
            this.Load += new System.EventHandler(this.frmStudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gDataPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picUsers;
        private System.Windows.Forms.LinkLabel llblResetGrid;
        private System.Windows.Forms.PictureBox picAccNumber;
        private System.Windows.Forms.TextBox txtbFalseGrade;
        private System.Windows.Forms.DateTimePicker datePaymentTo;
        private System.Windows.Forms.Label lblPaymentDateTo;
        private System.Windows.Forms.DateTimePicker datePaymentFrom;
        private System.Windows.Forms.Label lblPaymentDateFrom;
        private System.Windows.Forms.Button btnPrintGrid;
        private System.Windows.Forms.Label lblPaymentHistory;
        private System.Windows.Forms.DataGridView gDataPayments;
        private System.Windows.Forms.Button btnEditSaveAcc;
        private System.Windows.Forms.TextBox txtbDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.CheckBox chkSpecialAcc;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtbLastName2;
        private System.Windows.Forms.Label lblLastName2;
        private System.Windows.Forms.TextBox txtbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbAccNum;
        private System.Windows.Forms.Label lblAccNum;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.ComboBox cbAccType;
    }
}