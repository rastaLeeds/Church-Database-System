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
    public partial class MasogoanaLeMakgarebeForm : Form
    {
        public MasogoanaLeMakgarebeForm()
        {
            InitializeComponent();
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
            for (int i = 1; i < dataGridViewMasogoana.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewMasogoana.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewMasogoana.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewMasogoana.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewMasogoana.Rows[i].Cells[j].Value;
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

        private void btnAddMasogoana_Click(object sender, EventArgs e)
        {
            string fname = txtMasogoanaName.Text.Trim();
            string Surname = txtMasogoanaSurname.Text.Trim();
            string ChurchPostion = cmbMasogoanaPosition.SelectedItem.ToString(); 
            string kganyaNo = txtMasogoanaKganyaBookNo.Text.Trim();
           string DateBaptisim = dateTimePickerMasogoanaDOBap.Text.ToString();
           string ContactNo = txtMasogoanaContactNo.Text.Trim();
            string EmailAddress = txtMasogoanaEmailAddress.Text.Trim();
            string resAddress = txtMasogoanaResAddress.Text.Trim();
            string occup = cmbMasogoanaOccup.SelectedItem.ToString();
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

                String my_querry = @"INSERT INTO tblMasogoanaLeadership
                         (MName, MSurname, MPosition, MkganyaBookNo, MBaptism, Mcontact, MEmailAddress, MResAddress, MOccupation)
                         VALUES('" + fname + "', '" + Surname + "', '" + ChurchPostion + "', '" + DateBaptisim + "', '" + kganyaNo + "', '" + ContactNo + "','" + EmailAddress + "', '" + resAddress + "', '" + occup + "')";


                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Added Sucessfully", "Added Success");
                //
                txtMasogoanaName.Text ="".Trim();
                txtMasogoanaSurname.Text = "".Trim();
                cmbMasogoanaPosition.Text = "";
               txtMasogoanaKganyaBookNo.Text = "".Trim();
                dateTimePickerMasogoanaDOBap.Text.ToString();
                txtMasogoanaContactNo.Text = "".Trim();
                txtMasogoanaEmailAddress.Text = "".Trim();
                txtMasogoanaResAddress.Text = "".Trim();
                cmbMasogoanaOccup.Text="";
                cmd.Dispose();
                conn.Close();




            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Failed to connect to data source" + ex);
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dataGridViewMasogoana.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewMasogoana.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMasogoana.MultiSelect = true;
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT MName AS Name, MSurname AS Surname, MPosition AS [Position], MkganyaBookNo AS [Kganya Book No],
                         MBaptism AS [Date Of Baptisim], Mcontact AS [Contact No], MEmailAddress AS [Email Address], 
                         MResAddress AS [Home Address], MOccupation AS Occupation
                         FROM tblMasogoanaLeadership", con);
                sdr.Fill(ds);
                //
                dataGridViewMasogoana.DataSource = ds.Tables[0];
                int countBomme = dataGridViewMasogoana.Rows.Count;
                countBomme = countBomme - 1;
                lblTotalNumOfMasogoana.Text = countBomme.ToString();
                con.Close();
                ds.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }

        private void MasogoanaLeMakgarebeForm_Load(object sender, EventArgs e)
        {
            dataGridViewMasogoana.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewMasogoana.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMasogoana.MultiSelect = true;
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT MName AS Name, MSurname AS Surname, MPosition AS [Position], MkganyaBookNo AS [Kganya Book No],
                         MBaptism AS [Date Of Baptisim], Mcontact AS [Contact No], MEmailAddress AS [Email Address], 
                         MResAddress AS [Home Address], MOccupation AS Occupation
                         FROM tblMasogoanaLeadership", con);
                sdr.Fill(ds);
                //
                dataGridViewMasogoana.DataSource = ds.Tables[0];
                int countBomme = dataGridViewMasogoana.Rows.Count;
                countBomme = countBomme - 1;
                lblTotalNumOfMasogoana.Text = countBomme.ToString();
                con.Close();
                ds.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }

        private void btnAddLCDC_Click(object sender, EventArgs e)
        {
             string LcName = txtLcName.Text.Trim();
            string LcSurname = txtLcSurname.Text.Trim();
           string LcContactNo = txtLcContactNo.Text.Trim();
            string LcEmailAddress = txtLcEmailAddress.Text.Trim();
            string LcOccup = cmbLcOccup.Text.ToString();
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

                String my_querry = @"INSERT INTO tblLcdcTechTeam
                         (LcFirstName, LcSurname, LcOccupation, LcContactNo, LcEmailAddress)
                         VALUES('" + LcName + "', '" + LcSurname + "','" + LcOccup + "','" + LcContactNo + "', '" + LcEmailAddress + "')";


                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Added Sucessfully", "Added Success");
                //
                txtLcName.Text = "".Trim();
                txtLcSurname.Text = "".Trim();
                txtLcContactNo.Text = "".Trim();
                txtLcEmailAddress.Text = "".Trim();
                cmbLcOccup.Text = "".Trim();
                cmd.Dispose();
                conn.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void btnViewReFresh_Click(object sender, EventArgs e)
        {
            dataGridViewLCDC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewLCDC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLCDC.MultiSelect = true;
            //\
            //
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            con.Open();
            try
            {
                
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT LcFirstName AS [Names], LcSurname AS Surname, LcOccupation AS Occupation, LcContactNo AS [Contact No], LcEmailAddress AS [Email Address] FROM tblLcdcTechTeam", con);
                sdr.Fill(ds);
                //
                dataGridViewLCDC.DataSource = ds.Tables[0];
                int countLcdc = dataGridViewLCDC.Rows.Count;
                countLcdc = countLcdc - 1;
                lblTotalNumOfLcdc.Text = countLcdc.ToString();
                con.Close();
                ds.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
                con.Close();
            }
        }

        private void btnExptLCDC_Click(object sender, EventArgs e)
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
            for (int i = 1; i < dataGridViewLCDC.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewLCDC.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewLCDC.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewLCDC.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewLCDC.Rows[i].Cells[j].Value;
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

        private void btnAddBai_Click(object sender, EventArgs e)
        {
            string Baifname = txtBaiName.Text.Trim();
            string BaiSurname = txtBaiSurname.Text.Trim();
            string BaiChurchPostion = cmbBaiPosition.SelectedItem.ToString();
            string BaikganyaNo = txtBaiKganyaNo.Text.Trim();
            string BaiDateBaptisim = dateTimePickerBaiDOBap.Text.ToString();
            string BaiContactNo = txtBaiConNo.Text.Trim();
            string BaiEmailAddress = txtBaiEmailAddress.Text.Trim();
            string BairesAddress = txtBaiResAddress.Text.Trim();
            string BaiOccup = cmbBaiOccup.Text.ToString();
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

                String my_querry = @"INSERT INTO tblBaiperekiLeadership
                         (BaiName, BaiSurname, BaiPosition, BaikganyaBookNo, BaiDateOfBaptism, Baicontact, BaiEmailAddress, BaiResAddress, BaiOccupation)
                         VALUES('" + Baifname + "', '" + BaiSurname + "', '" + BaiChurchPostion + "', '" + BaikganyaNo + "', '" + BaiDateBaptisim + "', '" + BaiContactNo + "','" + BaiEmailAddress + "', '" + BairesAddress + "', '" + BaiOccup + "')";


                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Added Sucessfully", "Added Success");
                //
                txtBaiName.Text = "".Trim();
                txtBaiSurname.Text = "".Trim();
                cmbBaiPosition.Text = "";
                txtBaiKganyaNo.Text = "".Trim();
                dateTimePickerBaiDOBap.Text.ToString();
                txtBaiConNo.Text = "".Trim();
                txtBaiEmailAddress.Text = "".Trim();
                txtBaiResAddress.Text = "".Trim();
                cmbBaiOccup.Text = "".Trim();
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

        private void btnExportBai_Click(object sender, EventArgs e)
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
            for (int i = 1; i < dataGridViewBaipereki.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewBaipereki.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewBaipereki.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewBaipereki.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewBaipereki.Rows[i].Cells[j].Value;
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

        private void btnDisplayBai_Click(object sender, EventArgs e)
        {
            dataGridViewBaipereki.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewBaipereki.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBaipereki.MultiSelect = true;
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT BaiName AS Name, BaiSurname AS Surname, BaiPosition AS [Position], BaikganyaBookNo AS [Kganya Book No], BaiDateOfBaptism AS [Date Of Baptisim], Baicontact AS [Contact No], 
                         BaiEmailAddress AS [Email Address], BaiResAddress AS [Home Address], BaiOccupation AS Occupation
                        FROM tblBaiperekiLeadership", con);
                sdr.Fill(ds);
                //
                dataGridViewBaipereki.DataSource = ds.Tables[0];
                int countBaip = dataGridViewBaipereki.Rows.Count;
                countBaip = countBaip - 1;
                lblTotalNoBaipereki.Text = countBaip.ToString();
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
