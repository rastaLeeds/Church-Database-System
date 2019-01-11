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
    public partial class SubBranches : Form
    {
        public SubBranches()
        {
            InitializeComponent();
        }

        private void btnAddMoruti_Click(object sender, EventArgs e)
        {
            string fname = txtSubMorutiName.Text.Trim();
            string Surname = txtSubMorutiSurname.Text.Trim();
            string kganyaNo = txtSubKganyaBookNo.Text.Trim();
            string ContactNo = txtSubMorutiContactNo.Text.Trim();
            string resAddress = txtSubMorutiResAddress.Text.Trim();
            string ChurchPostion = cmbSubMorutiPosition.SelectedItem.ToString();
            string DateBaptisim = dateTimePickerSubDOBap.Text.ToString();
            string occup = cmbSubMorutiOccup.SelectedItem.ToString();
            string SubBranchName = cmbSubBranchName.SelectedItem.ToString();
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

                String my_querry = @"INSERT INTO tblSubBranchesBaruti
                         (SubBName, SubBSurname, SubBPosition, SubBBaptismDate, SubBKganyaBookNo, SubBContactNo, SubBResAddress, SubBOccupation, SubBBranchName)
                         VALUES('" + fname + "', '" + Surname + "', '" + ChurchPostion + "', '" + DateBaptisim + "', '" + kganyaNo + "', '" + ContactNo + "', '" + resAddress + "', '" + occup + "', '" + SubBranchName + "')";


                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Moruti Added Sucessfully", "Added Success");
                //
                txtSubMorutiName.Text = "".Trim();
                txtSubMorutiSurname.Text = "".Trim();
                txtSubKganyaBookNo.Text = "".Trim();
                txtSubMorutiContactNo.Text = "".Trim();
                txtSubMorutiResAddress.Text = "".Trim();
                cmbSubMorutiPosition.Text = "".Trim();
                dateTimePickerSubDOBap.Text = "".ToString();
                cmbSubMorutiOccup.Text = "".Trim();
                cmbSubBranchName.Text = "".Trim();
                conn.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Failed to connect to data source" + ex);
            }
        }

        private void btnDisplaySubMoruti_Click(object sender, EventArgs e)
        {

            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT SubBName AS Name, SubBSurname AS Surname, 
                         SubBPosition AS [Position], SubBBaptismDate AS [Date Of Baptisim], SubBKganyaBookNo AS [Kganya Book No], SubBContactNo AS [Conctact No], 
                         SubBResAddress AS [Home Addresss], SubBOccupation AS Occupation, SubBBranchName AS [Sub Branch Name]
                        FROM tblSubBranchesBaruti", con);
                sdr.Fill(ds);
                //
                dataGridViewSubBaruti.DataSource = ds.Tables[0];
                int countBomme = dataGridViewSubBaruti.Rows.Count;
                countBomme = countBomme - 1;
                lblTotalNumOfSubBaruti.Text = countBomme.ToString();
                con.Close();
                ds.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }

        private void btnDisplySubMoruti_Click(object sender, EventArgs e)
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
            for (int i = 1; i < dataGridViewSubBaruti.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewSubBaruti.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewSubBaruti.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewSubBaruti.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewSubBaruti.Rows[i].Cells[j].Value;
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
            for (int i = 1; i < dataGridViewSubMasogoana.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewSubMasogoana.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewSubMasogoana.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewSubMasogoana.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewSubMasogoana.Rows[i].Cells[j].Value;
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

       

        private void btnDisplaySubMa_Click(object sender, EventArgs e)
        {
            dataGridViewSubMasogoana.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewSubMasogoana.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSubMasogoana.MultiSelect = true;
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT SubBMaName AS Name, SubBMaSurname AS Surname, SubBMaPosition AS Postion, SubBMaBaptismDate AS [Date Of Baptisim], SubBMaKganyaBookNo AS [Kganya Book No], 
                          SubBMaContactNo AS [Contact No], SubBMaResAddress AS [Home Address], SubBMaOccupation AS Occupation, SubBMaBranchName AS [Branch Name]
                          FROM tblSubBranchesMasogoana", con);
                sdr.Fill(ds);
                //
                dataGridViewSubMasogoana.DataSource = ds.Tables[0];
                int countBomme = dataGridViewSubMasogoana.Rows.Count;
                countBomme = countBomme - 1;
                lblTotalSubMa.Text = countBomme.ToString();
                con.Close();
                ds.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }

        private void btnAddSubMasogoana_Click(object sender, EventArgs e)
        {

            string fname = txtSubMasogoanaName.Text.Trim();
            string Surname = txtSubMasogoanaSurname.Text.Trim();
            string ChurchPostion = cmbSubMasogoanaPosition.Text;
            string kganyaNo = txtSubMasogoanaKganyaBookNo.Text.Trim();
            string DateBaptisim = dateTimePickerSubMasogoanaDOBap.Text.ToString();
            string ContactNo = txtSubMasogoanaContactNo.Text.Trim();
            string SubMaBranchName = cmbMaSubBranchName.Text.Trim();
            string resAddress = txtSubMasogoanaResAddress.Text.Trim();
            string occup = cmbSubMasogoanaOccup.SelectedItem.ToString();
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

                String my_querry = @"INSERT INTO tblSubBranchesMasogoana
                         (SubBMaName, SubBMaSurname, SubBMaPosition, SubBMaBaptismDate, SubBMaKganyaBookNo, SubBMaContactNo, SubBMaResAddress, SubBMaOccupation, SubBMaBranchName)
                         VALUES('" + fname + "', '" + Surname + "', '" + ChurchPostion + "', '" + DateBaptisim + "', '" + kganyaNo + "', '" + ContactNo + "','" + resAddress + "', '" + occup + "', '" + SubMaBranchName + "')";


                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Added Sucessfully", "Added Success");
                //
                txtSubMasogoanaName.Text = "".Trim();
                txtSubMasogoanaSurname.Text = "".Trim();
                cmbSubMasogoanaPosition.Text = "";
                txtSubMasogoanaKganyaBookNo.Text = "".Trim();
                // 
                txtSubMasogoanaContactNo.Text = "".Trim();
                resAddress = txtSubMasogoanaResAddress.Text = "".Trim();
                occup = cmbSubMasogoanaOccup.Text = "";
                cmbMaSubBranchName.Text = "".Trim();
                //
                cmd.Dispose();
                conn.Close();
            }
            catch (OleDbException ex)
            {
                //
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void btnAddSubBomme_Click(object sender, EventArgs e)
        {

            string fname = txtSubMmeName.Text.Trim();
            string Surname = txtSubMmeSurname.Text.Trim();
            string kganyaNo = txtSubMmeKganyaBookNo.Text.Trim();
            string ContactNo = txtSubMmeConactNo.Text.Trim();
            string resAddress = txtSubMmeResAddress.Text.Trim();

            //

            //
            string ChurchPostion = cmbSubMmePosition.SelectedItem.ToString();
            string DateBaptisim = dateTimePickeSubMmeDOBap.Text.ToString();
            string occup = cmbSubMmeOccup.SelectedItem.ToString();
            string SubBommeBranchName = cmbMaSubBranchName.Text;
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
                String my_querry = @"INSERT INTO tblSubBomme (SubBoMmeName, SubBoMmeSurname, SubBoMmePositionAtChurch, SubBoMmeKganyaBookNo, SubBoMmeBaptism, SubBoMmeContactNo, SubBoMmeResAddress, SubBoMmeOccupation, SubBommeBranchName)
                         VALUES('" + fname + "', '" + Surname + "', '" + ChurchPostion + "', '" + kganyaNo + "', '" + DateBaptisim + "', '" + ContactNo + "', '" + resAddress + "', '" + occup + "','" + SubBommeBranchName + "')";


                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Mme Added Sucessfully", "Added Success");
                //clearing textboxes
                txtSubMmeName.Clear();
                txtSubMmeSurname.Clear();
                txtSubMmeKganyaBookNo.Clear();
                txtSubMmeConactNo.Clear();
                txtSubMmeResAddress.Clear();
                dateTimePickeSubMmeDOBap.Text = "";
                cmbSubMmeOccup.SelectedItem = "select";
                conn.Close();


            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Failed to connect to data source" + ex);
            }
        }

        private void btnExportToExcelSubMme_Click(object sender, EventArgs e)
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
            for (int i = 1; i < dataGridViewSubBoMme.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewSubBoMme.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewSubBoMme.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewSubBoMme.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewSubBoMme.Rows[i].Cells[j].Value;
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

        private void btnSubBommeDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT SubBoMmeName AS Name, SubBoMmeSurname AS Surname, SubBoMmePositionAtChurch AS [Position], SubBoMmeKganyaBookNo AS [Kganya Book No], SubBoMmeBaptism AS [Date Of Baptism], 
                         SubBoMmeContactNo AS [Contact No], SubBoMmeResAddress AS [Home Address], SubBoMmeOccupation AS Occupation, SubBranchName AS [Branch Name]
                        FROM tblSubBomme", con);
                sdr.Fill(ds);
                dataGridViewSubBoMme.DataSource = ds.Tables[0];
                int countBomme = dataGridViewSubBoMme.Rows.Count;
                countBomme = countBomme - 1;
                lblTotalNumOfSubBomme.Text = countBomme.ToString();
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
