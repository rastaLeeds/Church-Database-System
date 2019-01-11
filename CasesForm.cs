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
    public partial class CasesForm : Form
    {
        
        //
        public CasesForm()
        {
           
            InitializeComponent();
           
        }

   //
        private void btnClear_Click(object sender, EventArgs e)
        {
            //
            txtCaseNo.Clear();
            dtpCaseDate.ResetText();
            cmbStatusOCase.ResetText();
            cmbCaseType.ResetText();
            cmbReputationRick.ResetText();
            rtxtCaseDescrip.Clear();
        }

        private void btnSubmitCase_Click(object sender, EventArgs e)
        {
            //not the best practice to include database this way 
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";
            conn.Open();
            //
        string caseNo = txtCaseNo.Text.Trim();
        string caseDate = dtpCaseDate.Text.Trim();
        string duration = txtCaseDuration.Text.Trim();
        string caseStatus = cmbStatusOCase.SelectedItem.ToString();
        string caseType = cmbCaseType.SelectedItem.ToString();
        string reputationalRick = cmbReputationRick.SelectedItem.ToString();
        string caseDescrip = rtxtCaseDescrip.Text.Trim();
        //
            try
            {
                 
              //member table data insertion
                String my_querry = @"INSERT INTO tblCases (CaseNumber, CaseDate, CasteType, Duration, StatusOfCase, ReputationalRicks, caseDescript)
                                    VALUES ('"+ caseNo +"', '"+ caseDate+"', '"+caseType+"', '"+duration+"', '"+caseStatus+"', '"+reputationalRick+"', '"+caseDescrip+"')";
            OleDbCommand cmd = new OleDbCommand(my_querry, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Case successfuly added...!");

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(" " + ex);
            }
            finally
            {

                conn.Close();
            }
           
        }
        //displaying cases on datagridview 
        private void btnRefreahCaseDB_Click(object sender, EventArgs e)
        {
            //
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            con.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT CaseNumber AS [Case Number], CaseDate AS [Case Date], CasteType AS [Case Type], Duration AS [Duration Of Case], StatusOfCase AS [status Of Case], ReputationalRicks AS [Reputational Risk], 
                         caseDescript AS [Case Description] FROM tblCases", con);
            sdr.Fill(ds);
            dataGridViewCases.DataSource = ds.Tables[0];
            ds.Dispose();
            con.Close();
            }catch(OleDbException ex){
                MessageBox.Show(" " + ex);
            }
            
        }

        private void btnSearchCase_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");

            try
            {

                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT CaseNumber AS [Case Number], CaseDate AS [Case Date], CasteType AS [Case Type], Duration AS [Duration Of Case], StatusOfCase AS [status Of Case], ReputationalRicks AS [Reputational Risk], 
                         caseDescript AS [Case Description] FROM tblCases WHERE [CaseNumber] like ('" + txtSearchCase.Text.Trim() + "')", con);
                sdr.Fill(ds);
                dataGridViewCases.DataSource = ds.Tables[0];
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

        private void btnDeleteCase_Click(object sender, EventArgs e)
        {
            ////OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");

            ////try
            ////{
                
            ////    //member table data insertion
                
            ////    String my_querry = @"DELETE FROM tblCases WHERE (tblCases.CaseNumber = 'caseNo')";
            ////         cmd.ExecuteNonQuery();
            ////          MessageBox.Show("Case successfuly delted...!");

            
            ////    OleDbCommand cmd = new OleDbCommand(my_querry, conn);
            ////    cmd.ExecuteNonQuery();
            ////    MessageBox.Show("Case successfuly added...!");

            ////}
            ////catch (OleDbException ex)
            ////{
            ////    MessageBox.Show(" " + ex);
            ////}
            ////finally
            ////{

            ////    conn.Close();
            ////}
        }
    }
}
