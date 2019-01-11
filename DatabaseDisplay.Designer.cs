namespace CMS_DEMO
{
    partial class DatabaseDisplay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseDisplay));
            this.label1 = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.btnSundaySchool = new System.Windows.Forms.Button();
            this.btnMkhukhuView = new System.Windows.Forms.Button();
            this.btnFemaleChoirView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(262, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Membership Database Display";
            // 
            // panelFilter
            // 
            this.panelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFilter.BackColor = System.Drawing.Color.Gold;
            this.panelFilter.Controls.Add(this.lblTotalMembers);
            this.panelFilter.Controls.Add(this.label2);
            this.panelFilter.Controls.Add(this.txtSearchMember);
            this.panelFilter.Controls.Add(this.btnSundaySchool);
            this.panelFilter.Controls.Add(this.btnMkhukhuView);
            this.panelFilter.Controls.Add(this.btnFemaleChoirView);
            this.panelFilter.Controls.Add(this.btnDelete);
            this.panelFilter.Controls.Add(this.btnRefreshData);
            this.panelFilter.Controls.Add(this.button1);
            this.panelFilter.Controls.Add(this.btnSearch);
            this.panelFilter.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panelFilter.Location = new System.Drawing.Point(0, 47);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(948, 146);
            this.panelFilter.TabIndex = 1;
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.AutoSize = true;
            this.lblTotalMembers.Location = new System.Drawing.Point(907, 126);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(35, 13);
            this.lblTotalMembers.TabIndex = 4;
            this.lblTotalMembers.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(745, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total No Of Members Registered:";
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Location = new System.Drawing.Point(16, 16);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(238, 20);
            this.txtSearchMember.TabIndex = 1;
            // 
            // btnSundaySchool
            // 
            this.btnSundaySchool.BackColor = System.Drawing.Color.White;
            this.btnSundaySchool.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSundaySchool.Location = new System.Drawing.Point(483, 86);
            this.btnSundaySchool.Name = "btnSundaySchool";
            this.btnSundaySchool.Size = new System.Drawing.Size(169, 34);
            this.btnSundaySchool.TabIndex = 0;
            this.btnSundaySchool.Text = "View Sunday School Members";
            this.btnSundaySchool.UseVisualStyleBackColor = false;
            this.btnSundaySchool.Click += new System.EventHandler(this.btnSundaySchool_Click);
            // 
            // btnMkhukhuView
            // 
            this.btnMkhukhuView.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnMkhukhuView.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnMkhukhuView.Location = new System.Drawing.Point(308, 86);
            this.btnMkhukhuView.Name = "btnMkhukhuView";
            this.btnMkhukhuView.Size = new System.Drawing.Size(169, 34);
            this.btnMkhukhuView.TabIndex = 0;
            this.btnMkhukhuView.Text = "View Mkhukhu Members";
            this.btnMkhukhuView.UseVisualStyleBackColor = false;
            this.btnMkhukhuView.Click += new System.EventHandler(this.btnMkhukhuView_Click);
            // 
            // btnFemaleChoirView
            // 
            this.btnFemaleChoirView.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFemaleChoirView.ForeColor = System.Drawing.Color.Yellow;
            this.btnFemaleChoirView.Location = new System.Drawing.Point(133, 86);
            this.btnFemaleChoirView.Name = "btnFemaleChoirView";
            this.btnFemaleChoirView.Size = new System.Drawing.Size(169, 34);
            this.btnFemaleChoirView.TabIndex = 0;
            this.btnFemaleChoirView.Text = "View Female Choir Members";
            this.btnFemaleChoirView.UseVisualStyleBackColor = false;
            this.btnFemaleChoirView.Click += new System.EventHandler(this.btnFemaleChoirView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDelete.ForeColor = System.Drawing.Color.Yellow;
            this.btnDelete.Location = new System.Drawing.Point(16, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 24);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "delete from database";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(28, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Export To Excile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSearch.ForeColor = System.Drawing.Color.Yellow;
            this.btnSearch.Location = new System.Drawing.Point(260, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(186, 24);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search By kganya No or Surname";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(969, 382);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRefreshData.ForeColor = System.Drawing.Color.Yellow;
            this.btnRefreshData.Location = new System.Drawing.Point(672, 86);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(135, 34);
            this.btnRefreshData.TabIndex = 0;
            this.btnRefreshData.Text = "Refresh Database";
            this.btnRefreshData.UseVisualStyleBackColor = false;
            this.btnRefreshData.Click += new System.EventHandler(this.btnRefreshData_Click);
            // 
            // DatabaseDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(969, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabaseDisplay";
            this.Text = "DatabaseDisplay";
            this.Load += new System.EventHandler(this.DatabaseDisplay_Load);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.Button btnSundaySchool;
        private System.Windows.Forms.Button btnMkhukhuView;
        private System.Windows.Forms.Button btnFemaleChoirView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefreshData;
    }
}