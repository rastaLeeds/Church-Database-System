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
    public partial class BarutiForm : Form
    {
        public BarutiForm()
        {
            InitializeComponent();
        }

        

        private void btnAddMoruti_Click(object sender, EventArgs e)
        {
            string fname = txtSearchMoruti.Text.Trim();
            string Surname = txtMorutiSurname.Text.Trim();
            string kganyaNo = txtKganyaBookNo.Text.Trim();
            string ContactNo = txtMorutiContactNo.Text.Trim();
            string resAddress = txtMorutiResAddress.Text.Trim();
            string ChurchPostion =cmbMorutiPosition.SelectedItem.ToString();
            string DateBaptisim = dateTimePickerDOBap.Text.ToString();
            string occup = cmbMorutiOccup.SelectedItem.ToString();
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

                    String my_querry = @"INSERT INTO tblBaruti
                         (BName, BSurname, BPostion, BBaptisimDate, BKganyaBookNo, BContactNo, BResAddress, BOccupatio)
                         VALUES('" + fname + "', '" + Surname + "', '" + ChurchPostion + "', '" + DateBaptisim + "', '" + kganyaNo + "', '" + ContactNo + "', '" + resAddress + "', '" + occup + "')";


                    OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Moruti Added Sucessfully", "Added Success");
                    //
                    txtSearchMoruti.Clear();
                    txtMorutiSurname.Clear();
                    txtKganyaBookNo.Clear();
                    txtMorutiContactNo.Clear();
                    txtMorutiResAddress.Clear();
                    dateTimePickerDOBap.Text = "";
                    cmbMorutiOccup.SelectedItem = "select";
                    conn.Close();
                   

                    

                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Failed to connect to data source" + ex);
                }


           // }
           ////
           // MessageBox.Show("Nothing Added Please Insert data");
        }

        private void BarutiForm_Load(object sender, EventArgs e)
        {
            //dataGridViewBaruti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewBaruti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBaruti.MultiSelect = true;
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT BName AS Name, BSurname AS Surname, BPostion AS [Position],
                         BBaptisimDate AS [Baptisim Date], BKganyaBookNo AS [Kganya Book No], BContactNo AS [Contact No], BResAddress AS [Home Address], 
                         BOccupatio AS Occupation FROM tblBaruti", con);
                sdr.Fill(ds);
                //
                dataGridViewBaruti.DataSource = ds.Tables[0];
                int countBomme = dataGridViewBaruti.Rows.Count;
                countBomme = countBomme - 1;
                lblTotalNumOfBaruti.Text = countBomme.ToString();
                con.Close();
                ds.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dataGridViewBaruti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewBaruti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBaruti.MultiSelect = true;
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT BName AS Name, BSurname AS Surname, BPostion AS [Position],
                         BBaptisimDate AS [Baptisim Date], BKganyaBookNo AS [Kganya Book No], BContactNo AS [Contact No], BResAddress AS [Home Address], 
                         BOccupatio AS Occupation FROM tblBaruti", con);
                sdr.Fill(ds);
                //
                dataGridViewBaruti.DataSource = ds.Tables[0];
                int countBomme = dataGridViewBaruti.Rows.Count;
                countBomme = countBomme - 1;
                dataGridViewBaruti.Text = countBomme.ToString();
                con.Close();
                ds.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
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
            for (int i = 1; i < dataGridViewBaruti.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewBaruti.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewBaruti.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewBaruti.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewBaruti.Rows[i].Cells[j].Value;
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

        private void dataGridViewBaruti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMorutiSurname.Text = dataGridViewBaruti[1, e.RowIndex].Value.ToString();
            txtKganyaBookNo.Text = dataGridViewBaruti[4, e.RowIndex].Value.ToString();
            txtMorutiContactNo.Text = dataGridViewBaruti[5, e.RowIndex].Value.ToString();
            txtMorutiResAddress.Text = dataGridViewBaruti[6, e.RowIndex].Value.ToString();
      //  dateTimePickerDOBap.Text = dataGridViewBaruti[4, e.RowIndex].Value;
            cmbMorutiPosition.Text = dataGridViewBaruti[2, e.RowIndex].Value.ToString();
            cmbMorutiOccup.SelectedItem = dataGridViewBaruti[7, e.RowIndex].Value;
        }

        private void btnSearchMoruti_Click(object sender, EventArgs e)
        {
            dataGridViewBaruti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewBaruti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBaruti.MultiSelect = true;
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT BName AS Name, BSurname AS Surname, BPostion AS [Position],
                         BBaptisimDate AS [Baptisim Date], BKganyaBookNo AS [Kganya Book No], BContactNo AS [Contact No], BResAddress AS [Home Address], 
                         BOccupatio AS Occupation FROM tblBaruti WHERE [BSurname] like('"+txtSearchMoruti.Text.Trim() + "')", con);
                sdr.Fill(ds);
                //
                dataGridViewBaruti.DataSource = ds.Tables[0];
                int countBomme = dataGridViewBaruti.Rows.Count;
                countBomme = countBomme - 1;
                dataGridViewBaruti.Text = countBomme.ToString();
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

