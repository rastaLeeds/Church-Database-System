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
    public partial class DistrictMinistry : Form
    {
        public DistrictMinistry()
        {
            InitializeComponent();
        }

        private void btnSubmitM_Click(object sender, EventArgs e)
        {
            string churchName = cmbFileNo.SelectedItem.ToString();
            string Branch = cmbBranches.SelectedItem.ToString();
            string newBranchesArea = txtNewBranchesArea.Text.Trim();
            string subBranch = cmbSubBranches.SelectedItem.ToString();
            string NumOfRegisterdMembersPerB = numericUpDownMembersPerBranch.Value.ToString();
            string TotalNoOfBranch = numericUpDownNumOfBaruti.Value.ToString();
            string statusOfBranchBuilding = cmbStatusOfStructure.SelectedItem.ToString();
            string titleDeed = txtTitleDeedNo.Text.Trim();
            //
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";
            try
            {

                conn.Open();
                String my_querry = @"INSERT INTO tblDistrictMinistry (District_Name, Branches, NewBranchesArea, SubBranch, NoOfRegisteredPerBranch, TotalNoOfBaruti, StatusOfBranch, TitleDeedNo)
                                   VALUES('"+churchName+"','"+Branch+"','"+newBranchesArea+"','"+subBranch+"','"+NumOfRegisterdMembersPerB+"','"+TotalNoOfBranch+"','"+statusOfBranchBuilding+"','"+titleDeed+"')";
   
                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Record added successfully");
                //clearing 
                churchName = "";
                Branch = "";
                newBranchesArea = "";
                subBranch = "";
                statusOfBranchBuilding = "";
                //NumOfRegisterdMembersPerB.ResetText();
                titleDeed = "";
                //TotalNoOfBranch.ResetText();
                //
                cmd.Dispose();
                conn.Close();
            }
            catch (OleDbException ex)
            {
                //
                MessageBox.Show(" " + ex);

            }

            //
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT District_Name, Branches, NewBranchesArea AS [New Branches Area], SubBranch AS [Sub Branch],
                                                                NoOfRegisteredPerBranch AS [No Of Registered Per Branch], TotalNoOfBaruti AS [Total No Of Baruti], 
                                                               StatusOfBranch AS [Status Of Branch], TitleDeedNo AS [Title Deed No] FROM tblDistrictMinistry", con);
                sdr.Fill(ds);
                dataGridViewDistrictministry.DataSource = ds.Tables[0];
                sdr.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }

        private void DistrictMinistry_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT District_Name, Branches, NewBranchesArea AS [New Branches Area], SubBranch AS [Sub Branch],
                                                                NoOfRegisteredPerBranch AS [No Of Registered Per Branch], TotalNoOfBaruti AS [Total No Of Baruti], 
                                                               StatusOfBranch AS [Status Of Branch], TitleDeedNo AS [Title Deed No] FROM tblDistrictMinistry", con);
                sdr.Fill(ds);
                dataGridViewDistrictministry.DataSource = ds.Tables[0];
                sdr.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }
    }
}
