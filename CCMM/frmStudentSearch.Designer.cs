﻿namespace CCMM
{
    partial class frmStudentSearch
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
            this.groupBParameters = new System.Windows.Forms.GroupBox();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtbLastName2 = new System.Windows.Forms.TextBox();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblLastName2 = new System.Windows.Forms.Label();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbParameteresActive = new System.Windows.Forms.CheckBox();
            this.lblSearchTips = new System.Windows.Forms.Label();
            this.dGridStudentResults = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtbAccNum = new System.Windows.Forms.TextBox();
            this.lblAccNum = new System.Windows.Forms.Label();
            this.groupBParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridStudentResults)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBParameters
            // 
            this.groupBParameters.Controls.Add(this.cbGrade);
            this.groupBParameters.Controls.Add(this.lblGrade);
            this.groupBParameters.Controls.Add(this.txtbLastName2);
            this.groupBParameters.Controls.Add(this.cbLevel);
            this.groupBParameters.Controls.Add(this.lblLevel);
            this.groupBParameters.Controls.Add(this.lblLastName2);
            this.groupBParameters.Controls.Add(this.txtbLastName);
            this.groupBParameters.Controls.Add(this.lblLastName);
            this.groupBParameters.Controls.Add(this.txtbName);
            this.groupBParameters.Controls.Add(this.lblName);
            this.groupBParameters.Enabled = false;
            this.groupBParameters.Location = new System.Drawing.Point(13, 85);
            this.groupBParameters.Margin = new System.Windows.Forms.Padding(4);
            this.groupBParameters.Name = "groupBParameters";
            this.groupBParameters.Padding = new System.Windows.Forms.Padding(4);
            this.groupBParameters.Size = new System.Drawing.Size(780, 153);
            this.groupBParameters.TabIndex = 27;
            this.groupBParameters.TabStop = false;
            this.groupBParameters.Text = "Parametros de Búsqueda";
            // 
            // cbGrade
            // 
            this.cbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrade.Enabled = false;
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Location = new System.Drawing.Point(315, 111);
            this.cbGrade.Margin = new System.Windows.Forms.Padding(4);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(180, 24);
            this.cbGrade.TabIndex = 25;
            this.cbGrade.SelectedIndexChanged += new System.EventHandler(this.cbGrade_SelectedIndexChanged);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(303, 90);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(65, 18);
            this.lblGrade.TabIndex = 24;
            this.lblGrade.Text = "Grado: ";
            // 
            // txtbLastName2
            // 
            this.txtbLastName2.Location = new System.Drawing.Point(525, 53);
            this.txtbLastName2.Margin = new System.Windows.Forms.Padding(4);
            this.txtbLastName2.Name = "txtbLastName2";
            this.txtbLastName2.Size = new System.Drawing.Size(180, 22);
            this.txtbLastName2.TabIndex = 23;
            // 
            // cbLevel
            // 
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Todos",
            "Primaria",
            "Secundaria",
            "Preparatoria",
            "Universidad",
            "Medio Internado"});
            this.cbLevel.Location = new System.Drawing.Point(105, 111);
            this.cbLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(180, 24);
            this.cbLevel.TabIndex = 22;
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(93, 90);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(55, 18);
            this.lblLevel.TabIndex = 21;
            this.lblLevel.Text = "Nivel: ";
            // 
            // lblLastName2
            // 
            this.lblLastName2.AutoSize = true;
            this.lblLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName2.Location = new System.Drawing.Point(519, 32);
            this.lblLastName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName2.Name = "lblLastName2";
            this.lblLastName2.Size = new System.Drawing.Size(144, 18);
            this.lblLastName2.TabIndex = 20;
            this.lblLastName2.Text = "Apellido Materno: ";
            // 
            // txtbLastName
            // 
            this.txtbLastName.Location = new System.Drawing.Point(315, 53);
            this.txtbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(180, 22);
            this.txtbLastName.TabIndex = 19;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(303, 32);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(141, 18);
            this.lblLastName.TabIndex = 18;
            this.lblLastName.Text = "Apellido Paterno: ";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(105, 53);
            this.txtbName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(180, 22);
            this.txtbName.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(93, 32);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 18);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Nombre: ";
            // 
            // cbParameteresActive
            // 
            this.cbParameteresActive.AutoSize = true;
            this.cbParameteresActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParameteresActive.Location = new System.Drawing.Point(217, 39);
            this.cbParameteresActive.Margin = new System.Windows.Forms.Padding(4);
            this.cbParameteresActive.Name = "cbParameteresActive";
            this.cbParameteresActive.Size = new System.Drawing.Size(207, 22);
            this.cbParameteresActive.TabIndex = 26;
            this.cbParameteresActive.Text = "Buscar por información";
            this.cbParameteresActive.UseVisualStyleBackColor = true;
            this.cbParameteresActive.CheckedChanged += new System.EventHandler(this.cbParameteresActive_CheckedChanged);
            // 
            // lblSearchTips
            // 
            this.lblSearchTips.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearchTips.AutoSize = true;
            this.lblSearchTips.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTips.Location = new System.Drawing.Point(12, 249);
            this.lblSearchTips.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchTips.Name = "lblSearchTips";
            this.lblSearchTips.Size = new System.Drawing.Size(298, 17);
            this.lblSearchTips.TabIndex = 25;
            this.lblSearchTips.Text = "Doble click al alumno que hace el pago:";
            // 
            // dGridStudentResults
            // 
            this.dGridStudentResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGridStudentResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dGridStudentResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGridStudentResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridStudentResults.Location = new System.Drawing.Point(13, 279);
            this.dGridStudentResults.Margin = new System.Windows.Forms.Padding(4);
            this.dGridStudentResults.Name = "dGridStudentResults";
            this.dGridStudentResults.ReadOnly = true;
            this.dGridStudentResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridStudentResults.Size = new System.Drawing.Size(780, 226);
            this.dGridStudentResults.TabIndex = 24;
            this.dGridStudentResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridStudentResults_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::CCMM.Properties.Resources.Search;
            this.btnSearch.Location = new System.Drawing.Point(637, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 53);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtbAccNum
            // 
            this.txtbAccNum.Location = new System.Drawing.Point(13, 39);
            this.txtbAccNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtbAccNum.Name = "txtbAccNum";
            this.txtbAccNum.Size = new System.Drawing.Size(180, 22);
            this.txtbAccNum.TabIndex = 22;
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNum.Location = new System.Drawing.Point(11, 18);
            this.lblAccNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(66, 18);
            this.lblAccNum.TabIndex = 21;
            this.lblAccNum.Text = "Cuenta:";
            // 
            // frmStudentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 519);
            this.Controls.Add(this.groupBParameters);
            this.Controls.Add(this.cbParameteresActive);
            this.Controls.Add(this.lblSearchTips);
            this.Controls.Add(this.dGridStudentResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtbAccNum);
            this.Controls.Add(this.lblAccNum);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(825, 566);
            this.Name = "frmStudentSearch";
            this.ShowIcon = false;
            this.Text = "Búsqueda de Alumnos";
            this.Load += new System.EventHandler(this.frmStudentSearch_Load);
            this.groupBParameters.ResumeLayout(false);
            this.groupBParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridStudentResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBParameters;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtbLastName2;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblLastName2;
        private System.Windows.Forms.TextBox txtbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox cbParameteresActive;
        private System.Windows.Forms.Label lblSearchTips;
        private System.Windows.Forms.DataGridView dGridStudentResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtbAccNum;
        private System.Windows.Forms.Label lblAccNum;

    }
}