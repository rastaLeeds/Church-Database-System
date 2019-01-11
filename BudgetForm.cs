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
    public partial class BudgetForm : Form
    {
        public BudgetForm()
        {
            InitializeComponent();
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            //BudgetReportForm brf = new BudgetReportForm();
            //brf.Show();

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
            for (int i = 1; i < dataGridViewBudget.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewBudget.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewBudget.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewBudget.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewBudget.Rows[i].Cells[j].Value;
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

        private void btnSubmitIncome_Click(object sender, EventArgs e)
        {
            //
            string sourceOfIncome = cmbSourceOfIncome.SelectedItem.ToString() ;
              double IncomeAmount =   double.Parse(txtIncomeAmount.Text);

          string DateOfIncomefrom = dateTimePickerIncomeFrom.Text;
          string DateOfIncomeTo = dateTimePickerIncomeTo.Text;

          //double Subtotal = 0.0;
          //Subtotal = 0 + IncomeAmount;
          string TotalIncome = "R " + IncomeAmount;
          //  
          //not the best practice to include database this way 
          OleDbConnection conn = new OleDbConnection();
          conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";
          conn.Open();
          try
          {

              //member table data insertion
              String my_querry = @"INSERT INTO tblIncome  (Source, IncomeAmount, IncomePeriodFrom, IncomePeriodTo, TotalIncome)
                                  VALUES('" + sourceOfIncome + "', '" + IncomeAmount + "', '" + DateOfIncomefrom + "', '" + DateOfIncomeTo + "', '" + TotalIncome.ToString() + "')";
              OleDbCommand cmd = new OleDbCommand(my_querry, conn);
              cmd.ExecuteNonQuery();

              MessageBox.Show(" Succesfully Added");
              txtIncomeAmount.Text = "";
              cmbSourceOfIncome.Text = "";
              //
              cmd.Dispose();
          }
          catch (OleDbException ex)
          {
              MessageBox.Show(" " + ex.Message);
              conn.Close();

          }
          finally
          {
              conn.Close();
          }
        }

        private void btnAddHlono_Click(object sender, EventArgs e)
        {
            string DonationSource = txtDonationSource.Text.Trim();
            double DonatedAmount = double.Parse(txtDonationAmount.Text);
            string PeriodOfDonationFrom = dateTimePickerDonationPeriodFrm.Text;
            string PeriodOfDonationTo = dateTimePickerPeriodTo.Text;
            double totalDonated = 00.00;

            string TotalDonated = "R " + DonatedAmount;
            //not the best practice to include database this way 
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";
            conn.Open();
            try
            {
            totalDonated =+ DonatedAmount;
             //member table data insertion
            String my_querry = @"INSERT INTO tblDonation
                         (DonationSource, DonationAmount, DonationPeriodFrom, DonationPeriodTo, TotalDonation)
                          VALUES ('" + DonationSource + "', '" + DonatedAmount + "', '" + PeriodOfDonationFrom + "', '" + PeriodOfDonationTo + "', '" + TotalDonated.ToString() + "')";
              OleDbCommand cmd = new OleDbCommand(my_querry, conn);
              cmd.ExecuteNonQuery();
              MessageBox.Show(" Succesfully Added");
              txtDonationSource.Text = "";
              txtDonationAmount.Text = "";
              //
              cmd.Dispose();
          }
          catch (OleDbException ex)
          {
              MessageBox.Show(" " + ex);
              conn.Close();

          }
          finally
          {
              conn.Close();
          }

        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            string expDescreption = txtExpdecript.Text.ToString();
            double expAmount = double.Parse(txtExpAmount.Text);
            string ExpPeriodFrom = dateTimePickerExpPeriodFrom.Text;
            string expPeriodTo = dateTimePickerExpPeriodTo.Text;

            double Totalexp = 00.00;

            Totalexp = + expAmount;
            string TotalExpediture = "R " + expAmount; 
            //not the best practice to include database this way 
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";
            conn.Open();
            try
            {
                 //member table data insertion
                String my_querry = @"INSERT INTO tblExpenditure
                         (ExpDescrip, ExpAmount, ExpPeriodFrom, ExpPeriodTo, TotalExp)
                          VALUES ('" + expDescreption + "', '" + expAmount + "', '" + ExpPeriodFrom + "', '" + expPeriodTo + "', '" + TotalExpediture.ToString() + "')";
                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Expenditure Added Succesfully ");
                txtDonationSource.Text = "";
                txtDonationAmount.Text = "";
                //
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(" " + ex);
                conn.Close();

            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDisplayBudgetRecords_Click(object sender, EventArgs e)
        {
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT tblIncome.Source, tblIncome.IncomeAmount, tblIncome.IncomePeriodFrom, tblIncome.IncomePeriodTo, tblIncome.TotalIncome, tblDonation.Donation_ID, tblDonation.DonationSource, tblDonation.DonationAmount, 
                         tblDonation.DonationPeriodFrom, tblDonation.DonationPeriodTo, tblDonation.TotalDonation, tblExpenditure.Expenditure_ID, tblExpenditure.ExpDescrip, tblExpenditure.ExpAmount, tblExpenditure.ExpPeriodFrom, 
                         tblExpenditure.ExpPeriodTo FROM tblIncome, tblDonation, tblExpenditure", con);
                         
                sdr.Fill(ds);
                dataGridViewBudget.DataSource = ds.Tables[0];
                con.Close();
                ds.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }

        private void BudgetForm_Load(object sender, EventArgs e)
        {
            dataGridViewBudget.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBudget.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBudget.MultiSelect = false;

        }

        private void Delete(int incomeId)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";
            string sql = @"DELETE FROM tblIncome WHERE (tblIncome.Income_ID =" + incomeId + ")";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            try {
                con.Open();
                OleDbDataAdapter adpt = new OleDbDataAdapter(cmd);
                adpt.DeleteCommand = con.CreateCommand();
                adpt.DeleteCommand.CommandText = sql;
                if (MessageBox.Show("Are you sure you want to delete?","DELETE",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning )== DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("deleted Successful");
                        cmd.Dispose();
                        adpt.Dispose();
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("unSuccessful");
                    con.Close();

                }
            
            }catch(OleDbException ex){
                MessageBox.Show( ex.Message);
                con.Close();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
           //d
           // Delete(0);


        }
    }
    


}

