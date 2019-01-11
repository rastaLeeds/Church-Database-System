namespace CMS_DEMO
{
    partial class CasesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CasesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtCaseDescrip = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbReputationRick = new System.Windows.Forms.ComboBox();
            this.cmbCaseType = new System.Windows.Forms.ComboBox();
            this.cmbStatusOCase = new System.Windows.Forms.ComboBox();
            this.txtCaseDuration = new System.Windows.Forms.TextBox();
            this.txtCaseNo = new System.Windows.Forms.TextBox();
            this.dtpCaseDate = new System.Windows.Forms.DateTimePicker();
            this.btnRefreahCaseDB = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmitCase = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchCase = new System.Windows.Forms.TextBox();
            this.btnSearchCase = new System.Windows.Forms.Button();
            this.btnDeleteCase = new System.Windows.Forms.Button();
            this.btnEditCase = new System.Windows.Forms.Button();
            this.dataGridViewCases = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCases)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(183, 17);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Church Cases Register";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtCaseDescrip);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbReputationRick);
            this.groupBox1.Controls.Add(this.cmbCaseType);
            this.groupBox1.Controls.Add(this.cmbStatusOCase);
            this.groupBox1.Controls.Add(this.txtCaseDuration);
            this.groupBox1.Controls.Add(this.txtCaseNo);
            this.groupBox1.Controls.Add(this.dtpCaseDate);
            this.groupBox1.Controls.Add(this.btnRefreahCaseDB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSubmitCase);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(19, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register A Case";
            // 
            // rtxtCaseDescrip
            // 
            this.rtxtCaseDescrip.Location = new System.Drawing.Point(447, 37);
            this.rtxtCaseDescrip.Name = "rtxtCaseDescrip";
            this.rtxtCaseDescrip.Size = new System.Drawing.Size(225, 137);
            this.rtxtCaseDescrip.TabIndex = 6;
            this.rtxtCaseDescrip.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Description Of Case:";
            // 
            // cmbReputationRick
            // 
            this.cmbReputationRick.FormattingEnabled = true;
            this.cmbReputationRick.Items.AddRange(new object[] {
            "High",
            "Low",
            "None"});
            this.cmbReputationRick.Location = new System.Drawing.Point(124, 162);
            this.cmbReputationRick.Name = "cmbReputationRick";
            this.cmbReputationRick.Size = new System.Drawing.Size(121, 21);
            this.cmbReputationRick.TabIndex = 4;
            // 
            // cmbCaseType
            // 
            this.cmbCaseType.FormattingEnabled = true;
            this.cmbCaseType.Items.AddRange(new object[] {
            "Diagelo",
            "Fraud",
            "Misconduct"});
            this.cmbCaseType.Location = new System.Drawing.Point(121, 127);
            this.cmbCaseType.Name = "cmbCaseType";
            this.cmbCaseType.Size = new System.Drawing.Size(121, 21);
            this.cmbCaseType.TabIndex = 3;
            // 
            // cmbStatusOCase
            // 
            this.cmbStatusOCase.FormattingEnabled = true;
            this.cmbStatusOCase.Items.AddRange(new object[] {
            "Finalized ",
            "WIP",
            "Referred"});
            this.cmbStatusOCase.Location = new System.Drawing.Point(121, 99);
            this.cmbStatusOCase.Name = "cmbStatusOCase";
            this.cmbStatusOCase.Size = new System.Drawing.Size(121, 21);
            this.cmbStatusOCase.TabIndex = 2;
            // 
            // txtCaseDuration
            // 
            this.txtCaseDuration.Location = new System.Drawing.Point(123, 188);
            this.txtCaseDuration.Name = "txtCaseDuration";
            this.txtCaseDuration.Size = new System.Drawing.Size(100, 20);
            this.txtCaseDuration.TabIndex = 5;
            // 
            // txtCaseNo
            // 
            this.txtCaseNo.Location = new System.Drawing.Point(121, 39);
            this.txtCaseNo.Name = "txtCaseNo";
            this.txtCaseNo.Size = new System.Drawing.Size(100, 20);
            this.txtCaseNo.TabIndex = 0;
            // 
            // dtpCaseDate
            // 
            this.dtpCaseDate.Location = new System.Drawing.Point(121, 71);
            this.dtpCaseDate.Name = "dtpCaseDate";
            this.dtpCaseDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCaseDate.TabIndex = 1;
            // 
            // btnRefreahCaseDB
            // 
            this.btnRefreahCaseDB.BackColor = System.Drawing.Color.Gold;
            this.btnRefreahCaseDB.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRefreahCaseDB.Location = new System.Drawing.Point(272, 218);
            this.btnRefreahCaseDB.Name = "btnRefreahCaseDB";
            this.btnRefreahCaseDB.Size = new System.Drawing.Size(74, 23);
            this.btnRefreahCaseDB.TabIndex = 8;
            this.btnRefreahCaseDB.Text = "Refresh Database";
            this.btnRefreahCaseDB.UseVisualStyleBackColor = false;
            this.btnRefreahCaseDB.Click += new System.EventHandler(this.btnRefreahCaseDB_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Reputational Risk:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Type of Case:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Status Of A Case:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Case Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Duration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Case Number:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gold;
            this.btnClear.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnClear.Location = new System.Drawing.Point(447, 190);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmitCase
            // 
            this.btnSubmitCase.BackColor = System.Drawing.Color.Gold;
            this.btnSubmitCase.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSubmitCase.Location = new System.Drawing.Point(532, 190);
            this.btnSubmitCase.Name = "btnSubmitCase";
            this.btnSubmitCase.Size = new System.Drawing.Size(107, 23);
            this.btnSubmitCase.TabIndex = 7;
            this.btnSubmitCase.Text = "Submit A Case";
            this.btnSubmitCase.UseVisualStyleBackColor = false;
            this.btnSubmitCase.Click += new System.EventHandler(this.btnSubmitCase_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(16, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Search Case By Case Number:";
            // 
            // txtSearchCase
            // 
            this.txtSearchCase.Location = new System.Drawing.Point(175, 310);
            this.txtSearchCase.Name = "txtSearchCase";
            this.txtSearchCase.Size = new System.Drawing.Size(175, 20);
            this.txtSearchCase.TabIndex = 0;
            // 
            // btnSearchCase
            // 
            this.btnSearchCase.BackColor = System.Drawing.Color.Gold;
            this.btnSearchCase.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSearchCase.Location = new System.Drawing.Point(363, 309);
            this.btnSearchCase.Name = "btnSearchCase";
            this.btnSearchCase.Size = new System.Drawing.Size(107, 23);
            this.btnSearchCase.TabIndex = 0;
            this.btnSearchCase.Text = "Search";
            this.btnSearchCase.UseVisualStyleBackColor = false;
            this.btnSearchCase.Click += new System.EventHandler(this.btnSearchCase_Click);
            // 
            // btnDeleteCase
            // 
            this.btnDeleteCase.BackColor = System.Drawing.Color.Gold;
            this.btnDeleteCase.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDeleteCase.Location = new System.Drawing.Point(476, 308);
            this.btnDeleteCase.Name = "btnDeleteCase";
            this.btnDeleteCase.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteCase.TabIndex = 0;
            this.btnDeleteCase.Text = "Delete Case";
            this.btnDeleteCase.UseVisualStyleBackColor = false;
            this.btnDeleteCase.Click += new System.EventHandler(this.btnDeleteCase_Click);
            // 
            // btnEditCase
            // 
            this.btnEditCase.BackColor = System.Drawing.Color.Gold;
            this.btnEditCase.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEditCase.Location = new System.Drawing.Point(589, 307);
            this.btnEditCase.Name = "btnEditCase";
            this.btnEditCase.Size = new System.Drawing.Size(93, 23);
            this.btnEditCase.TabIndex = 0;
            this.btnEditCase.Text = "Edit Case";
            this.btnEditCase.UseVisualStyleBackColor = false;
            // 
            // dataGridViewCases
            // 
            this.dataGridViewCases.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridViewCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCases.Location = new System.Drawing.Point(1, 338);
            this.dataGridViewCases.Name = "dataGridViewCases";
            this.dataGridViewCases.Size = new System.Drawing.Size(718, 248);
            this.dataGridViewCases.TabIndex = 2;
            // 
            // CasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(720, 604);
            this.Controls.Add(this.dataGridViewCases);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchCase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEditCase);
            this.Controls.Add(this.btnDeleteCase);
            this.Controls.Add(this.btnSearchCase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CasesForm";
            this.Text = "CasesForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxtCaseDescrip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbReputationRick;
        private System.Windows.Forms.ComboBox cmbCaseType;
        private System.Windows.Forms.ComboBox cmbStatusOCase;
        private System.Windows.Forms.TextBox txtCaseNo;
        private System.Windows.Forms.DateTimePicker dtpCaseDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmitCase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchCase;
        private System.Windows.Forms.Button btnSearchCase;
        private System.Windows.Forms.Button btnDeleteCase;
        private System.Windows.Forms.Button btnEditCase;
        private System.Windows.Forms.DataGridView dataGridViewCases;
        private System.Windows.Forms.TextBox txtCaseDuration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRefreahCaseDB;
    }
}