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
            this.cbAfterSchool = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(7, 224);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(10, 13);
            this.lblWarning.TabIndex = 71;
            this.lblWarning.Text = "-";
            this.lblWarning.Visible = false;
            // 
            // cbAfterSchool
            // 
            this.cbAfterSchool.AutoSize = true;
            this.cbAfterSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAfterSchool.Location = new System.Drawing.Point(24, 132);
            this.cbAfterSchool.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAfterSchool.Name = "cbAfterSchool";
            this.cbAfterSchool.Size = new System.Drawing.Size(139, 19);
            this.cbAfterSchool.TabIndex = 104;
            this.cbAfterSchool.Text = "Medio Internado?";
            this.cbAfterSchool.UseVisualStyleBackColor = true;
            this.cbAfterSchool.CheckedChanged += new System.EventHandler(this.cbAfterSchool_CheckedChanged);
            // 
            // cbAccType
            // 
            this.cbAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccType.FormattingEnabled = true;
            this.cbAccType.Items.AddRange(new object[] {
            "Normal",
            "Diferido"});
            this.cbAccType.Location = new System.Drawing.Point(203, 139);
            this.cbAccType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAccType.Name = "cbAccType";
            this.cbAccType.Size = new System.Drawing.Size(96, 21);
            this.cbAccType.TabIndex = 103;
            // 
            // lblAccType
            // 
            this.lblAccType.AutoSize = true;
            this.lblAccType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccType.Location = new System.Drawing.Point(190, 122);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(108, 15);
            this.lblAccType.TabIndex = 102;
            this.lblAccType.Text = "Tipo de Cuenta:";
            // 
            // picUsers
            // 
            this.picUsers.Image = global::CCMM.Properties.Resources.UsersAdd;
            this.picUsers.Location = new System.Drawing.Point(21, 18);
            this.picUsers.Name = "picUsers";
            this.picUsers.Size = new System.Drawing.Size(38, 41);
            this.picUsers.TabIndex = 101;
            this.picUsers.TabStop = false;
            // 
            // picAccNumber
            // 
            this.picAccNumber.Location = new System.Drawing.Point(154, 33);
            this.picAccNumber.Name = "picAccNumber";
            this.picAccNumber.Size = new System.Drawing.Size(23, 20);
            this.picAccNumber.TabIndex = 100;
            this.picAccNumber.TabStop = false;
            // 
            // txtbDiscount
            // 
            this.txtbDiscount.Enabled = false;
            this.txtbDiscount.Location = new System.Drawing.Point(374, 90);
            this.txtbDiscount.Name = "txtbDiscount";
            this.txtbDiscount.Size = new System.Drawing.Size(86, 20);
            this.txtbDiscount.TabIndex = 92;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(372, 72);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(83, 15);
            this.lblDiscount.TabIndex = 98;
            this.lblDiscount.Text = "Descuento: ";
            // 
            // chkSpecialAcc
            // 
            this.chkSpecialAcc.AutoSize = true;
            this.chkSpecialAcc.Location = new System.Drawing.Point(352, 74);
            this.chkSpecialAcc.Name = "chkSpecialAcc";
            this.chkSpecialAcc.Size = new System.Drawing.Size(15, 14);
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
            this.cbGrade.Location = new System.Drawing.Point(371, 36);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(69, 21);
            this.cbGrade.TabIndex = 90;
            this.cbGrade.SelectedIndexChanged += new System.EventHandler(this.cbGrade_SelectedIndexChanged);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(365, 18);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(54, 15);
            this.lblGrade.TabIndex = 97;
            this.lblGrade.Text = "Grado: ";
            // 
            // txtbLastName2
            // 
            this.txtbLastName2.Location = new System.Drawing.Point(203, 89);
            this.txtbLastName2.Name = "txtbLastName2";
            this.txtbLastName2.Size = new System.Drawing.Size(136, 20);
            this.txtbLastName2.TabIndex = 89;
            // 
            // lblLastName2
            // 
            this.lblLastName2.AutoSize = true;
            this.lblLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName2.Location = new System.Drawing.Point(190, 72);
            this.lblLastName2.Name = "lblLastName2";
            this.lblLastName2.Size = new System.Drawing.Size(124, 15);
            this.lblLastName2.TabIndex = 96;
            this.lblLastName2.Text = "Apellido Materno: ";
            // 
            // txtbLastName
            // 
            this.txtbLastName.Location = new System.Drawing.Point(30, 90);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(126, 20);
            this.txtbLastName.TabIndex = 88;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(20, 72);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(121, 15);
            this.lblLastName.TabIndex = 95;
            this.lblLastName.Text = "Apellido Paterno: ";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(203, 36);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(136, 20);
            this.txtbName.TabIndex = 87;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(190, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 15);
            this.lblName.TabIndex = 94;
            this.lblName.Text = "Nombre: ";
            // 
            // txtbAccNum
            // 
            this.txtbAccNum.Location = new System.Drawing.Point(77, 36);
            this.txtbAccNum.Name = "txtbAccNum";
            this.txtbAccNum.Size = new System.Drawing.Size(72, 20);
            this.txtbAccNum.TabIndex = 86;
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNum.Location = new System.Drawing.Point(65, 18);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(56, 15);
            this.lblAccNum.TabIndex = 93;
            this.lblAccNum.Text = "Cuenta:";
            // 
            // btnSaveNewStudent
            // 
            this.btnSaveNewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewStudent.Image = global::CCMM.Properties.Resources.CheckMark;
            this.btnSaveNewStudent.Location = new System.Drawing.Point(352, 122);
            this.btnSaveNewStudent.Name = "btnSaveNewStudent";
            this.btnSaveNewStudent.Size = new System.Drawing.Size(110, 47);
            this.btnSaveNewStudent.TabIndex = 105;
            this.btnSaveNewStudent.Text = "Guardar";
            this.btnSaveNewStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSaveNewStudent.UseVisualStyleBackColor = true;
            this.btnSaveNewStudent.Click += new System.EventHandler(this.btnSaveNewStudent_Click);
            // 
            // frmNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 180);
            this.Controls.Add(this.btnSaveNewStudent);
            this.Controls.Add(this.cbAfterSchool);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.CheckBox cbAfterSchool;
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
    }
}