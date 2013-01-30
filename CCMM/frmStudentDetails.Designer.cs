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
            this.lblAccType = new System.Windows.Forms.Label();
            this.cbAccType = new System.Windows.Forms.ComboBox();
            this.picUsers = new System.Windows.Forms.PictureBox();
            this.picAccNumber = new System.Windows.Forms.PictureBox();
            this.lnlblExpPayments = new System.Windows.Forms.LinkLabel();
            this.cbSchoolLevel = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gDataPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // llblResetGrid
            // 
            this.llblResetGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llblResetGrid.AutoSize = true;
            this.llblResetGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblResetGrid.Location = new System.Drawing.Point(536, 222);
            this.llblResetGrid.Name = "llblResetGrid";
            this.llblResetGrid.Size = new System.Drawing.Size(69, 20);
            this.llblResetGrid.TabIndex = 81;
            this.llblResetGrid.TabStop = true;
            this.llblResetGrid.Text = "[Pagos]";
            this.llblResetGrid.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblResetGrid_LinkClicked);
            // 
            // datePaymentTo
            // 
            this.datePaymentTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePaymentTo.Location = new System.Drawing.Point(219, 225);
            this.datePaymentTo.Name = "datePaymentTo";
            this.datePaymentTo.Size = new System.Drawing.Size(91, 20);
            this.datePaymentTo.TabIndex = 78;
            this.datePaymentTo.ValueChanged += new System.EventHandler(this.datePaymentTo_ValueChanged);
            // 
            // lblPaymentDateTo
            // 
            this.lblPaymentDateTo.AutoSize = true;
            this.lblPaymentDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDateTo.Location = new System.Drawing.Point(174, 227);
            this.lblPaymentDateTo.Name = "lblPaymentDateTo";
            this.lblPaymentDateTo.Size = new System.Drawing.Size(42, 13);
            this.lblPaymentDateTo.TabIndex = 77;
            this.lblPaymentDateTo.Text = "hasta:";
            // 
            // datePaymentFrom
            // 
            this.datePaymentFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePaymentFrom.Location = new System.Drawing.Point(81, 225);
            this.datePaymentFrom.Name = "datePaymentFrom";
            this.datePaymentFrom.Size = new System.Drawing.Size(91, 20);
            this.datePaymentFrom.TabIndex = 76;
            this.datePaymentFrom.ValueChanged += new System.EventHandler(this.datePaymentFrom_ValueChanged);
            // 
            // lblPaymentDateFrom
            // 
            this.lblPaymentDateFrom.AutoSize = true;
            this.lblPaymentDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDateFrom.Location = new System.Drawing.Point(2, 225);
            this.lblPaymentDateFrom.Name = "lblPaymentDateFrom";
            this.lblPaymentDateFrom.Size = new System.Drawing.Size(88, 13);
            this.lblPaymentDateFrom.TabIndex = 75;
            this.lblPaymentDateFrom.Text = "Pagos desde: ";
            // 
            // btnPrintGrid
            // 
            this.btnPrintGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintGrid.Location = new System.Drawing.Point(519, 12);
            this.btnPrintGrid.Name = "btnPrintGrid";
            this.btnPrintGrid.Size = new System.Drawing.Size(87, 69);
            this.btnPrintGrid.TabIndex = 74;
            this.btnPrintGrid.Text = "Imprimir Historial";
            this.btnPrintGrid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrintGrid.UseVisualStyleBackColor = true;
            this.btnPrintGrid.Click += new System.EventHandler(this.btnPrintGrid_Click);
            // 
            // lblPaymentHistory
            // 
            this.lblPaymentHistory.AutoSize = true;
            this.lblPaymentHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentHistory.Location = new System.Drawing.Point(2, 205);
            this.lblPaymentHistory.Name = "lblPaymentHistory";
            this.lblPaymentHistory.Size = new System.Drawing.Size(177, 13);
            this.lblPaymentHistory.TabIndex = 73;
            this.lblPaymentHistory.Text = "Historial de Pagos y Adeudos:";
            // 
            // gDataPayments
            // 
            this.gDataPayments.AllowUserToDeleteRows = false;
            this.gDataPayments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gDataPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gDataPayments.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.gDataPayments.Location = new System.Drawing.Point(5, 252);
            this.gDataPayments.MultiSelect = false;
            this.gDataPayments.Name = "gDataPayments";
            this.gDataPayments.ReadOnly = true;
            this.gDataPayments.Size = new System.Drawing.Size(601, 173);
            this.gDataPayments.TabIndex = 72;
            // 
            // btnEditSaveAcc
            // 
            this.btnEditSaveAcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditSaveAcc.Location = new System.Drawing.Point(519, 89);
            this.btnEditSaveAcc.Name = "btnEditSaveAcc";
            this.btnEditSaveAcc.Size = new System.Drawing.Size(87, 24);
            this.btnEditSaveAcc.TabIndex = 71;
            this.btnEditSaveAcc.Text = "Editar";
            this.btnEditSaveAcc.UseVisualStyleBackColor = true;
            this.btnEditSaveAcc.Click += new System.EventHandler(this.btnEditSaveAcc_Click);
            // 
            // txtbDiscount
            // 
            this.txtbDiscount.Location = new System.Drawing.Point(382, 89);
            this.txtbDiscount.Name = "txtbDiscount";
            this.txtbDiscount.ReadOnly = true;
            this.txtbDiscount.Size = new System.Drawing.Size(86, 20);
            this.txtbDiscount.TabIndex = 64;
            this.txtbDiscount.Visible = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(393, 73);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(83, 15);
            this.lblDiscount.TabIndex = 70;
            this.lblDiscount.Text = "Descuento: ";
            // 
            // chkSpecialAcc
            // 
            this.chkSpecialAcc.AutoSize = true;
            this.chkSpecialAcc.Enabled = false;
            this.chkSpecialAcc.Location = new System.Drawing.Point(371, 72);
            this.chkSpecialAcc.Name = "chkSpecialAcc";
            this.chkSpecialAcc.Size = new System.Drawing.Size(15, 14);
            this.chkSpecialAcc.TabIndex = 63;
            this.chkSpecialAcc.UseVisualStyleBackColor = true;
            this.chkSpecialAcc.CheckedChanged += new System.EventHandler(this.chkSpecialAcc_CheckedChanged);
            // 
            // cbGrade
            // 
            this.cbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            "17"});
            this.cbGrade.Location = new System.Drawing.Point(197, 144);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(79, 21);
            this.cbGrade.TabIndex = 62;
            this.cbGrade.SelectedIndexChanged += new System.EventHandler(this.cbGrade_SelectedIndexChanged);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(186, 120);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(54, 15);
            this.lblGrade.TabIndex = 69;
            this.lblGrade.Text = "Grado: ";
            // 
            // txtbLastName2
            // 
            this.txtbLastName2.Location = new System.Drawing.Point(197, 89);
            this.txtbLastName2.Name = "txtbLastName2";
            this.txtbLastName2.ReadOnly = true;
            this.txtbLastName2.Size = new System.Drawing.Size(136, 20);
            this.txtbLastName2.TabIndex = 61;
            // 
            // lblLastName2
            // 
            this.lblLastName2.AutoSize = true;
            this.lblLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName2.Location = new System.Drawing.Point(186, 72);
            this.lblLastName2.Name = "lblLastName2";
            this.lblLastName2.Size = new System.Drawing.Size(124, 15);
            this.lblLastName2.TabIndex = 68;
            this.lblLastName2.Text = "Apellido Materno: ";
            // 
            // txtbLastName
            // 
            this.txtbLastName.Location = new System.Drawing.Point(26, 91);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.ReadOnly = true;
            this.txtbLastName.Size = new System.Drawing.Size(126, 20);
            this.txtbLastName.TabIndex = 60;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(15, 73);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(121, 15);
            this.lblLastName.TabIndex = 67;
            this.lblLastName.Text = "Apellido Paterno: ";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(219, 31);
            this.txtbName.Name = "txtbName";
            this.txtbName.ReadOnly = true;
            this.txtbName.Size = new System.Drawing.Size(136, 20);
            this.txtbName.TabIndex = 59;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(210, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 15);
            this.lblName.TabIndex = 66;
            this.lblName.Text = "Nombre: ";
            // 
            // txtbAccNum
            // 
            this.txtbAccNum.Location = new System.Drawing.Point(93, 31);
            this.txtbAccNum.Name = "txtbAccNum";
            this.txtbAccNum.ReadOnly = true;
            this.txtbAccNum.Size = new System.Drawing.Size(72, 20);
            this.txtbAccNum.TabIndex = 58;
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNum.Location = new System.Drawing.Point(80, 12);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(56, 15);
            this.lblAccNum.TabIndex = 65;
            this.lblAccNum.Text = "Cuenta:";
            // 
            // lblAccType
            // 
            this.lblAccType.AutoSize = true;
            this.lblAccType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccType.Location = new System.Drawing.Point(360, 12);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(108, 15);
            this.lblAccType.TabIndex = 83;
            this.lblAccType.Text = "Tipo de Cuenta:";
            // 
            // cbAccType
            // 
            this.cbAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccType.Enabled = false;
            this.cbAccType.FormattingEnabled = true;
            this.cbAccType.Items.AddRange(new object[] {
            "Normal",
            "Diferido"});
            this.cbAccType.Location = new System.Drawing.Point(370, 29);
            this.cbAccType.Margin = new System.Windows.Forms.Padding(2);
            this.cbAccType.Name = "cbAccType";
            this.cbAccType.Size = new System.Drawing.Size(96, 21);
            this.cbAccType.TabIndex = 84;
            // 
            // picUsers
            // 
            this.picUsers.Image = global::CCMM.Properties.Resources.Users;
            this.picUsers.Location = new System.Drawing.Point(18, 12);
            this.picUsers.Name = "picUsers";
            this.picUsers.Size = new System.Drawing.Size(48, 48);
            this.picUsers.TabIndex = 82;
            this.picUsers.TabStop = false;
            // 
            // picAccNumber
            // 
            this.picAccNumber.Location = new System.Drawing.Point(170, 28);
            this.picAccNumber.Name = "picAccNumber";
            this.picAccNumber.Size = new System.Drawing.Size(23, 20);
            this.picAccNumber.TabIndex = 80;
            this.picAccNumber.TabStop = false;
            // 
            // lnlblExpPayments
            // 
            this.lnlblExpPayments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnlblExpPayments.AutoSize = true;
            this.lnlblExpPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlblExpPayments.Location = new System.Drawing.Point(440, 222);
            this.lnlblExpPayments.Name = "lnlblExpPayments";
            this.lnlblExpPayments.Size = new System.Drawing.Size(90, 20);
            this.lnlblExpPayments.TabIndex = 86;
            this.lnlblExpPayments.TabStop = true;
            this.lnlblExpPayments.Text = "[Adeudos]";
            this.lnlblExpPayments.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlblExpPayments_LinkClicked);
            // 
            // cbSchoolLevel
            // 
            this.cbSchoolLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSchoolLevel.Enabled = false;
            this.cbSchoolLevel.FormattingEnabled = true;
            this.cbSchoolLevel.Items.AddRange(new object[] {
            "Primaria",
            "Secundaria",
            "Preparatoria",
            "Universidad",
            "Medio Internado"});
            this.cbSchoolLevel.Location = new System.Drawing.Point(26, 144);
            this.cbSchoolLevel.Name = "cbSchoolLevel";
            this.cbSchoolLevel.Size = new System.Drawing.Size(126, 21);
            this.cbSchoolLevel.TabIndex = 87;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(15, 120);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(95, 15);
            this.lblLevel.TabIndex = 88;
            this.lblLevel.Text = "Nivel Escolar:";
            // 
            // frmStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 437);
            this.Controls.Add(this.cbSchoolLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lnlblExpPayments);
            this.Controls.Add(this.cbAccType);
            this.Controls.Add(this.lblAccType);
            this.Controls.Add(this.picUsers);
            this.Controls.Add(this.llblResetGrid);
            this.Controls.Add(this.picAccNumber);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.LinkLabel lnlblExpPayments;
        private System.Windows.Forms.ComboBox cbSchoolLevel;
        private System.Windows.Forms.Label lblLevel;
    }
}