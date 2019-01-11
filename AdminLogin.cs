using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_DEMO
{
    public partial class AdminLogin : Form 
    {
        
        public AdminLogin()
        {
         // Thread t = new Thread(new ThreadStart(loading));
       //  t.Start();

              InitializeComponent();
//
        //    for (int i = 0; i < 100; i++)
      //      {
       //         Thread.Sleep(10);
      //          t.Abort();
      //      }
            string username = txtUsername.Text.Trim();
            string Password = txtPassword.Text.Trim();
            txtUsername.Select();
            
        }
      //  public void loading()
     //   {
     //       SplashForm f = new SplashForm();
     //       Application.Run(f);
     //   }
       
        private void btnSignup_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtPassRetype.Clear();
            //
            txtRegUsername.Clear();
            txtRegPass.Clear();


        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string Password = txtPassword.Text.Trim();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\churchDatabase.mdb");

            try
            {
                conn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(@"SELECT * FROM tblAdmin WHERE UserName='" + username + "' AND Password='" + Password + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Invaild username or password please try again" );

                }
                else if (dt.Rows.Count > 0)
                {
                    HOMEPAGE homepage = new HOMEPAGE();
                    homepage.Show();
                    this.Hide();

                }

            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Failed to connect to data source" + ex);

            }
            finally
            {
                conn.Close();

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            
            try
            {
                string regUsername = txtRegUsername.Text.Trim();
                string regPass = txtRegPass.Text.Trim();
                string regRetypePass = txtPassRetype.Text.Trim();
                con.Open();
                if (regPass == regRetypePass)
                {
                    //member table data insertion
                    String my_querry = @"INSERT INTO tblAdmin([UserName],[Password])"
                        + "VALUES('" + regUsername + "','" + regPass + "')";

                    OleDbCommand cmd = new OleDbCommand(my_querry, con);
                    cmd.ExecuteNonQuery();
                    //
                    MessageBox.Show("Registered Successfully");

                    txtRegUsername.Clear();
                    txtRegPass.Clear();
                    txtPassRetype.Clear();
                }
                else
                {
                    MessageBox.Show("Password doesnt match please re-enter your password");
                    txtRegPass.Clear();
                    txtPassRetype.Clear();
                }
                

            } catch(OleDbException ex){
                //
                MessageBox.Show(" "+ ex);

            } finally{
                con.Close();
            }
            
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                errorProviderUsername.SetError(txtUsername, "Username is required");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProviderUsername.Clear();

            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Trim() == "")
            {
                errorProviderPass.SetError(txtPassword, "Password is required");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProviderPass.Clear();

            }
        }

        private void txtRegPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtRegPass.Text.Trim() == "")
            {
                errorProviderRegPass.SetError(txtRegPass, "Password is required");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProviderRegPass.Clear();

            }
        }

        private void txtPassRetype_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassRetype.Text.Trim() == "")
            {
                errorProviderRetypeP.SetError(txtPassRetype, "Password is required");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProviderRetypeP.Clear();

            }
        }

        private void txtRegUsername_Validating(object sender, CancelEventArgs e)
        {
            if (txtRegUsername.Text.Trim() == "")
            {
                errorProviderRegUser.SetError(txtRegUsername, "Username is required");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProviderRegUser.Clear();

            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
