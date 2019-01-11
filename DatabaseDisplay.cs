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
    public partial class DatabaseDisplay : Form
    {
        public DatabaseDisplay()
        {
            InitializeComponent();
        }

        private void DatabaseDisplay_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = true;
            try{
            //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT membershipNo AS [Kganya Number], surname AS Surname, firstname AS FirstName, lastname AS [Other Name], IdentityNo AS [ID Number], DoB AS [Date Of Birth], gender AS Gender, positon AS [Position], 
                         cellNo AS [Cellphone Number], AlternativeNo AS [Otherr Cellphone Number], residentialAddress AS [Home Address], DateOfBaptizim AS [Date Baptized], Status AS [Employment Status],kganyaMember AS [Kganya Member], SediLakganya AS [Sedi La kganya Member],KganyaDirect AS [Kganya Direct Member],KganyaKoloi AS [Kganya Koloi Member],Bursary AS [Bursary Holder] FROM tblMembers", con);
                sdr.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                lblTotalMembers.Text = dataGridView1.Rows.Count.ToString();
                con.Close();
                ds.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            //con.Open();
            //try
            //{

            //    DataSet ds = new DataSet();
            //    DataView dv = new DataView(ds.Tables[0]);
            //    dv.RowFilter = string.Format("[tblMembers.positon] AS [Position] '%{0}%'", txtSearchMember.Text);
            //    dataGridView1.DataSource = dv;
            //}
            //catch (OleDbException ex)
            //{
            //    MessageBox.Show(" " + ex);

            //}
            //finally
            //{
            //    con.Close();

            //}
        }

        private void btnMkhukhuView_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            con.Open();
            try
            {

                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT membershipNo AS [Kganya Number], surname AS Surname, firstname AS FirstName, lastname AS [Other Name], IdentityNo AS [ID Number], DoB AS [Date Of Birth], gender AS Gender, positon AS [Position], 
                         cellNo AS [Cellphone Number], AlternativeNo AS [Otherr Cellphone Number], residentialAddress AS [Home Address], DateOfBaptizim AS [Date Baptized], Status AS [Employment Status], kganyaMember AS [Kganya Member], SediLakganya AS [Sedi La kganya Member],KganyaDirect AS [Kganya Direct Member],KganyaKoloi AS [Kganya Koloi Member],Bursary AS [Bursary Holder]  FROM tblMembers WHERE (positon = 'mokhukhu member')", con);
                sdr.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                lblTotalMembers.Text = dataGridView1.Rows.Count.ToString();

                ds.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(" " + ex);

            }
            finally
            {
                con.Close();

            }
        }

        private void btnFemaleChoirView_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            con.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT membershipNo AS [Kganya Number], surname AS Surname, firstname AS FirstName, lastname AS [Other Name], IdentityNo AS [ID Number], DoB AS [Date Of Birth], gender AS Gender, positon AS [Position], 
                         cellNo AS [Cellphone Number], AlternativeNo AS [Otherr Cellphone Number], residentialAddress AS [Home Address], DateOfBaptizim AS [Date Baptized], Status AS [Employment Status], 
                         kganyaMember AS [Kganya Member], SediLakganya AS [Sedi La kganya Member],KganyaDirect AS [Kganya Direct Member],KganyaKoloi AS [Kganya Koloi Member],Bursary AS [Bursary Holder] FROM tblMembers WHERE (positon = 'Female Choir member')", con);
            sdr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            lblTotalMembers.Text = dataGridView1.Rows.Count.ToString();

            con.Close();
            ds.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
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
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            //
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "output";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }

        private void btnSundaySchool_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            con.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT membershipNo AS [Kganya Number], surname AS Surname, firstname AS FirstName, lastname AS [Other Name], IdentityNo AS [ID Number], DoB AS [Date Of Birth], gender AS Gender, positon AS [Position], 
                         cellNo AS [Cellphone Number], AlternativeNo AS [Otherr Cellphone Number], residentialAddress AS [Home Address], DateOfBaptizim AS [Date Baptized], Status AS [Employment Status], 
                         kganyaMember AS [Kganya Member], SediLakganya AS [Sedi La kganya Member],KganyaDirect AS [Kganya Direct Member],KganyaKoloi AS [Kganya Koloi Member],Bursary AS [Bursary Holder] FROM tblMembers WHERE (positon = 'Sunday School Member')", con);
            sdr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            lblTotalMembers.Text = dataGridView1.Rows.Count.ToString();

            ds.Dispose();
            con.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            //con.Open();
            //try
            //{

            //    DataSet ds = new DataSet();
            //    DataView dv = new DataView(ds.Tables[0]);
            //    dv.RowFilter = string.Format("[tblMembers.positon] AS [Position] '%{0}%'", txtSearchMember.Text);
            //    dataGridView1.DataSource = dv;
            //}
            //catch (OleDbException ex)
            //{
            //    MessageBox.Show(" " + ex);

            //}
            //finally
            //{
            //    con.Close();

            //}
        }

        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            //con.Open();
            //try
            //{

            //    DataSet ds = new DataSet();
            //    DataView dv = new DataView(ds.Tables[0]);
            //    dv.RowFilter = string.Format("[tblMembers.positon] AS [Position] '%{0}%'", txtSearchMember.Text);
            //    dataGridView1.DataSource = dv;
            //}
            //catch (OleDbException ex)
            //{
            //    MessageBox.Show(" " + ex);

            //}
            //finally
            //{
            //    con.Close();

            //}
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
             OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            
            try {

                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT membershipNo AS [Kganya Number], surname AS Surname, firstname AS FirstName, lastname AS [Other Name], IdentityNo AS [ID Number], DoB AS [Date Of Birth], gender AS Gender, positon AS [Position], 
                         cellNo AS [Cellphone Number], AlternativeNo AS [Otherr Cellphone Number], residentialAddress AS [Home Address], DateOfBaptizim AS [Date Baptized], Status AS [Employment Status], 
                         kganyaMember AS [Kganya Member], SediLakganya AS [Sedi La kganya Member],KganyaDirect AS [Kganya Direct Member],KganyaKoloi AS [Kganya Koloi Member],Bursary AS [Bursary Holder]  FROM tblMembers WHERE [surname] like ('" + txtSearchMember.Text + "')", con);
                sdr.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(OleDbException ex) {
                MessageBox.Show(" " + ex);

            }
            finally
            {
                con.Close();
                
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (OleDbConnection oledbConn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb"))
            {
                OleDbCommand delCmd = new OleDbCommand();
                oledbConn.Open();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    DataGridViewRow delRow = dataGridView1.Rows[i];
                    if (delRow.Selected == true)
                    {
                        //txtMorutiName.Text = dataGridViewBaruti[0, e.RowIndex].Value.ToString();
                        //
                        dataGridView1.Rows.RemoveAt(i);
                        try
                        {
                            delCmd = oledbConn.CreateCommand();
                            delCmd.CommandText = @"DELETE FROM tblMembers WHERE ([Surname] like'" + txtSearchMember.Text.Trim() + "')";
                            delCmd.Connection = oledbConn;
                            int count = delCmd.ExecuteNonQuery();
                            MessageBox.Show("Record Successfully Deleted");
                            txtSearchMember.Text = "";
                        }
                        catch (OleDbException Ex)
                        {
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
           // {
            try
            {
                
                txtSearchMember.Text = dataGridView1[1, e.RowIndex].Value.ToString();

            }catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }

           

               // txtSearchMember.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                
               //return;
            //}
            

        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");

            try
            {

                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT membershipNo AS [Kganya Number], surname AS Surname, firstname AS FirstName, lastname AS [Other Name], IdentityNo AS [ID Number], DoB AS [Date Of Birth], gender AS Gender, positon AS [Position], 
                         cellNo AS [Cellphone Number], AlternativeNo AS [Otherr Cellphone Number], residentialAddress AS [Home Address], DateOfBaptizim AS [Date Baptized], Status AS [Employment Status], 
                         kganyaMember AS [Kganya Member], SediLakganya AS [Sedi La kganya Member],KganyaDirect AS [Kganya Direct Member],KganyaKoloi AS [Kganya Koloi Member],Bursary AS [Bursary Holder]  FROM tblMembers", con);
                sdr.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(" " + ex);

            }
            finally
            {
                con.Close();

            }
        }
    }
}
