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
    public partial class BommeForm : Form
    {
        public BommeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string fname = txtMmeName.Text.Trim();
            string Surname = txtMmeSurname.Text.Trim();
            string kganyaNo = txtMmeKganyaBookNo.Text.Trim();
            string ContactNo = txtMmeConactNo.Text.Trim();
            string resAddress = txtMmeResAddress.Text.Trim();
                string ChurchPostion = cmbMmePosition.SelectedItem.ToString();
                string DateBaptisim = dateTimePickeMmeDOBap.Text.ToString();
                string occup = cmbMmeOccup.SelectedItem.ToString();
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
                    String my_querry = @"INSERT INTO tblBomme (BoName, BoSurname, BoPositionAtChurch, BoKganyaBookNo, BoBaptism, BoContactNo, BoResAddress, BoOccupation)
                         VALUES('" + fname + "', '" + Surname + "', '" + ChurchPostion + "', '" + kganyaNo + "', '" + DateBaptisim + "', '" + ContactNo + "', '" + resAddress + "', '" + occup +"')";
                    

                    OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Mme Added Sucessfully", "Added Success");
                    //clearing textboxes
                    txtMmeName.Clear();
                    txtMmeSurname.Clear();
                    txtMmeKganyaBookNo.Clear();
                    txtMmeConactNo.Clear();
                    txtMmeResAddress.Clear();
                    dateTimePickeMmeDOBap.Text = "";
                    cmbMmeOccup.SelectedItem = "select";
                    conn.Close();
                  

                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Failed to connect to data source" + ex);
                }


          
        }

        private void BommeForm_Load(object sender, EventArgs e)
        {
        
           // dataGridViewBoMme.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewBoMme.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBoMme.MultiSelect = true;
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT BoName AS [Names], BoSurname AS Surname, BoPositionAtChurch AS [Position At Church], BoKganyaBookNo AS [Kganya Book No], BoBaptism AS Baptism, BoContactNo AS [Contact No], 
                         BoResAddress AS [Home Address], BoOccupation AS Occupation FROM tblBomme", con);
                sdr.Fill(ds);
                //
                dataGridViewBoMme.DataSource = ds.Tables[0];
                int countBomme = dataGridViewBoMme.Rows.Count;
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

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT BoName AS [Names], BoSurname AS Surname, BoPositionAtChurch AS [Position At Church], BoKganyaBookNo AS [Kganya Book No], BoBaptism AS Baptism, BoContactNo AS [Contact No], 
                         BoResAddress AS [Home Address], BoOccupation AS Occupation FROM tblBomme", con);
                sdr.Fill(ds);
                dataGridViewBoMme.DataSource = ds.Tables[0];
                int countBomme =dataGridViewBoMme.Rows.Count;
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

        private void btnExportToExcel_Click(object sender, EventArgs e)
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
            for (int i = 1; i < dataGridViewBoMme.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewBoMme.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewBoMme.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewBoMme.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewBoMme.Rows[i].Cells[j].Value;
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

        private void dataGridViewBoMme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMmeName.Text = dataGridViewBoMme[0, e.RowIndex].Value.ToString();
            txtMmeSurname.Text = dataGridViewBoMme[1, e.RowIndex].Value.ToString();
            txtMmeKganyaBookNo.Text = dataGridViewBoMme[4, e.RowIndex].Value.ToString();
            txtMmeConactNo.Text = dataGridViewBoMme[5, e.RowIndex].Value.ToString();
            txtMmeResAddress.Text = dataGridViewBoMme[6, e.RowIndex].Value.ToString();
            //  dateTimePickerDOBap.Text = dataGridViewBaruti[4, e.RowIndex].Value;
            cmbMmePosition.Text = dataGridViewBoMme[2, e.RowIndex].Value.ToString();
            cmbMmeOccup.SelectedItem = dataGridViewBoMme[7, e.RowIndex].Value;

            //
           
        }
    }
}
