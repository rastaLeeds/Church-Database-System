using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_DEMO
{
    public partial class kganya : Form
    {
        public kganya()
        {
            InitializeComponent();
          //  databaseConn();
            //btnAddMember.Enabled = false;
            //if (chckNonKganya.AutoCheck == true)
            ////{

            //txtMembershipNo.Hide();
            ////}

        }

        ////creating database connection  and checking whether the connection is open or not if not open then dispaly an error.
        //public static void databaseConn()
        //{

        //    OleDbConnection conn = new OleDbConnection();
        //    // TODO: Modify the connection string and include any
        //    // additional required properties for your database.
        //    conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";
        //    try
        //    {
        //        conn.Open();
        //        // Insert code to process data.
        //        // MessageBox.Show("Database connection Opened");

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Failed to connect to data source" + ex);
        //    }
        //}
        //

        private void btnProceedNext_Click(object sender, EventArgs e)
        {
            //checking if a member has kganya
            if (rbtnNonKganya.Checked == true)
            {
                tabMemberPersonalParticulars.Enabled = false;
            }
            //disabling panel with provide info
            panel1.Enabled = false;
            panel2.Enabled = false;
            panelChild.Enabled = false;
            
            //moving focus to the next tab to insert more info.
            tabBeneficiary.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // tabBeneficiary.Enabled=false;
            panelBeneFiciaryPP.Enabled = false;
            panelRecordOAmend.Enabled = false;
            btnAddMember.Enabled = true;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            ////declaring variable to gender input from the user
            string memberGender = null;
            //string beneficaryGender = null;
            string DependentGender = null;
            string SediLaKganya = null;
            string KganyaDirect = null;
            string KganyaKoloi = null;
            string Bursary = null;

            if (chckSediLakganya.Checked == true)
            {
                SediLaKganya = "YES";
            }
            else if (chckKganyaDirect.Checked == false)
            {
                SediLaKganya = "No";

            }
            //
            if (chckKganyaDirect.Checked == true)
            {
                KganyaDirect = "YES";
            }
            else if(chckKganyaDirect.Checked  == false)
            {
                KganyaDirect = "No";

            }
            //
            if (chkKganyaK.Checked == true)
            {
                KganyaKoloi = "YES";
            }
            else if (chkKganyaK.Checked == false)
            {
                KganyaKoloi = "No";

            }
            //
            if (chckBursaryHolder.Checked == true)
            {
                Bursary = "YES";
            }
            else if (chckBursaryHolder.Checked == false)
            {
                Bursary = "No";

            }
            //
            //if (txtMemberSurname.Text.Trim() == "" && txtMemberFirstname.Text.Trim() == "" && txtMemberLastname.Text.Trim() == "" && txtMemberIdnumber.Text.Trim() == "" || datePickerDoBMember.Text.Trim() == "" && memberGender == null && txtMemberCellNumber.Text.Trim() == "" && txtMemberAltNumber.Text.Trim() == "" && txtAddress.Text.Trim() == "" && dateDateOfBaptizim.Text.Trim() == "" && dateTimeChildDateEntered.Text.Trim() == "" && txtMembershipNo.Text.Trim().ToString() == "")
            //{
            //    if (txtBenSurname.Text.Trim() == "" && txtChildFirstname.Text.Trim() == "" && txtBenOthername.Text.Trim() == "" && txtbenIdNo.Text.Trim() == "" && txtBenCellNo.Text.Trim() == "" && txtBenAltNo.Text.Trim() == "")
            //    {
            //        if (txtChurchName.Text.Trim() == "" && dateTimeAmend.Text.Trim() == "" && txtAmendNo.Text.Trim() == "")
            //        {
            //            if (txtChurchName.Text == "" && dateTimeAmend.Text == "")
            //            {
            //                if (txtChildSurname.Text == "" && txtChildFirstname.Text == "" && txtChildOthername.Text == "" && dateTimeChildDoB.Text == "" && DependentGender == "")
            //                {
            //                    MessageBox.Show("missing data unsuccessfuly...!");

            //                }
            //            }

            //        }

            //    }


            //}
            //else
            {
                //checking which gender was selected by user
                if (rBtnMale.Checked == true)
                {
                    memberGender = "Male";
                }
                else if (rBtnFemale.Checked)
                {
                    memberGender = "Female";

                }

                //beneficiary gender checking
                string kganyaMember = "";
                if(rbtnKganya.Checked == true)
                {
                    kganyaMember = "Yes";
                }
                else if ( rbtnNonKganya.Checked)
                {
                        kganyaMember = "No";

                }
                //beneficiary Dependant checking
                if (rbtnDepMale.Checked)
                {
                    DependentGender = "Male";
                }
                else if (rbtnDepFemale.Checked)
                {
                    DependentGender = "Female";

                }

                //int memberId =Int32.Parse( lblMemberId.Text);
                //if (memberId == 0)
                //{
                    
                //}
                try
                {
                    //not the best practice to include database this way 
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";
                    conn.Open();

                    //////////////string inputCellNo = ;
                    //////////////int MemberCellNumber = 0;
                    //////////////MemberCellNumber = Convert.ToInt32(inputCellNo);
                    //member table data insertion
                    String my_querry = @"INSERT INTO tblMembers([surname],[firstname],[lastname],[IdentityNo],[DoB],[gender],[cellNo],[AlternativeNo],[residentialAddress],[DateOfBaptizim],[datejoined],[membershipNo],[positon],[Status],[kganyaMember],[SediLakganya],[KganyaDirect],[KganyaKoloi],[Bursary])"
                        + "VALUES('" + txtMemberSurname.Text.Trim().ToUpper() + "','" + txtMemberFirstname.Text.Trim().ToUpper() + "','" + txtMemberLastname.Text.Trim().ToUpper() + "','" + txtMemberIdnumber.Text.Trim()
                        + "','" + datePickerDoBMember.Text.Trim() + "','" + memberGender.ToUpper() + "','" + txtMemberCellNumber.Text.Trim().ToUpper() + "','" + txtMemberAltNumber.Text.Trim().ToUpper() + "','" + txtAddress.Text.Trim().ToUpper() + "','" + dateDateOfBaptizim.Text.Trim() + "','" + dateTimeChildDateEntered.Text.Trim() + "','" + txtMembershipNo.Text.Trim().ToString().ToUpper() + "','" + cmbPosition.SelectedItem.ToString().ToUpper() + "','" + cmbEmpStatus.SelectedItem.ToString().ToUpper() + "','" + kganyaMember.ToUpper() + "','" + SediLaKganya.ToUpper() + "','" + KganyaDirect.ToUpper() + "','" + KganyaKoloi.ToUpper() + "','" + Bursary.ToUpper() + "')";
                    OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                    cmd.ExecuteNonQuery();
                    ////////////////////
                    String my_querryBen = @"INSERT INTO tblBeneficiary([benSurname],[benfirstName],[benOtherName],[benIdentityNo],[benCellNo],[benAltNo])"
                       + "VALUES('" + txtBenSurname.Text.Trim().ToUpper() + "','" + txtBenFirstname.Text.Trim().ToUpper() + "','" + txtBenOthername.Text.Trim().ToUpper() + "','" + txtbenIdNo.Text.Trim() + "','" + txtBenCellNo.Text + "','" + txtBenAltNo.Text + "')";


                    OleDbCommand cmdBen = new OleDbCommand(my_querryBen, conn);
                    cmdBen.ExecuteNonQuery();
                    ////////////////////
                    String my_querryAmend = @"INSERT INTO tblAmendment([AmendChurchName],[DateOfAmend],[AmendmentNo])"
                      + "VALUES('" + txtChurchName.Text.Trim() + "','" + dateTimeAmend.Text + "','" + txtAmendNo.Text + "')";
                    OleDbCommand cmdAmend = new OleDbCommand(my_querryAmend, conn);
                    cmdAmend.ExecuteNonQuery();
                    ////////////////////
                    String my_querryChurch = @"INSERT INTO tblChurch([churchName],[churchCode]) VALUES('" + txtChurchName.Text.Trim().ToUpper() + "','" + dateTimeAmend.Text + "')";
                    OleDbCommand cmdChurch = new OleDbCommand(my_querryChurch, conn);
                    cmdChurch.ExecuteNonQuery();
                    /////////////
                    String my_querryDependant = @"INSERT INTO tblDependant([surname],[firstName],[lastName],[DoB],[gender])"
                       + "VALUES('" + txtChildSurname.Text.Trim().ToUpper() + "','" + txtChildFirstname.Text.Trim().ToUpper() + "','" + txtChildOthername.Text.Trim().ToUpper() + "','" + dateTimeChildDoB.Text + "','" + DependentGender.Trim().ToUpper() + "')";

                    OleDbCommand cmdDep = new OleDbCommand(my_querryDependant, conn);
                    cmdDep.ExecuteNonQuery();

                    MessageBox.Show("Data saved successfuly...!");
                    ///clear textboxes
                    ///
                    txtMemberSurname.Text.Trim().ToUpper() ;
                    txtMemberFirstname.Clear();
                    txtMemberLastname.Clear();
                    txtMemberIdnumber.Clear();
                    datePickerDoBMember.ResetText();
                    memberGender ="";
                    txtMemberCellNumber.Clear();
                    txtMemberAltNumber.Clear();
                    txtAddress.Clear();
                    dateDateOfBaptizim.ResetText();
                    dateTimeChildDateEntered.Text.Trim();
                    txtMembershipNo.Clear();
                    cmbPosition.SelectedItem.ToString();
                    cmbEmpStatus.SelectedItem.ToString();
                    kganyaMember = "";
                    ////
                    txtBenSurname.Clear();
                    txtChildFirstname.Clear();
                    txtBenOthername.Clear();
                    txtbenIdNo.Clear();
                    txtBenCellNo.Clear();
                    txtBenAltNo.Clear();
                    ////
                    txtChurchName.Text.Trim();
                    dateTimeAmend.ResetText(); 
                    txtAmendNo.Clear();
                    ///
                    txtChildSurname.Clear();
                    txtChildFirstname.Clear();
                    txtChildOthername.Clear();
                    dateTimeChildDoB.ResetText();
                    DependentGender="";
                  // cmdDep.Dispose();
                   

                  conn.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(" " + ex);
                }
            }

            }
           

        private void txtMemberSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBenSurname_Validating(object sender, CancelEventArgs e)
        {
            if (txtBenSurname.Text.Trim() == "")
            {
                errorProvider1.SetError(txtBenSurname, "Name is required");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProvider1.Clear();
            }


        }
        //validating Church Name textbox
        private void txtChurchName_Validating(object sender, CancelEventArgs e)
        {
            if (txtChurchName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtChurchName, "Church Name is required");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

        }
        //validating Membership textbox
        private void txtMembershipNo_Validating(object sender, CancelEventArgs e)
        {
            string pattern = "[^0-9]";
            if (txtChurchName.Text.Trim() == "")
            {

                if (!(Regex.IsMatch(txtMembershipNo.Text, pattern)))
                {
                    errorProvider2.SetError(txtMembershipNo, "Invaild Membership Number");
                    e.Cancel = true;
                    return;

                }
                else
                {
                    errorProvider2.Clear();
                }

            }
            else if (Regex.IsMatch(txtMembershipNo.Text, pattern))
            {
                errorProvider2.SetError(txtMembershipNo, "Ivaild Membership Number");
                e.Cancel = true;
                return;

            }
            else
            {
                errorProvider2.Clear();
            }

        }
        //validating Church Code textbox
        private void txtChurchCode_Validating(object sender, CancelEventArgs e)
        {
            if (txtChurchCode.Text.Trim() == "")
            {
                errorProvider3.SetError(txtChurchCode, "Church Code is required");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProvider3.Clear();
            }
        }
        //validating Member Surname textbox
        private void txtMemberSurname_Validating(object sender, CancelEventArgs e)
        {
            if (txtMemberSurname.Text.Trim() == "")
            {
                errorProvider4.SetError(txtMemberSurname, "Member Surname is required");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProvider4.Clear();

            }
        }
        //validating Member Firstname textbox
        private void txtMemberFirstname_Validating(object sender, CancelEventArgs e)
        {
            if (txtMemberFirstname.Text.Trim() == "")
            {
                errorProvider5.SetError(txtMemberFirstname, "Member Firstname is required");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProvider5.Clear();

            }
        }

        private void txtMemberLastname_Validating(object sender, CancelEventArgs e)
        {
            if (txtMemberLastname.Text.Trim() == "")
            {
                errorProvider6.SetError(txtMemberLastname, "Member Lastname is required");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProvider6.Clear();

            }
        }

        private void datePickerDoBMember_Validating(object sender, CancelEventArgs e)
        {
            DateTime dob;
            if (!DateTime.TryParse(datePickerDoBMember.Text, out dob))
            {
                errorProvider9.SetError(datePickerDoBMember, "Date/time must be required");
                e.Cancel = true;
                return;
            }
            if (dob > DateTime.Now.AddYears(-16))
            {
                errorProvider9.SetError(datePickerDoBMember, "Member Must be above 16 years or older!");

            }
            errorProvider9.Clear();
        }

        private void txtMemberIdnumber_Validating(object sender, CancelEventArgs e)
        {
            Regex validateID = new Regex("[^0-9]");
            string match = validateID.Match(txtMemberIdnumber.Text).Value.ToString();
            //


            if (txtMemberIdnumber.Text.Trim() == "")
            {
                errorProvider7.SetError(txtMemberIdnumber, "Member Id is required");
                e.Cancel = true;
                return;
            }
            else
            {
                if (match.Length == 13)
                {
                    errorProvider7.SetError(txtMemberIdnumber, "ID number Must be 13 numbers");
                    e.Cancel = true;
                    return;
                }

                errorProvider7.Clear();

            }

        }

        private void txtMemberIdnumber_TextChanged(object sender, EventArgs e)
        {
            //Regex validateID = new Regex("[^0-9]");
            //string match = validateID.Match(txtMemberIdnumber.Text).Value.ToString();
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddress.Text.Trim() == "")
            {
                errorProvider10.SetError(txtAddress, "Member Home Address is required");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProvider10.Clear();

            }
        }

        private void txtMemberCellNumber_Validating(object sender, CancelEventArgs e)
        {
            Regex validateID = new Regex("[^0-9]");
            string match = validateID.Match(txtMemberCellNumber.Text).Value.ToString();
            //


            if (txtMemberCellNumber.Text.Trim() == "")
            {
                errorProvider11.SetError(txtMemberCellNumber, "Member Cell Number is required");
                e.Cancel = true;
                return;
            }
            else
            {
                if (match.Length == 10)
                {
                    errorProvider11.SetError(txtMemberCellNumber, "Member Cell number Must be 10 numbers");
                    e.Cancel = true;
                    return;
                }

                errorProvider11.Clear();

            }

        }

        private void txtMemberAltNumber_Validating(object sender, CancelEventArgs e)
        {
            Regex validateID = new Regex("[^0-9]");
            string match = validateID.Match(txtMemberAltNumber.Text).Value.ToString();
            //


            if (txtMemberAltNumber.Text.Trim() == "")
            {
                errorProvider12.SetError(txtMemberAltNumber, "Member Altenative Cell Number is required");
                e.Cancel = true;
                return;
            }
            else
            {
                if (match.Length == 10)
                {
                    errorProvider12.SetError(txtMemberAltNumber, "Member Cell Altenative number Must be 10 numbers");
                    e.Cancel = true;
                    return;
                }

                errorProvider12.Clear();

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lietz\Documents\churchDatabase.mdb");

            //    try
            //    {

            //        con.Open();
            //        DataSet ds = new DataSet();
            //        OleDbDataAdapter sdr = new OleDbDataAdapter("select * from tblMembers WHERE [membershipNo] like ('" + txtSearch.Text.Trim() + "')", con);
            //        sdr.Fill(ds);
            //        dataGridView1.DataSource = ds.Tables[0];
            //    }
            //    catch (OleDbException ex)
            //    {
            //        MessageBox.Show(" " + ex);

            //    }
            //    finally
            //    {
            //        con.Close();

            //    }
        }

        private void txtBenFirstname_Validating(object sender, CancelEventArgs e)
        {
            if (txtBenFirstname.Text.Trim() == "")
            {
                errorProviderBenFname.SetError(txtBenFirstname, "Beneficiary  is required");
                e.Cancel = true;
                return;

            }
            else
            {
                errorProviderBenFname.Clear();

            }
        }

        private void txtbenIdNo_Validating(object sender, CancelEventArgs e)
        {
            Regex validateID = new Regex("[^0-9]");
            string match = validateID.Match(txtbenIdNo.Text).Value.ToString();
            //


            if (txtbenIdNo.Text.Trim() == "")
            {
                errorProviderDob.SetError(txtbenIdNo, "Member Id is required");
                e.Cancel = true;
                return;
            }
            else
            {
                if (match.Length == 13)
                {
                    errorProviderDob.SetError(txtbenIdNo, "ID number Must be 13 numbers");
                    e.Cancel = true;
                    return;
                }

                errorProviderDob.Clear();

            }
        }

        private void dateTimeBenDoB_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtBenCellNo_Validating(object sender, CancelEventArgs e)
        {

            Regex validateID = new Regex("[^0-9]");
            string match = validateID.Match(txtBenCellNo.Text).Value.ToString();
            //

            if (txtBenCellNo.Text.Trim() == "")
            {
                errorProviderCellNo.SetError(txtBenCellNo, "Member  Cell Number is required");
                e.Cancel = true;
                return;
            }
            else
            {
                if (match.Length == 10)
                {
                    errorProviderCellNo.SetError(txtBenCellNo, "Member Cell  number Must be 10 numbers");
                    e.Cancel = true;
                    return;
                }

                errorProviderCellNo.Clear();

            }
        }

        private void txtBenAltNo_Validating(object sender, CancelEventArgs e)
        {

            Regex validateID = new Regex("[^0-9]");
            string match = validateID.Match(txtBenAltNo.Text).Value.ToString();
            //

            if (txtBenAltNo.Text.Trim() == "")
            {
                errorProviderCellAlt.SetError(txtBenAltNo, "Member  Cell Number is required");
                e.Cancel = true;
                return;
            }
            else
            {
                if (match.Length == 10)
                {
                    errorProviderCellAlt.SetError(txtBenAltNo, "Member Cell  number Must be 10 numbers");
                    e.Cancel = true;
                    return;
                }

                errorProviderCellAlt.Clear();

            }
        }

        private void txtAmendChurchName_Validating(object sender, CancelEventArgs e)
        {

            if (txtAmendChurchName.Text.Trim() == "")
            {
                errorProviderChurchname.SetError(txtAmendChurchName, "Beneficiary  is required");
                e.Cancel = true;
                return;

            }
            else
            {
                errorProviderChurchname.Clear();

            }
        }

        private void btnAddMember_Validating(object sender, CancelEventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void kganya_Load(object sender, EventArgs e)
        {
            btnAddMember.Enabled = false;
            
        }

        private void chckNonKganya_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {

        }

        private void rbtnNonKganya_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNonKganya.Checked == true )
            {
                tabBeneficiary.Enabled = false;
                tabDependant.Enabled = true;
                btnAddMember.Enabled = true;
                txtMembershipNo.Enabled = false;
            }
            else if (rbtnKganya.Checked == true)
            {
                tabBeneficiary.Enabled = true;
                tabDependant.Enabled = true;
                txtMembershipNo.Enabled = true;
            }
        }

        private void btnAddAnotherC_Click(object sender, EventArgs e)
        {
            //beneficiary Dependant checking
            string DependentGenderOther ="";
            if (radioBtnMale.Checked)
            {
                DependentGenderOther = "Male";
            }
            else if (radioBtnFemale.Checked)
            {
                DependentGenderOther = "Female";

            }
            try
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";
                conn.Open();
                String my_querryDependant = @"INSERT INTO tblDependant([surname],[firstName],[lastName],[DoB],[gender])"
                       + "VALUES('" + txtChildSurname.Text.Trim().ToUpper() + "','" + txtChildFirstname.Text.Trim().ToUpper() + "','" + txtChildOthername.Text.Trim().ToUpper() + "','" + dateTimeChildDoB.Text + "','" + DependentGenderOther.Trim().ToUpper() + "')";

                OleDbCommand cmdDep = new OleDbCommand(my_querryDependant, conn);
                cmdDep.ExecuteNonQuery();
                txtChildSurname.Text ="" ;
                txtChildFirstname.Text ="" ;
                txtChildOthername.Text="";
                dateTimeChildDoB.Text ="" ;
                DependentGenderOther ="" ;
            }catch(OleDbException ex){
                MessageBox.Show(" " + ex);

            }
        }

    }
}