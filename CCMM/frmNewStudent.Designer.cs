namespace CCMM
{
    partial class frmNewStudent
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
            this.lblWarning = new System.Windows.Forms.Label();
            this.cbAccType = new System.Windows.Forms.ComboBox();
            this.lblAccType = new System.Windows.Forms.Label();
            this.picUsers = new System.Windows.Forms.PictureBox();
            this.picAccNumber = new System.Windows.Forms.PictureBox();
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
            this.btnSaveNewStudent = new System.Windows.Forms.Button();
            this.cbSchoolLevel = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(9, 276);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(13, 17);
            this.lblWarning.TabIndex = 71;
            this.lblWarning.Text = "-";
            this.lblWarning.Visible = false;
            // 
            // cbAccType
            // 
            this.cbAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccType.FormattingEnabled = true;
            this.cbAccType.Items.AddRange(new object[] {
            "Normal",
            "Diferido"});
            this.cbAccType.Location = new System.Drawing.Point(484, 43);
            this.cbAccType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAccType.Name = "cbAccType";
            this.cbAccType.Size = new System.Drawing.Size(127, 24);
            this.cbAccType.TabIndex = 103;
            // 
            // lblAccType
            // 
            this.lblAccType.AutoSize = true;
            this.lblAccType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccType.Location = new System.Drawing.Point(466, 22);
            this.lblAccType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(127, 18);
            this.lblAccType.TabIndex = 102;
            this.lblAccType.Text = "Tipo de Cuenta:";
            // 
            // picUsers
            // 
            this.picUsers.Image = global::CCMM.Properties.Resources.UsersAdd;
            this.picUsers.Location = new System.Drawing.Point(28, 22);
            this.picUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picUsers.Name = "picUsers";
            this.picUsers.Size = new System.Drawing.Size(51, 50);
            this.picUsers.TabIndex = 101;
            this.picUsers.TabStop = false;
            // 
            // picAccNumber
            // 
            this.picAccNumber.Location = new System.Drawing.Point(205, 41);
            this.picAccNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picAccNumber.Name = "picAccNumber";
            this.picAccNumber.Size = new System.Drawing.Size(31, 25);
            this.picAccNumber.TabIndex = 100;
            this.picAccNumber.TabStop = false;
            // 
            // txtbDiscount
            // 
            this.txtbDiscount.Enabled = false;
            this.txtbDiscount.Location = new System.Drawing.Point(499, 111);
            this.txtbDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbDiscount.Name = "txtbDiscount";
            this.txtbDiscount.Size = new System.Drawing.Size(113, 22);
            this.txtbDiscount.TabIndex = 92;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(496, 89);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(99, 18);
            this.lblDiscount.TabIndex = 98;
            this.lblDiscount.Text = "Descuento: ";
            // 
            // chkSpecialAcc
            // 
            this.chkSpecialAcc.AutoSize = true;
            this.chkSpecialAcc.Location = new System.Drawing.Point(469, 91);
            this.chkSpecialAcc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSpecialAcc.Name = "chkSpecialAcc";
            this.chkSpecialAcc.Size = new System.Drawing.Size(18, 17);
            this.chkSpecialAcc.TabIndex = 91;
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
            "17",
            "Solo MI"});
            this.cbGrade.Location = new System.Drawing.Point(271, 179);
            this.cbGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(91, 24);
            this.cbGrade.TabIndex = 90;
            this.cbGrade.SelectedIndexChanged += new System.EventHandler(this.cbGrade_SelectedIndexChanged);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(258, 150);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(65, 18);
            this.lblGrade.TabIndex = 97;
            this.lblGrade.Text = "Grado: ";
            // 
            // txtbLastName2
            // 
            this.txtbLastName2.Location = new System.Drawing.Point(271, 110);
            this.txtbLastName2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbLastName2.Name = "txtbLastName2";
            this.txtbLastName2.Size = new System.Drawing.Size(180, 22);
            this.txtbLastName2.TabIndex = 89;
            // 
            // lblLastName2
            // 
            this.lblLastName2.AutoSize = true;
            this.lblLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName2.Location = new System.Drawing.Point(253, 89);
            this.lblLastName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName2.Name = "lblLastName2";
            this.lblLastName2.Size = new System.Drawing.Size(144, 18);
            this.lblLastName2.TabIndex = 96;
            this.lblLastName2.Text = "Apellido Materno: ";
            // 
            // txtbLastName
            // 
            this.txtbLastName.Location = new System.Drawing.Point(40, 111);
            this.txtbLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(167, 22);
            this.txtbLastName.TabIndex = 88;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(27, 89);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(141, 18);
            this.lblLastName.TabIndex = 95;
            this.lblLastName.Text = "Apellido Paterno: ";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(271, 44);
            this.txtbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(180, 22);
            this.txtbName.TabIndex = 87;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(253, 22);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 18);
            this.lblName.TabIndex = 94;
            this.lblName.Text = "Nombre: ";
            // 
            // txtbAccNum
            // 
            this.txtbAccNum.Location = new System.Drawing.Point(103, 44);
            this.txtbAccNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbAccNum.Name = "txtbAccNum";
            this.txtbAccNum.Size = new System.Drawing.Size(95, 22);
            this.txtbAccNum.TabIndex = 86;
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNum.Location = new System.Drawing.Point(87, 22);
            this.lblAccNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(66, 18);
            this.lblAccNum.TabIndex = 93;
            this.lblAccNum.Text = "Cuenta:";
            // 
            // btnSaveNewStudent
            // 
            this.btnSaveNewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewStudent.Image = global::CCMM.Properties.Resources.CheckMark;
            this.btnSaveNewStudent.Location = new System.Drawing.Point(469, 150);
            this.btnSaveNewStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveNewStudent.Name = "btnSaveNewStudent";
            this.btnSaveNewStudent.Size = new System.Drawing.Size(147, 58);
            this.btnSaveNewStudent.TabIndex = 105;
            this.btnSaveNewStudent.Text = "Guardar";
            this.btnSaveNewStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSaveNewStudent.UseVisualStyleBackColor = true;
            this.btnSaveNewStudent.Click += new System.EventHandler(this.btnSaveNewStudent_Click);
            // 
            // cbSchoolLevel
            // 
            this.cbSchoolLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSchoolLevel.FormattingEnabled = true;
            this.cbSchoolLevel.Items.AddRange(new object[] {
            "Primaria",
            "Secundaria",
            "Preparatoria",
            "Universidad",
            "Medio Internado"});
            this.cbSchoolLevel.Location = new System.Drawing.Point(40, 179);
            this.cbSchoolLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cbSchoolLevel.Name = "cbSchoolLevel";
            this.cbSchoolLevel.Size = new System.Drawing.Size(167, 24);
            this.cbSchoolLevel.TabIndex = 106;
            this.cbSchoolLevel.SelectedIndexChanged += new System.EventHandler(this.cbSchoolLevel_SelectedIndexChanged);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(25, 150);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(113, 18);
            this.lblLevel.TabIndex = 107;
            this.lblLevel.Text = "Nivel Escolar:";
            // 
            // frmNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 222);
            this.Controls.Add(this.cbSchoolLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btnSaveNewStudent);
            this.Controls.Add(this.cbAccType);
            this.Controls.Add(this.lblAccType);
            this.Controls.Add(this.picUsers);
            this.Controls.Add(this.picAccNumber);
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
            this.Controls.Add(this.lblWarning);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNewStudent";
            this.ShowIcon = false;
            this.Text = "Registro de Estudiante";
            this.Load += new System.EventHandler(this.frmNewStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.ComboBox cbAccType;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.PictureBox picUsers;
        private System.Windows.Forms.PictureBox picAccNumber;
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
        private System.Windows.Forms.Button btnSaveNewStudent;
        private System.Windows.Forms.ComboBox cbSchoolLevel;
        private System.Windows.Forms.Label lblLevel;
    }
}