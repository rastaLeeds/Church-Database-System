namespace CMS_DEMO
{
    partial class BudgetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetForm));
            this.label16 = new System.Windows.Forms.Label();
            this.btnDisplayBudgetRecords = new System.Windows.Forms.Button();
            this.dataGridViewBudget = new System.Windows.Forms.DataGridView();
            this.gbDonations = new System.Windows.Forms.GroupBox();
            this.btnAddHlono = new System.Windows.Forms.Button();
            this.dateTimePickerPeriodTo = new System.Windows.Forms.DateTimePicker();
            this.txtDonationSource = new System.Windows.Forms.TextBox();
            this.dateTimePickerDonationPeriodFrm = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDonationAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbKamohelo = new System.Windows.Forms.GroupBox();
            this.txtExpdecript = new System.Windows.Forms.TextBox();
            this.btnExp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerExpPeriodTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerExpPeriodFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExpAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbConverts = new System.Windows.Forms.GroupBox();
            this.cmbSourceOfIncome = new System.Windows.Forms.ComboBox();
            this.dateTimePickerIncomeTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIncomeFrom = new System.Windows.Forms.DateTimePicker();
            this.txtIncomeAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmitIncome = new System.Windows.Forms.Button();
            this.btnReporting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBudget)).BeginInit();
            this.gbDonations.SuspendLayout();
            this.gbKamohelo.SuspendLayout();
            this.gbConverts.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Gold;
            this.label16.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkGreen;
            this.label16.Location = new System.Drawing.Point(335, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(345, 25);
            this.label16.TabIndex = 12;
            this.label16.Text = "Church Budget Management";
            // 
            // btnDisplayBudgetRecords
            // 
            this.btnDisplayBudgetRecords.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDisplayBudgetRecords.ForeColor = System.Drawing.Color.Yellow;
            this.btnDisplayBudgetRecords.Location = new System.Drawing.Point(428, 473);
            this.btnDisplayBudgetRecords.Name = "btnDisplayBudgetRecords";
            this.btnDisplayBudgetRecords.Size = new System.Drawing.Size(117, 30);
            this.btnDisplayBudgetRecords.TabIndex = 6;
            this.btnDisplayBudgetRecords.Text = "Refresh";
            this.btnDisplayBudgetRecords.UseVisualStyleBackColor = false;
            this.btnDisplayBudgetRecords.Click += new System.EventHandler(this.btnDisplayBudgetRecords_Click);
            // 
            // dataGridViewBudget
            // 
            this.dataGridViewBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBudget.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewBudget.Location = new System.Drawing.Point(0, 509);
            this.dataGridViewBudget.Name = "dataGridViewBudget";
            this.dataGridViewBudget.Size = new System.Drawing.Size(975, 145);
            this.dataGridViewBudget.TabIndex = 9;
            // 
            // gbDonations
            // 
            this.gbDonations.Controls.Add(this.btnAddHlono);
            this.gbDonations.Controls.Add(this.dateTimePickerPeriodTo);
            this.gbDonations.Controls.Add(this.txtDonationSource);
            this.gbDonations.Controls.Add(this.dateTimePickerDonationPeriodFrm);
            this.gbDonations.Controls.Add(this.label8);
            this.gbDonations.Controls.Add(this.txtDonationAmount);
            this.gbDonations.Controls.Add(this.label11);
            this.gbDonations.Controls.Add(this.label9);
            this.gbDonations.Controls.Add(this.label10);
            this.gbDonations.ForeColor = System.Drawing.Color.DarkGreen;
            this.gbDonations.Location = new System.Drawing.Point(501, 74);
            this.gbDonations.Name = "gbDonations";
            this.gbDonations.Size = new System.Drawing.Size(427, 229);
            this.gbDonations.TabIndex = 8;
            this.gbDonations.TabStop = false;
            this.gbDonations.Text = "DONATION REGISTER";
            // 
            // btnAddHlono
            // 
            this.btnAddHlono.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddHlono.ForeColor = System.Drawing.Color.Gold;
            this.btnAddHlono.Location = new System.Drawing.Point(291, 187);
            this.btnAddHlono.Name = "btnAddHlono";
            this.btnAddHlono.Size = new System.Drawing.Size(117, 30);
            this.btnAddHlono.TabIndex = 0;
            this.btnAddHlono.Text = "Add Donation";
            this.btnAddHlono.UseVisualStyleBackColor = false;
            this.btnAddHlono.Click += new System.EventHandler(this.btnAddHlono_Click);
            // 
            // dateTimePickerPeriodTo
            // 
            this.dateTimePickerPeriodTo.Location = new System.Drawing.Point(160, 127);
            this.dateTimePickerPeriodTo.Name = "dateTimePickerPeriodTo";
            this.dateTimePickerPeriodTo.Size = new System.Drawing.Size(205, 20);
            this.dateTimePickerPeriodTo.TabIndex = 2;
            // 
            // txtDonationSource
            // 
            this.txtDonationSource.Location = new System.Drawing.Point(160, 29);
            this.txtDonationSource.Name = "txtDonationSource";
            this.txtDonationSource.Size = new System.Drawing.Size(205, 20);
            this.txtDonationSource.TabIndex = 0;
            // 
            // dateTimePickerDonationPeriodFrm
            // 
            this.dateTimePickerDonationPeriodFrm.Location = new System.Drawing.Point(160, 90);
            this.dateTimePickerDonationPeriodFrm.Name = "dateTimePickerDonationPeriodFrm";
            this.dateTimePickerDonationPeriodFrm.Size = new System.Drawing.Size(205, 20);
            this.dateTimePickerDonationPeriodFrm.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Donation Source:";
            // 
            // txtDonationAmount
            // 
            this.txtDonationAmount.Location = new System.Drawing.Point(160, 55);
            this.txtDonationAmount.Name = "txtDonationAmount";
            this.txtDonationAmount.Size = new System.Drawing.Size(205, 20);
            this.txtDonationAmount.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Donation Period To:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Donation Amount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Donation Period From:";
            // 
            // gbKamohelo
            // 
            this.gbKamohelo.Controls.Add(this.txtExpdecript);
            this.gbKamohelo.Controls.Add(this.btnExp);
            this.gbKamohelo.Controls.Add(this.label5);
            this.gbKamohelo.Controls.Add(this.dateTimePickerExpPeriodTo);
            this.gbKamohelo.Controls.Add(this.label4);
            this.gbKamohelo.Controls.Add(this.dateTimePickerExpPeriodFrom);
            this.gbKamohelo.Controls.Add(this.label6);
            this.gbKamohelo.Controls.Add(this.txtExpAmount);
            this.gbKamohelo.Controls.Add(this.label7);
            this.gbKamohelo.ForeColor = System.Drawing.Color.DarkGreen;
            this.gbKamohelo.Location = new System.Drawing.Point(47, 309);
            this.gbKamohelo.Name = "gbKamohelo";
            this.gbKamohelo.Size = new System.Drawing.Size(881, 152);
            this.gbKamohelo.TabIndex = 7;
            this.gbKamohelo.TabStop = false;
            this.gbKamohelo.Text = "EXPENDITURE REGISTER";
            // 
            // txtExpdecript
            // 
            this.txtExpdecript.Location = new System.Drawing.Point(188, 42);
            this.txtExpdecript.Multiline = true;
            this.txtExpdecript.Name = "txtExpdecript";
            this.txtExpdecript.Size = new System.Drawing.Size(205, 41);
            this.txtExpdecript.TabIndex = 3;
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExp.ForeColor = System.Drawing.Color.Gold;
            this.btnExp.Location = new System.Drawing.Point(745, 105);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(117, 30);
            this.btnExp.TabIndex = 0;
            this.btnExp.Text = "Add Expenditure";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Expendidure Amount:";
            // 
            // dateTimePickerExpPeriodTo
            // 
            this.dateTimePickerExpPeriodTo.Location = new System.Drawing.Point(577, 73);
            this.dateTimePickerExpPeriodTo.Name = "dateTimePickerExpPeriodTo";
            this.dateTimePickerExpPeriodTo.Size = new System.Drawing.Size(205, 20);
            this.dateTimePickerExpPeriodTo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Expenditure Description:";
            // 
            // dateTimePickerExpPeriodFrom
            // 
            this.dateTimePickerExpPeriodFrom.Location = new System.Drawing.Point(577, 36);
            this.dateTimePickerExpPeriodFrom.Name = "dateTimePickerExpPeriodFrom";
            this.dateTimePickerExpPeriodFrom.Size = new System.Drawing.Size(205, 20);
            this.dateTimePickerExpPeriodFrom.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Income Period From:";
            // 
            // txtExpAmount
            // 
            this.txtExpAmount.Location = new System.Drawing.Point(188, 89);
            this.txtExpAmount.Name = "txtExpAmount";
            this.txtExpAmount.Size = new System.Drawing.Size(205, 20);
            this.txtExpAmount.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Income Period To:";
            // 
            // gbConverts
            // 
            this.gbConverts.Controls.Add(this.cmbSourceOfIncome);
            this.gbConverts.Controls.Add(this.dateTimePickerIncomeTo);
            this.gbConverts.Controls.Add(this.dateTimePickerIncomeFrom);
            this.gbConverts.Controls.Add(this.txtIncomeAmount);
            this.gbConverts.Controls.Add(this.label17);
            this.gbConverts.Controls.Add(this.label3);
            this.gbConverts.Controls.Add(this.label2);
            this.gbConverts.Controls.Add(this.label1);
            this.gbConverts.Controls.Add(this.btnDelete);
            this.gbConverts.Controls.Add(this.btnSubmitIncome);
            this.gbConverts.ForeColor = System.Drawing.Color.DarkGreen;
            this.gbConverts.Location = new System.Drawing.Point(47, 74);
            this.gbConverts.Name = "gbConverts";
            this.gbConverts.Size = new System.Drawing.Size(431, 229);
            this.gbConverts.TabIndex = 10;
            this.gbConverts.TabStop = false;
            this.gbConverts.Text = "INCOME REGISTER";
            // 
            // cmbSourceOfIncome
            // 
            this.cmbSourceOfIncome.FormattingEnabled = true;
            this.cmbSourceOfIncome.Items.AddRange(new object[] {
            "Perish",
            "Mohau"});
            this.cmbSourceOfIncome.Location = new System.Drawing.Point(127, 30);
            this.cmbSourceOfIncome.Name = "cmbSourceOfIncome";
            this.cmbSourceOfIncome.Size = new System.Drawing.Size(207, 21);
            this.cmbSourceOfIncome.TabIndex = 3;
            // 
            // dateTimePickerIncomeTo
            // 
            this.dateTimePickerIncomeTo.Location = new System.Drawing.Point(129, 138);
            this.dateTimePickerIncomeTo.Name = "dateTimePickerIncomeTo";
            this.dateTimePickerIncomeTo.Size = new System.Drawing.Size(205, 20);
            this.dateTimePickerIncomeTo.TabIndex = 2;
            // 
            // dateTimePickerIncomeFrom
            // 
            this.dateTimePickerIncomeFrom.Location = new System.Drawing.Point(129, 101);
            this.dateTimePickerIncomeFrom.Name = "dateTimePickerIncomeFrom";
            this.dateTimePickerIncomeFrom.Size = new System.Drawing.Size(205, 20);
            this.dateTimePickerIncomeFrom.TabIndex = 2;
            // 
            // txtIncomeAmount
            // 
            this.txtIncomeAmount.Location = new System.Drawing.Point(129, 66);
            this.txtIncomeAmount.Name = "txtIncomeAmount";
            this.txtIncomeAmount.Size = new System.Drawing.Size(205, 20);
            this.txtIncomeAmount.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 142);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Income Period To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Income Period From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Income Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Of Income:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDelete.ForeColor = System.Drawing.Color.Yellow;
            this.btnDelete.Location = new System.Drawing.Point(64, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 30);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete from Database";
            this.btnDelete.UseMnemonic = false;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSubmitIncome
            // 
            this.btnSubmitIncome.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSubmitIncome.ForeColor = System.Drawing.Color.Yellow;
            this.btnSubmitIncome.Location = new System.Drawing.Point(229, 188);
            this.btnSubmitIncome.Name = "btnSubmitIncome";
            this.btnSubmitIncome.Size = new System.Drawing.Size(111, 30);
            this.btnSubmitIncome.TabIndex = 0;
            this.btnSubmitIncome.Text = "Add To Database";
            this.btnSubmitIncome.UseVisualStyleBackColor = false;
            this.btnSubmitIncome.Click += new System.EventHandler(this.btnSubmitIncome_Click);
            // 
            // btnReporting
            // 
            this.btnReporting.BackColor = System.Drawing.Color.DarkGreen;
            this.btnReporting.ForeColor = System.Drawing.Color.Yellow;
            this.btnReporting.Location = new System.Drawing.Point(551, 473);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Size = new System.Drawing.Size(117, 30);
            this.btnReporting.TabIndex = 6;
            this.btnReporting.Text = "Export to Excile";
            this.btnReporting.UseVisualStyleBackColor = false;
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            // 
            // BudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(975, 654);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnReporting);
            this.Controls.Add(this.btnDisplayBudgetRecords);
            this.Controls.Add(this.dataGridViewBudget);
            this.Controls.Add(this.gbDonations);
            this.Controls.Add(this.gbKamohelo);
            this.Controls.Add(this.gbConverts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BudgetForm";
            this.Text = "BudgetForm";
            this.Load += new System.EventHandler(this.BudgetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBudget)).EndInit();
            this.gbDonations.ResumeLayout(false);
            this.gbDonations.PerformLayout();
            this.gbKamohelo.ResumeLayout(false);
            this.gbKamohelo.PerformLayout();
            this.gbConverts.ResumeLayout(false);
            this.gbConverts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnDisplayBudgetRecords;
        private System.Windows.Forms.DataGridView dataGridViewBudget;
        private System.Windows.Forms.GroupBox gbDonations;
        private System.Windows.Forms.Button btnAddHlono;
        private System.Windows.Forms.TextBox txtDonationSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbKamohelo;
        private System.Windows.Forms.GroupBox gbConverts;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncomeFrom;
        private System.Windows.Forms.TextBox txtIncomeAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitIncome;
        private System.Windows.Forms.ComboBox cmbSourceOfIncome;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncomeTo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimePickerPeriodTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDonationPeriodFrm;
        private System.Windows.Forms.TextBox txtDonationAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpPeriodTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpPeriodFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExpAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReporting;
        private System.Windows.Forms.TextBox txtExpdecript;
        private System.Windows.Forms.Button btnDelete;
    }
}