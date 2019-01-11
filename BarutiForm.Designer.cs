namespace CMS_DEMO
{
    partial class BarutiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarutiForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDOBap = new System.Windows.Forms.DateTimePicker();
            this.cmbMorutiPosition = new System.Windows.Forms.ComboBox();
            this.cmbMorutiOccup = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAddMoruti = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMorutiContactNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMorutiResAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKganyaBookNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMorutiSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchMoruti = new System.Windows.Forms.TextBox();
            this.lblMruti = new System.Windows.Forms.Label();
            this.dataGridViewBaruti = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblTotalNumOfBaruti = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearchMoruti = new System.Windows.Forms.Button();
            this.txtMorutiName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaruti)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Controls.Add(this.dateTimePickerDOBap);
            this.groupBox1.Controls.Add(this.cmbMorutiPosition);
            this.groupBox1.Controls.Add(this.cmbMorutiOccup);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.btnAddMoruti);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMorutiName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMorutiContactNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMorutiResAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKganyaBookNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMorutiSurname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMruti);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(26, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baruti Register";
            // 
            // dateTimePickerDOBap
            // 
            this.dateTimePickerDOBap.Location = new System.Drawing.Point(431, 60);
            this.dateTimePickerDOBap.Name = "dateTimePickerDOBap";
            this.dateTimePickerDOBap.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDOBap.TabIndex = 6;
            // 
            // cmbMorutiPosition
            // 
            this.cmbMorutiPosition.FormattingEnabled = true;
            this.cmbMorutiPosition.Items.AddRange(new object[] {
            "Hloho - Moruti",
            "Letsoho-Moruti",
            "Chaiman-Moruti",
            "Letshoho-Hase",
            "Secretary-Hase ",
            "Letsoho-Hase",
            "Treasure–Moruti",
            "Letsoho-Hase",
            "Key man-Hase",
            "Letsoho-Moruti",
            "2nd ten"});
            this.cmbMorutiPosition.Location = new System.Drawing.Point(431, 98);
            this.cmbMorutiPosition.Name = "cmbMorutiPosition";
            this.cmbMorutiPosition.Size = new System.Drawing.Size(197, 21);
            this.cmbMorutiPosition.TabIndex = 7;
            // 
            // cmbMorutiOccup
            // 
            this.cmbMorutiOccup.FormattingEnabled = true;
            this.cmbMorutiOccup.Items.AddRange(new object[] {
            "General Worker",
            "SANDF",
            "Supervisor",
            "Support Officer",
            "Unemployed",
            "Chief Nature Conservator",
            "Supervisor",
            "General Manager",
            "Police Officer – SAPS",
            "Pensioner",
            "Advocate",
            "Self employed",
            "Police Officer - SAPS"});
            this.cmbMorutiOccup.Location = new System.Drawing.Point(429, 30);
            this.cmbMorutiOccup.Name = "cmbMorutiOccup";
            this.cmbMorutiOccup.Size = new System.Drawing.Size(202, 21);
            this.cmbMorutiOccup.TabIndex = 5;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Yellow;
            this.btnExport.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExport.Location = new System.Drawing.Point(500, 169);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(92, 23);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export To Excile";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnAddMoruti
            // 
            this.btnAddMoruti.BackColor = System.Drawing.Color.Yellow;
            this.btnAddMoruti.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddMoruti.Location = new System.Drawing.Point(624, 169);
            this.btnAddMoruti.Name = "btnAddMoruti";
            this.btnAddMoruti.Size = new System.Drawing.Size(92, 23);
            this.btnAddMoruti.TabIndex = 8;
            this.btnAddMoruti.Text = "Add Moruti";
            this.btnAddMoruti.UseVisualStyleBackColor = false;
            this.btnAddMoruti.Click += new System.EventHandler(this.btnAddMoruti_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date Of Baptism:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Position:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Occupation:";
            // 
            // txtMorutiContactNo
            // 
            this.txtMorutiContactNo.Location = new System.Drawing.Point(151, 111);
            this.txtMorutiContactNo.Name = "txtMorutiContactNo";
            this.txtMorutiContactNo.Size = new System.Drawing.Size(159, 20);
            this.txtMorutiContactNo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ContactNo:";
            // 
            // txtMorutiResAddress
            // 
            this.txtMorutiResAddress.Location = new System.Drawing.Point(151, 137);
            this.txtMorutiResAddress.Multiline = true;
            this.txtMorutiResAddress.Name = "txtMorutiResAddress";
            this.txtMorutiResAddress.Size = new System.Drawing.Size(159, 45);
            this.txtMorutiResAddress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Residential Address:";
            // 
            // txtKganyaBookNo
            // 
            this.txtKganyaBookNo.Location = new System.Drawing.Point(151, 83);
            this.txtKganyaBookNo.Name = "txtKganyaBookNo";
            this.txtKganyaBookNo.Size = new System.Drawing.Size(159, 20);
            this.txtKganyaBookNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kganya Book Number:";
            // 
            // txtMorutiSurname
            // 
            this.txtMorutiSurname.Location = new System.Drawing.Point(151, 57);
            this.txtMorutiSurname.Name = "txtMorutiSurname";
            this.txtMorutiSurname.Size = new System.Drawing.Size(159, 20);
            this.txtMorutiSurname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Surname:";
            // 
            // txtSearchMoruti
            // 
            this.txtSearchMoruti.Location = new System.Drawing.Point(26, 271);
            this.txtSearchMoruti.Name = "txtSearchMoruti";
            this.txtSearchMoruti.Size = new System.Drawing.Size(159, 20);
            this.txtSearchMoruti.TabIndex = 0;
            // 
            // lblMruti
            // 
            this.lblMruti.AutoSize = true;
            this.lblMruti.Location = new System.Drawing.Point(31, 38);
            this.lblMruti.Name = "lblMruti";
            this.lblMruti.Size = new System.Drawing.Size(38, 13);
            this.lblMruti.TabIndex = 0;
            this.lblMruti.Text = "Name:";
            // 
            // dataGridViewBaruti
            // 
            this.dataGridViewBaruti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaruti.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewBaruti.Location = new System.Drawing.Point(0, 297);
            this.dataGridViewBaruti.Name = "dataGridViewBaruti";
            this.dataGridViewBaruti.Size = new System.Drawing.Size(826, 209);
            this.dataGridViewBaruti.TabIndex = 1;
            this.dataGridViewBaruti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBaruti_CellClick);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Stencil Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWelcome.Location = new System.Drawing.Point(279, 10);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(233, 25);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Lekgotla La Moruti";
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDisplay.ForeColor = System.Drawing.Color.Gold;
            this.btnDisplay.Location = new System.Drawing.Point(353, 262);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(92, 29);
            this.btnDisplay.TabIndex = 11;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblTotalNumOfBaruti
            // 
            this.lblTotalNumOfBaruti.AutoSize = true;
            this.lblTotalNumOfBaruti.Location = new System.Drawing.Point(743, 278);
            this.lblTotalNumOfBaruti.Name = "lblTotalNumOfBaruti";
            this.lblTotalNumOfBaruti.Size = new System.Drawing.Size(0, 13);
            this.lblTotalNumOfBaruti.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(627, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total Number Of Baruti:";
            // 
            // btnSearchMoruti
            // 
            this.btnSearchMoruti.BackColor = System.Drawing.Color.Yellow;
            this.btnSearchMoruti.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSearchMoruti.Location = new System.Drawing.Point(191, 269);
            this.btnSearchMoruti.Name = "btnSearchMoruti";
            this.btnSearchMoruti.Size = new System.Drawing.Size(122, 23);
            this.btnSearchMoruti.TabIndex = 9;
            this.btnSearchMoruti.Text = "Search By Surname";
            this.btnSearchMoruti.UseVisualStyleBackColor = false;
            this.btnSearchMoruti.Click += new System.EventHandler(this.btnSearchMoruti_Click);
            // 
            // txtMorutiName
            // 
            this.txtMorutiName.Location = new System.Drawing.Point(151, 30);
            this.txtMorutiName.Name = "txtMorutiName";
            this.txtMorutiName.Size = new System.Drawing.Size(159, 20);
            this.txtMorutiName.TabIndex = 0;
            // 
            // BarutiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(826, 506);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalNumOfBaruti);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.dataGridViewBaruti);
            this.Controls.Add(this.btnSearchMoruti);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtSearchMoruti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BarutiForm";
            this.Text = "Baruti ";
            this.Load += new System.EventHandler(this.BarutiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaruti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewBaruti;
        private System.Windows.Forms.Button btnAddMoruti;
        private System.Windows.Forms.TextBox txtSearchMoruti;
        private System.Windows.Forms.Label lblMruti;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOBap;
        private System.Windows.Forms.ComboBox cmbMorutiPosition;
        private System.Windows.Forms.ComboBox cmbMorutiOccup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMorutiContactNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMorutiResAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKganyaBookNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMorutiSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblTotalNumOfBaruti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMorutiName;
        private System.Windows.Forms.Button btnSearchMoruti;
    }
}