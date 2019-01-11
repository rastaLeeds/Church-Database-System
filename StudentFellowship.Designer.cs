namespace CMS_DEMO
{
    partial class StudentFellowship
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentFellowship));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblMove = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNextOfKin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNoKinContct = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCampus = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStuLeaderName = new System.Windows.Forms.TextBox();
            this.txtStuLeaderSurname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbLeaderGender = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbLeadershipPosition = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbLeaderCampus = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbFunding = new System.Windows.Forms.ComboBox();
            this.dataGridViewStudentFellowship = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePickerYoStudy = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.btnAddStuLeader = new System.Windows.Forms.Button();
            this.txtExportStudLeadership = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.dateTimePickerLeaderFrom = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.txtLeaderContact = new System.Windows.Forms.TextBox();
            this.btnRefreshStudent = new System.Windows.Forms.Button();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnSearchStu = new System.Windows.Forms.Button();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnLeaderRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentFellowship)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.splitContainer1.Panel1.Controls.Add(this.label21);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalStudents);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePickerLeaderFrom);
            this.splitContainer1.Panel1.Controls.Add(this.cmbLeaderCampus);
            this.splitContainer1.Panel1.Controls.Add(this.txtExportStudLeadership);
            this.splitContainer1.Panel1.Controls.Add(this.lblMove);
            this.splitContainer1.Panel1.Controls.Add(this.btnLeaderRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddStuLeader);
            this.splitContainer1.Panel1.Controls.Add(this.cmbLeadershipPosition);
            this.splitContainer1.Panel1.Controls.Add(this.cmbLeaderGender);
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.txtLeaderContact);
            this.splitContainer1.Panel1.Controls.Add(this.txtStuLeaderName);
            this.splitContainer1.Panel1.Controls.Add(this.txtStuLeaderSurname);
            this.splitContainer1.Panel1.Controls.Add(this.label16);
            this.splitContainer1.Panel1.Controls.Add(this.label19);
            this.splitContainer1.Panel1.Controls.Add(this.label20);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gold;
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePickerYoStudy);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.btnRefreshStudent);
            this.splitContainer1.Panel2.Controls.Add(this.btnDeleteStudent);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.cmbFunding);
            this.splitContainer1.Panel2.Controls.Add(this.cmbCampus);
            this.splitContainer1.Panel2.Controls.Add(this.btnSearchStu);
            this.splitContainer1.Panel2.Controls.Add(this.cmbGender);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txtHomeAddress);
            this.splitContainer1.Panel2.Controls.Add(this.txtNextOfKin);
            this.splitContainer1.Panel2.Controls.Add(this.txtCourse);
            this.splitContainer1.Panel2.Controls.Add(this.txtNoKinContct);
            this.splitContainer1.Panel2.Controls.Add(this.txtContactNo);
            this.splitContainer1.Panel2.Controls.Add(this.txtEmailAddress);
            this.splitContainer1.Panel2.Controls.Add(this.txtStudSurname);
            this.splitContainer1.Panel2.Controls.Add(this.txtSearchStudent);
            this.splitContainer1.Panel2.Controls.Add(this.txtSudentName);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label18);
            this.splitContainer1.Panel2.Controls.Add(this.label17);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1199, 414);
            this.splitContainer1.SplitterDistance = 480;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.Font = new System.Drawing.Font("Stencil Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMove.ForeColor = System.Drawing.Color.Gold;
            this.lblMove.Location = new System.Drawing.Point(103, 23);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(158, 25);
            this.lblMove.TabIndex = 2;
            this.lblMove.Text = "BEC Members";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(131, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Members Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Name:";
            // 
            // txtSudentName
            // 
            this.txtSudentName.Location = new System.Drawing.Point(139, 52);
            this.txtSudentName.Name = "txtSudentName";
            this.txtSudentName.Size = new System.Drawing.Size(191, 20);
            this.txtSudentName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(22, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Surname::";
            // 
            // txtStudSurname
            // 
            this.txtStudSurname.Location = new System.Drawing.Point(139, 85);
            this.txtStudSurname.Name = "txtStudSurname";
            this.txtStudSurname.Size = new System.Drawing.Size(191, 20);
            this.txtStudSurname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(25, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(139, 124);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(191, 21);
            this.cmbGender.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(22, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Home Address:";
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Location = new System.Drawing.Point(139, 157);
            this.txtHomeAddress.Multiline = true;
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(191, 42);
            this.txtHomeAddress.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(25, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email Address:";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(142, 216);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(191, 20);
            this.txtEmailAddress.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(22, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Contact No";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(143, 242);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(191, 20);
            this.txtContactNo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(353, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Next Of Kin(Name):";
            // 
            // txtNextOfKin
            // 
            this.txtNextOfKin.Location = new System.Drawing.Point(474, 52);
            this.txtNextOfKin.Name = "txtNextOfKin";
            this.txtNextOfKin.Size = new System.Drawing.Size(191, 20);
            this.txtNextOfKin.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(353, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Next Of Kin Conctact:";
            // 
            // txtNoKinContct
            // 
            this.txtNoKinContct.Location = new System.Drawing.Point(474, 82);
            this.txtNoKinContct.Name = "txtNoKinContct";
            this.txtNoKinContct.Size = new System.Drawing.Size(191, 20);
            this.txtNoKinContct.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(353, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Course Erolled:";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(474, 117);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(191, 20);
            this.txtCourse.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(353, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Campus:";
            // 
            // cmbCampus
            // 
            this.cmbCampus.FormattingEnabled = true;
            this.cmbCampus.Items.AddRange(new object[] {
            "CUT STUDENT FELLOWSHIP",
            "UFS STUDENT FELLOWSHIP"});
            this.cmbCampus.Location = new System.Drawing.Point(473, 157);
            this.cmbCampus.Name = "cmbCampus";
            this.cmbCampus.Size = new System.Drawing.Size(192, 21);
            this.cmbCampus.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(47, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Student Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Yellow;
            this.label13.Location = new System.Drawing.Point(47, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Student Surname::";
            // 
            // txtStuLeaderName
            // 
            this.txtStuLeaderName.Location = new System.Drawing.Point(164, 66);
            this.txtStuLeaderName.Name = "txtStuLeaderName";
            this.txtStuLeaderName.Size = new System.Drawing.Size(191, 20);
            this.txtStuLeaderName.TabIndex = 0;
            // 
            // txtStuLeaderSurname
            // 
            this.txtStuLeaderSurname.Location = new System.Drawing.Point(164, 99);
            this.txtStuLeaderSurname.Name = "txtStuLeaderSurname";
            this.txtStuLeaderSurname.Size = new System.Drawing.Size(191, 20);
            this.txtStuLeaderSurname.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Yellow;
            this.label14.Location = new System.Drawing.Point(50, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Gender";
            // 
            // cmbLeaderGender
            // 
            this.cmbLeaderGender.FormattingEnabled = true;
            this.cmbLeaderGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbLeaderGender.Location = new System.Drawing.Point(164, 138);
            this.cmbLeaderGender.Name = "cmbLeaderGender";
            this.cmbLeaderGender.Size = new System.Drawing.Size(191, 21);
            this.cmbLeaderGender.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Yellow;
            this.label15.Location = new System.Drawing.Point(50, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Position";
            // 
            // cmbLeadershipPosition
            // 
            this.cmbLeadershipPosition.FormattingEnabled = true;
            this.cmbLeadershipPosition.Items.AddRange(new object[] {
            "Chairperson",
            "Vice Chairperson",
            "Secretary",
            "Vice Secretary",
            "Organizer",
            "Legal And Transformation Officer",
            "Resource Officer",
            "Additional Memeber",
            "NEC Member",
            "PEC Member",
            "Other"});
            this.cmbLeadershipPosition.Location = new System.Drawing.Point(164, 173);
            this.cmbLeadershipPosition.Name = "cmbLeadershipPosition";
            this.cmbLeadershipPosition.Size = new System.Drawing.Size(191, 21);
            this.cmbLeadershipPosition.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Yellow;
            this.label16.Location = new System.Drawing.Point(44, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Campus:";
            // 
            // cmbLeaderCampus
            // 
            this.cmbLeaderCampus.FormattingEnabled = true;
            this.cmbLeaderCampus.Items.AddRange(new object[] {
            "CUT STUDENT FELLOWSHIP",
            "UFS STUDENT FELLOWSHIP"});
            this.cmbLeaderCampus.Location = new System.Drawing.Point(164, 208);
            this.cmbLeaderCampus.Name = "cmbLeaderCampus";
            this.cmbLeaderCampus.Size = new System.Drawing.Size(192, 21);
            this.cmbLeaderCampus.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.DarkGreen;
            this.label17.Location = new System.Drawing.Point(355, 188);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Type Of Funding:";
            // 
            // cmbFunding
            // 
            this.cmbFunding.FormattingEnabled = true;
            this.cmbFunding.Items.AddRange(new object[] {
            "Bursary",
            "Church Bursary",
            "Study Loan",
            "NSFAS",
            "Self Funded"});
            this.cmbFunding.Location = new System.Drawing.Point(475, 188);
            this.cmbFunding.Name = "cmbFunding";
            this.cmbFunding.Size = new System.Drawing.Size(192, 21);
            this.cmbFunding.TabIndex = 10;
            // 
            // dataGridViewStudentFellowship
            // 
            this.dataGridViewStudentFellowship.AllowUserToAddRows = false;
            this.dataGridViewStudentFellowship.AllowUserToDeleteRows = false;
            this.dataGridViewStudentFellowship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentFellowship.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewStudentFellowship.Location = new System.Drawing.Point(0, 423);
            this.dataGridViewStudentFellowship.Name = "dataGridViewStudentFellowship";
            this.dataGridViewStudentFellowship.ReadOnly = true;
            this.dataGridViewStudentFellowship.Size = new System.Drawing.Size(1212, 251);
            this.dataGridViewStudentFellowship.TabIndex = 1;
            this.dataGridViewStudentFellowship.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentFellowship_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(320, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "AddStudent";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(508, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePickerYoStudy
            // 
            this.dateTimePickerYoStudy.Location = new System.Drawing.Point(475, 216);
            this.dateTimePickerYoStudy.Name = "dateTimePickerYoStudy";
            this.dateTimePickerYoStudy.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerYoStudy.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.DarkGreen;
            this.label18.Location = new System.Drawing.Point(353, 223);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Year Of Study:";
            // 
            // btnAddStuLeader
            // 
            this.btnAddStuLeader.BackColor = System.Drawing.Color.Gold;
            this.btnAddStuLeader.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddStuLeader.Location = new System.Drawing.Point(108, 319);
            this.btnAddStuLeader.Name = "btnAddStuLeader";
            this.btnAddStuLeader.Size = new System.Drawing.Size(115, 36);
            this.btnAddStuLeader.TabIndex = 7;
            this.btnAddStuLeader.Text = "Add Student Leader";
            this.btnAddStuLeader.UseVisualStyleBackColor = false;
            this.btnAddStuLeader.Click += new System.EventHandler(this.btnAddStuLeader_Click);
            // 
            // txtExportStudLeadership
            // 
            this.txtExportStudLeadership.BackColor = System.Drawing.Color.Gold;
            this.txtExportStudLeadership.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtExportStudLeadership.Location = new System.Drawing.Point(229, 319);
            this.txtExportStudLeadership.Name = "txtExportStudLeadership";
            this.txtExportStudLeadership.Size = new System.Drawing.Size(97, 35);
            this.txtExportStudLeadership.TabIndex = 8;
            this.txtExportStudLeadership.Text = "Export To Excile";
            this.txtExportStudLeadership.UseVisualStyleBackColor = false;
            this.txtExportStudLeadership.Click += new System.EventHandler(this.txtExportStudLeadership_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Yellow;
            this.label19.Location = new System.Drawing.Point(43, 275);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Year Of Leadership:";
            // 
            // dateTimePickerLeaderFrom
            // 
            this.dateTimePickerLeaderFrom.Location = new System.Drawing.Point(165, 268);
            this.dateTimePickerLeaderFrom.Name = "dateTimePickerLeaderFrom";
            this.dateTimePickerLeaderFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerLeaderFrom.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Yellow;
            this.label20.Location = new System.Drawing.Point(47, 247);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Contact No";
            // 
            // txtLeaderContact
            // 
            this.txtLeaderContact.Location = new System.Drawing.Point(168, 242);
            this.txtLeaderContact.Name = "txtLeaderContact";
            this.txtLeaderContact.Size = new System.Drawing.Size(191, 20);
            this.txtLeaderContact.TabIndex = 5;
            // 
            // btnRefreshStudent
            // 
            this.btnRefreshStudent.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRefreshStudent.ForeColor = System.Drawing.Color.Yellow;
            this.btnRefreshStudent.Location = new System.Drawing.Point(414, 290);
            this.btnRefreshStudent.Name = "btnRefreshStudent";
            this.btnRefreshStudent.Size = new System.Drawing.Size(88, 37);
            this.btnRefreshStudent.TabIndex = 8;
            this.btnRefreshStudent.Text = "Refresh";
            this.btnRefreshStudent.UseVisualStyleBackColor = false;
            this.btnRefreshStudent.Click += new System.EventHandler(this.btnRefreshStudent_Click);
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Location = new System.Drawing.Point(148, 389);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(0, 13);
            this.lblTotalStudents.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 389);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(133, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "Total Number Of Students:";
            // 
            // btnSearchStu
            // 
            this.btnSearchStu.BackColor = System.Drawing.Color.Gold;
            this.btnSearchStu.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSearchStu.Location = new System.Drawing.Point(217, 383);
            this.btnSearchStu.Name = "btnSearchStu";
            this.btnSearchStu.Size = new System.Drawing.Size(156, 24);
            this.btnSearchStu.TabIndex = 8;
            this.btnSearchStu.Text = "Search By Name or Surname";
            this.btnSearchStu.UseVisualStyleBackColor = false;
            this.btnSearchStu.Click += new System.EventHandler(this.btnSearchStu_Click);
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(17, 386);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(191, 20);
            this.txtSearchStudent.TabIndex = 4;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.Yellow;
            this.btnDeleteStudent.Location = new System.Drawing.Point(602, 293);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(88, 34);
            this.btnDeleteStudent.TabIndex = 8;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnLeaderRefresh
            // 
            this.btnLeaderRefresh.BackColor = System.Drawing.Color.Gold;
            this.btnLeaderRefresh.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnLeaderRefresh.Location = new System.Drawing.Point(332, 318);
            this.btnLeaderRefresh.Name = "btnLeaderRefresh";
            this.btnLeaderRefresh.Size = new System.Drawing.Size(115, 36);
            this.btnLeaderRefresh.TabIndex = 8;
            this.btnLeaderRefresh.Text = "Refresh";
            this.btnLeaderRefresh.UseVisualStyleBackColor = false;
            this.btnLeaderRefresh.Click += new System.EventHandler(this.btnLeaderRefresh_Click);
            // 
            // StudentFellowship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 674);
            this.Controls.Add(this.dataGridViewStudentFellowship);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentFellowship";
            this.Text = "StudentFellowship";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentFellowship)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtStudSurname;
        private System.Windows.Forms.TextBox txtSudentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLeaderCampus;
        private System.Windows.Forms.Button txtExportStudLeadership;
        private System.Windows.Forms.Button btnAddStuLeader;
        private System.Windows.Forms.ComboBox cmbLeadershipPosition;
        private System.Windows.Forms.ComboBox cmbLeaderGender;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStuLeaderName;
        private System.Windows.Forms.TextBox txtStuLeaderSurname;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePickerYoStudy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbFunding;
        private System.Windows.Forms.ComboBox cmbCampus;
        private System.Windows.Forms.TextBox txtNextOfKin;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtNoKinContct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewStudentFellowship;
        private System.Windows.Forms.DateTimePicker dateTimePickerLeaderFrom;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtLeaderContact;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnRefreshStudent;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Button btnSearchStu;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnLeaderRefresh;
    }
}