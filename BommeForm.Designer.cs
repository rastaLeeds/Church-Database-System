namespace CMS_DEMO
{
    partial class BommeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BommeForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickeMmeDOBap = new System.Windows.Forms.DateTimePicker();
            this.cmbMmePosition = new System.Windows.Forms.ComboBox();
            this.cmbMmeOccup = new System.Windows.Forms.ComboBox();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMmeConactNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMmeResAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMmeKganyaBookNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMmeSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMmeName = new System.Windows.Forms.TextBox();
            this.lblMruti = new System.Windows.Forms.Label();
            this.dataGridViewBoMme = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTotalNumOfSubBomme = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSubBommeBranchName = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoMme)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.dateTimePickeMmeDOBap);
            this.groupBox1.Controls.Add(this.cmbSubBommeBranchName);
            this.groupBox1.Controls.Add(this.cmbMmePosition);
            this.groupBox1.Controls.Add(this.cmbMmeOccup);
            this.groupBox1.Controls.Add(this.btnExportToExcel);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMmeConactNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMmeResAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMmeKganyaBookNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMmeSurname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMmeName);
            this.groupBox1.Controls.Add(this.lblMruti);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Location = new System.Drawing.Point(26, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 209);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BOMME Register";
            // 
            // dateTimePickeMmeDOBap
            // 
            this.dateTimePickeMmeDOBap.Location = new System.Drawing.Point(444, 60);
            this.dateTimePickeMmeDOBap.Name = "dateTimePickeMmeDOBap";
            this.dateTimePickeMmeDOBap.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickeMmeDOBap.TabIndex = 6;
            // 
            // cmbMmePosition
            // 
            this.cmbMmePosition.FormattingEnabled = true;
            this.cmbMmePosition.Items.AddRange(new object[] {
            "Hloho",
            "Letsoho",
            "Chairlady",
            "Vice Chairlady",
            "Secretary",
            "Vice Secretary",
            "Treasure",
            "Vice Treasure",
            "Key-Lady",
            "Vice Key-Lady",
            "2nd Ten"});
            this.cmbMmePosition.Location = new System.Drawing.Point(447, 88);
            this.cmbMmePosition.Name = "cmbMmePosition";
            this.cmbMmePosition.Size = new System.Drawing.Size(197, 21);
            this.cmbMmePosition.TabIndex = 7;
            // 
            // cmbMmeOccup
            // 
            this.cmbMmeOccup.FormattingEnabled = true;
            this.cmbMmeOccup.Items.AddRange(new object[] {
            "Pensioner",
            "Domestic Worker",
            "Cleaner",
            "Unemployed",
            "Bakery"});
            this.cmbMmeOccup.Location = new System.Drawing.Point(442, 30);
            this.cmbMmeOccup.Name = "cmbMmeOccup";
            this.cmbMmeOccup.Size = new System.Drawing.Size(202, 21);
            this.cmbMmeOccup.TabIndex = 5;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackColor = System.Drawing.Color.Green;
            this.btnExportToExcel.ForeColor = System.Drawing.Color.Yellow;
            this.btnExportToExcel.Location = new System.Drawing.Point(424, 162);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(92, 29);
            this.btnExportToExcel.TabIndex = 2;
            this.btnExportToExcel.Text = "Export To Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Green;
            this.btnDisplay.ForeColor = System.Drawing.Color.Yellow;
            this.btnDisplay.Location = new System.Drawing.Point(522, 162);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(92, 29);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(624, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add MME";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.label7.Location = new System.Drawing.Point(343, 91);
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
            // txtMmeConactNo
            // 
            this.txtMmeConactNo.Location = new System.Drawing.Point(151, 111);
            this.txtMmeConactNo.Name = "txtMmeConactNo";
            this.txtMmeConactNo.Size = new System.Drawing.Size(159, 20);
            this.txtMmeConactNo.TabIndex = 3;
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
            // txtMmeResAddress
            // 
            this.txtMmeResAddress.Location = new System.Drawing.Point(151, 137);
            this.txtMmeResAddress.Multiline = true;
            this.txtMmeResAddress.Name = "txtMmeResAddress";
            this.txtMmeResAddress.Size = new System.Drawing.Size(159, 45);
            this.txtMmeResAddress.TabIndex = 4;
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
            // txtMmeKganyaBookNo
            // 
            this.txtMmeKganyaBookNo.Location = new System.Drawing.Point(151, 83);
            this.txtMmeKganyaBookNo.Name = "txtMmeKganyaBookNo";
            this.txtMmeKganyaBookNo.Size = new System.Drawing.Size(159, 20);
            this.txtMmeKganyaBookNo.TabIndex = 2;
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
            // txtMmeSurname
            // 
            this.txtMmeSurname.Location = new System.Drawing.Point(151, 57);
            this.txtMmeSurname.Name = "txtMmeSurname";
            this.txtMmeSurname.Size = new System.Drawing.Size(159, 20);
            this.txtMmeSurname.TabIndex = 1;
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
            // txtMmeName
            // 
            this.txtMmeName.Location = new System.Drawing.Point(151, 31);
            this.txtMmeName.Name = "txtMmeName";
            this.txtMmeName.Size = new System.Drawing.Size(159, 20);
            this.txtMmeName.TabIndex = 0;
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
            // dataGridViewBoMme
            // 
            this.dataGridViewBoMme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoMme.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewBoMme.Location = new System.Drawing.Point(0, 272);
            this.dataGridViewBoMme.Name = "dataGridViewBoMme";
            this.dataGridViewBoMme.Size = new System.Drawing.Size(825, 209);
            this.dataGridViewBoMme.TabIndex = 4;
            this.dataGridViewBoMme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBoMme_CellClick);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Stencil Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Yellow;
            this.lblWelcome.Location = new System.Drawing.Point(279, 5);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(227, 25);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Lekgotla La BOMMe";
            // 
            // lblTotalNumOfSubBomme
            // 
            this.lblTotalNumOfSubBomme.AutoSize = true;
            this.lblTotalNumOfSubBomme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalNumOfSubBomme.Location = new System.Drawing.Point(751, 257);
            this.lblTotalNumOfSubBomme.Name = "lblTotalNumOfSubBomme";
            this.lblTotalNumOfSubBomme.Size = new System.Drawing.Size(35, 13);
            this.lblTotalNumOfSubBomme.TabIndex = 6;
            this.lblTotalNumOfSubBomme.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Linen;
            this.label8.Location = new System.Drawing.Point(626, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total Number Of Bomme:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sub Branch Name:";
            // 
            // cmbSubBommeBranchName
            // 
            this.cmbSubBommeBranchName.FormattingEnabled = true;
            this.cmbSubBommeBranchName.Items.AddRange(new object[] {
            "Hloho",
            "Letsoho",
            "Chairlady",
            "Vice Chairlady",
            "Secretary",
            "Vice Secretary",
            "Treasure",
            "Vice Treasure",
            "Key-Lady",
            "Vice Key-Lady",
            "2nd Ten"});
            this.cmbSubBommeBranchName.Location = new System.Drawing.Point(447, 119);
            this.cmbSubBommeBranchName.Name = "cmbSubBommeBranchName";
            this.cmbSubBommeBranchName.Size = new System.Drawing.Size(197, 21);
            this.cmbSubBommeBranchName.TabIndex = 7;
            // 
            // BommeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(825, 481);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalNumOfSubBomme);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewBoMme);
            this.Controls.Add(this.lblWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BommeForm";
            this.Text = "BommeForm";
            this.Load += new System.EventHandler(this.BommeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoMme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickeMmeDOBap;
        private System.Windows.Forms.ComboBox cmbMmePosition;
        private System.Windows.Forms.ComboBox cmbMmeOccup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMmeConactNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMmeResAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMmeKganyaBookNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMmeSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMmeName;
        private System.Windows.Forms.Label lblMruti;
        private System.Windows.Forms.DataGridView dataGridViewBoMme;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTotalNumOfSubBomme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.ComboBox cmbSubBommeBranchName;
        private System.Windows.Forms.Label label9;
    }
}