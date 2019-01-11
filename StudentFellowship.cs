using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_DEMO
{
    public partial class StudentFellowship : Form
    {
        public StudentFellowship()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studName = txtSudentName.Text.Trim();
            string studSurname = txtStudSurname.Text.Trim();
            string studGender = cmbGender.SelectedItem.ToString();
            string StudHomeAddress = txtHomeAddress.Text.ToString();
            string StudEmail = txtEmailAddress.Text.Trim();
            string StudContact = txtContactNo.Text.Trim();
            string StudNextOfKin = txtNextOfKin.Text.Trim();
            string StudNoKinContct = txtNoKinContct.Text.Trim();
            string Course = txtCourse.Text.Trim();
            string Campus = cmbCampus.SelectedItem.ToString();
            string TypeOfFunding = cmbFunding.SelectedItem.ToString();
            string yearOfStudy = dateTimePickerYoStudy.Text;
 
//

            //
            OleDbConnection conn = new OleDbConnection();
            // TODO: Modify the connection string and include any
            // additional required properties for your database.
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";

            try
            {
                conn.Open();
                // Insert code to process data

                //
                String my_querry = @"INSERT INTO tblSudentFellowship
                         (StudentName, StudentSurname, StudentGender, HomeAddress, StuEmail, StuContactNo, NextOfKin, NOkContactNo, CourseErolled, Campus, TypeOfFunding, yearOfStudy)
                         VALUES('" + studName + "', '" + studSurname + "', '" + studGender + "', '" + StudHomeAddress + "', '" + StudEmail + "', '" + StudContact + "', '" + StudNextOfKin + "', '" + StudNoKinContct + "','" + Course + "','" + Campus + "','" + TypeOfFunding + "','" + yearOfStudy + "')";


                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Student Added Sucessfully", "Added Success");
                //clearing textboxes

                //

            txtSudentName.Text ="".Trim();
            txtStudSurname.Text="".Trim();
            cmbGender.Text="".ToString();
            txtHomeAddress.Text="".ToString();
            txtEmailAddress.Text="".Trim();
            txtContactNo.Text="".Trim();
             txtNextOfKin.Text="".Trim();
            txtNoKinContct.Text="".Trim();
            txtCourse.Text="".Trim();
            cmbCampus.Text="".ToString();
            cmbFunding.Text="".ToString();
             dateTimePickerYoStudy.Text="";
                conn.Close();


            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Failed to connect to data source" + ex);
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////creating an ap object to access the mricrosoft 
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet;
            //  worksheet ;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Church Assets Sheet";
            //
            for (int i = 1; i < dataGridViewStudentFellowship.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewStudentFellowship.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewStudentFellowship.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewStudentFellowship.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewStudentFellowship.Rows[i].Cells[j].Value;
                }
            }
            //
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Student Fellowship ";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }

        private void btnRefreshStudent_Click(object sender, EventArgs e)
        {
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT StudentName AS [Student Name], StudentSurname AS [Student Surname], StudentGender AS Gender, HomeAddress AS [Home Address], StuEmail AS [Email Address], StuContactNo AS [Contact  No], 
                         NextOfKin AS [Next Of Kin], NOkContactNo AS [Next Of Kin Contact No], CourseErolled AS [Course Erolled For], Campus, TypeOfFunding AS [Type Of Funding], yearOfStudy AS [Year Of Study]
                        FROM tblSudentFellowship", con);
                sdr.Fill(ds);
                dataGridViewStudentFellowship.DataSource = ds.Tables[0];
                int countStudent = dataGridViewStudentFellowship.Rows.Count;
                //countStudent = countStudent - 1;
               lblTotalStudents.Text = countStudent.ToString();
                con.Close();
                ds.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }

        private void btnSearchStu_Click(object sender, EventArgs e)
        {

            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT StudentName AS [Student Name], StudentSurname AS [Student Surname], StudentGender AS Gender, HomeAddress AS [Home Address], StuEmail AS [Email Address], StuContactNo AS [Contact  No], 
                                     NextOfKin AS [Next Of Kin], NOkContactNo AS [Next Of Kin Contact No], CourseErolled AS [Course Erolled For], Campus, TypeOfFunding AS [Type Of Funding], yearOfStudy AS [Year Of Study]
                                      FROM            tblSudentFellowship
                                      WHERE        (StudentName = '" + txtSearchStudent.Text.Trim() + "') OR (StudentSurname = '" + txtSearchStudent.Text.Trim() + "')", con);
                sdr.Fill(ds);
                dataGridViewStudentFellowship.DataSource = ds.Tables[0];
                int countStudent = dataGridViewStudentFellowship.Rows.Count;
                //countStudent = countStudent - 1;
                lblTotalStudents.Text = countStudent.ToString();
                con.Close();
                ds.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }

        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            using (OleDbConnection oledbConn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb"))
            {
                OleDbCommand delCmd = new OleDbCommand();
                oledbConn.Open();
                for (int i = 0; i < dataGridViewStudentFellowship.Rows.Count; i++)
                {
                    
                    DataGridViewRow delRow = dataGridViewStudentFellowship.Rows[i];
                    if (delRow.Selected == true)
                    {
                        //txtMorutiName.Text = dataGridViewBaruti[0, e.RowIndex].Value.ToString();
                        //
                        dataGridViewStudentFellowship.Rows.RemoveAt(i);
                        try
                        {
                            delCmd = oledbConn.CreateCommand();
                            delCmd.CommandText = @"DELETE FROM tblSudentFellowship WHERE (StudentName = '" + txtSearchStudent.Text.Trim() +"')";
                            delCmd.Connection = oledbConn;
                            int count = delCmd.ExecuteNonQuery();
                            MessageBox.Show("Record Successfully Deleted");
                            txtSearchStudent.Text = "";
                        }catch(OleDbException Ex){
                            MessageBox.Show(Ex.ToString());
                        }
                        finally
                        {
                           
                            oledbConn.Close();
                        }

                    }
                }
            } 
        }

        private void dataGridViewStudentFellowship_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSearchStudent.Text = dataGridViewStudentFellowship.Rows[0].Cells[0].Value.ToString();
        }

        private void txtExportStudLeadership_Click(object sender, EventArgs e)
        {
            ////creating an ap object to access the mricrosoft 
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet;
            //  worksheet ;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Church Assets Sheet";
            //
            for (int i = 1; i < dataGridViewStudentFellowship.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewStudentFellowship.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewStudentFellowship.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewStudentFellowship.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewStudentFellowship.Rows[i].Cells[j].Value;
                }
            }
            //
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Student Fellowship ";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }

        private void btnAddStuLeader_Click(object sender, EventArgs e)
        {
            string leaderName = txtStuLeaderName.Text.Trim();
            string leaderSurname = txtStuLeaderSurname.Text.Trim();
            string leaderGender = cmbLeaderGender.SelectedItem.ToString();
            string leaderCampus = cmbLeaderCampus.SelectedItem.ToString();
            string leaderPosition = cmbLeadershipPosition.SelectedItem.ToString();
            string leaderContct = txtLeaderContact.Text.Trim();
            string YearOfLeadership = dateTimePickerLeaderFrom.Text;
            //
            //

            //
            OleDbConnection conn = new OleDbConnection();
            // TODO: Modify the connection string and include any
            // additional required properties for your database.
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";

            try
            {
                conn.Open();
                // Insert code to process data

                //
                String my_querry = @"INSERT INTO tblStudentsLeadership
                         (StudName, StudSurnamee, StudGender, StudentPosition, campus, contactNo, YearOfLeadershp)
                         VALUES('" + leaderName + "', '" + leaderSurname + "', '" + leaderGender + "', '" + leaderCampus + "', '" + leaderPosition + "', '" + leaderContct + "', '" + YearOfLeadership + "')";


                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Student Leadership Added Sucessfully", "Added Success");
                //clearing textboxes

                //
                //
                txtStuLeaderName.Text = "".Trim();
                txtStuLeaderSurname.Text = "".Trim();
                cmbLeaderGender.SelectedItem = "".ToString();
                cmbLeaderCampus.SelectedItem = "".ToString();
                cmbLeadershipPosition.SelectedItem = "".ToString();
                txtLeaderContact.Text = "".Trim();
                dateTimePickerLeaderFrom.Text = "";
               
                conn.Close();


            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Failed to connect to data source" + ex);
            }

           

        }

        private void btnLeaderRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT StudName AS Name, StudSurnamee AS Surname, StudGender AS Gender, StudentPosition AS [Position], campus AS Campus, contactNo AS [Contact No], YearOfLeadershp AS [Year Of Leadership]
                                                            FROM tblStudentsLeadership", con);
                sdr.Fill(ds);
                dataGridViewStudentFellowship.DataSource = ds.Tables[0];
                int countStudent = dataGridViewStudentFellowship.Rows.Count;
                //countStudent = countStudent - 1;
                lblTotalStudents.Text = countStudent.ToString();
                con.Close();
                ds.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }
    }
}
