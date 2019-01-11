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
    public partial class MasogoanaForm : Form
    {
        public MasogoanaForm()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dateOfMosomo = dateTimePickerDate.Text;
            double metsi = double.Parse(txtMetsi.Text.Trim());
            double officeEqui = double.Parse(txtOfficeEquip.Text.Trim());
            double stationery = double.Parse(txtStationery.Text.Trim());
            double MoahoDikereke = double.Parse(txtMoaho.Text.Trim());
            double mkganya = double.Parse(txtKganya.Text.Trim());
            double printing = double.Parse(txtPrinting.Text.Trim());
            double naga = double.Parse(txtNaga.Text.Trim());

            double totalPerDate = 00.00;

            totalPerDate = metsi + officeEqui + stationery + MoahoDikereke + mkganya + printing + naga;
            //CurrencyManager.Equals(totalPerDate);
            string MosomoWayellowBook = "R " + totalPerDate;
            string TotalMosomoWayellowBook = txtTotalMosomo.Text.Trim();
            TotalMosomoWayellowBook = MosomoWayellowBook;

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
                String my_querry = @"INSERT INTO tblMosomoWaYellowBook
                         (YellowDate, Metsi, OfficeEquipment, Stationery, MoahoDikereke, Kganya, Printing, Naga, total)
                         VALUES('" + dateOfMosomo + "', '" + metsi + "', '" + officeEqui + "', '" + stationery + "', '" + MoahoDikereke + "', '" + mkganya + "', '" + printing + "', '" + naga + "','" + TotalMosomoWayellowBook + "')";


                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Mosomo wa yellow book Added Sucessfully", "Added Success");
                //clearing textboxes
             
                txtMetsi.Text="".Trim();
                txtOfficeEquip.Text="".Trim();
                txtStationery.Text="".Trim();
                txtMoaho.Text="".Trim();
                txtKganya.Text="".Trim();
                txtPrinting.Text="".Trim();
                txtNaga.Text="".Trim();
                txtTotalMosomo.Text = "".Trim();
                conn.Close();


            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Failed to connect to data source" + ex);
            }

        }

        private void btnExportToEx_Click(object sender, EventArgs e)
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
            for (int i = 1; i < dataGridViewMosomo.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewMosomo.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewMosomo.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewMosomo.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewMosomo.Rows[i].Cells[j].Value;
                }
            }
            //
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Mosomo wa Yellow Book ";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT YellowDate AS [Date], Metsi, OfficeEquipment AS [Office Equipment], Stationery, MoahoDikereke AS [Moaho Dikereke], Kganya, Printing, Naga, total AS [Sub Total]
                                                            FROM  tblMosomoWaYellowBook", con);
                sdr.Fill(ds);
                dataGridViewMosomo.DataSource = ds.Tables[0];
                int countMpoho = dataGridViewMosomo.Rows.Count;
                countMpoho = countMpoho - 1;
                lblMosomo.Text = countMpoho.ToString();
                con.Close();
                ds.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string HostName = txtHostName.Text.Trim();
            string hostContactNo = txtHostContact.Text.Trim();
            string hostAddress = txtHostAddress.Text.Trim();
            string prayerType = cmbPrayerType.Text.Trim();
            string dateOfPrayer = dateTimePickerDoPrayer.Text;

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

                //
                String my_querry = @"INSERT INTO tblMpohoLeThapediso
                         (Host, DateOfPrayer, HostAddress, HostContactNo, TypeOfPrayer)
                         VALUES('" + HostName + "', '" + dateOfPrayer + "', '" + hostAddress + "', '" + hostContactNo + "', '" + prayerType+ "')";


                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Added Sucessfully", "Added Success");
                //clearing textboxes
                // clearing input boxes
                txtHostName.Text = "".Trim();
                txtHostContact.Text = "".Trim();
                txtHostAddress.Text = "".Trim();
                //cmbPrayerType.Text.Trim();
                //string dateOfPrayer = dateTimePickerDoPrayer.Text;
                conn.Close();


            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Failed to connect to data source" + ex);
            }

            



        }

        private void MasogoanaForm_Load(object sender, EventArgs e)
        {
            //
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT LeetoDate AS [Date], LeetoDescrip AS [Leeto Description], NoOfTrans AS Capacity, Fare, Quotation, Destination
                                                            FROM tblMaeto", con);
                sdr.Fill(ds);
                dataGridViewMaeto.DataSource = ds.Tables[0];
                int countMpohoThapediso = dataGridViewMaeto.Rows.Count;
               countMpohoThapediso = countMpohoThapediso - 1;
                lblNumOfMaeto.Text = countMpohoThapediso.ToString();
                con.Close();
                ds.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT YellowDate AS [Date], Metsi, OfficeEquipment AS [Office Equipment], Stationery, MoahoDikereke AS [Moaho Dikereke], Kganya, Printing, Naga, total AS [Sub Total]
                                                            FROM  tblMosomoWaYellowBook", con);
                sdr.Fill(ds);
                dataGridViewMosomo.DataSource = ds.Tables[0];
                int countBomme = dataGridViewMosomo.Rows.Count;
                countBomme = countBomme -1;
                lblMosomo.Text = countBomme.ToString();
                con.Close();
                ds.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }

        //
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT Host AS [Name And Surname Of Host], DateOfPrayer AS [Date Of Prayer], HostAddress AS [Host Address], HostContactNo AS [Contact No], TypeOfPrayer AS [Type Of Prayer]
                                                            FROM tblMpohoLeThapediso", con);
                sdr.Fill(ds);
                dataGridViewMpohoThapediso.DataSource = ds.Tables[0];
                int countMpohoThapediso = dataGridViewMpohoThapediso.Rows.Count;
              //  countMpohoThapediso = countMpohoThapediso - 1;
                lblNumOfPrayers.Text = countMpohoThapediso.ToString();
                con.Close();
                ds.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }

        private void btnExprtPrayer_Click(object sender, EventArgs e)
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
            for (int i = 1; i < dataGridViewMpohoThapediso.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewMpohoThapediso.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewMpohoThapediso.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewMpohoThapediso.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewMpohoThapediso.Rows[i].Cells[j].Value;
                }
            }
            //
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Mpoho And Thapediso";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }

        private void btnMaeto_Click(object sender, EventArgs e)
        {
            string DateOfLeeto = dateTimePickerLeeto.Text;
            string LeetoDescription = txtLeetoDiscrip.Text.Trim();
            string NoOfTrans = txtNoOfTrans.Text.Trim();
            string Fare = txtFare.Text.Trim();
          //  string Capacity = txtCapacity.Text.Trim();
            string Quotation = txtQuotation.Text.Trim();
            string Destination = txtDestination.Text.Trim();
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

                //
                String my_querry = @"INSERT INTO tblMaeto
                         (LeetoDate, LeetoDescrip, NoOfTrans, Fare, Quotation, Destination)
                         VALUES('" + DateOfLeeto + "', '" + LeetoDescription + "', '" + NoOfTrans + "', '" + Fare + "', '" + Quotation + "'," + Destination + "')";

                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Added Sucessfully", "Added Success");
                //clearing textboxes


                //cmd.Despose();
                conn.Close();


            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Failed to connect to data source" + ex);
            }

            //
            txtLeetoDiscrip.Text="".Trim();
             dateTimePickerLeeto.Text ="";
             txtNoOfTrans.Text="".Trim();
             txtFare.Text="".Trim();
            //  string Capacity = txtCapacity.Text.Trim();
          txtQuotation.Text="".Trim();
         txtDestination.Text="".Trim();

        }

        private void btnExportToExcelmaeto_Click(object sender, EventArgs e)
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
            for (int i = 1; i < dataGridViewMaeto.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewMaeto.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewMaeto.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewMaeto.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewMaeto.Rows[i].Cells[j].Value;
                }
            }
            //
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Maeto ";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }

        private void btnRefreshMaeto_Click(object sender, EventArgs e)
        {
            //
            try
            {
                //
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT LeetoDate AS [Date], LeetoDescrip AS [Leeto Description], NoOfTrans AS Capacity, Fare, Quotation, Destination
                                                            FROM tblMaeto", con);
                sdr.Fill(ds);
                dataGridViewMaeto.DataSource = ds.Tables[0];
                int countMpohoThapediso = dataGridViewMaeto.Rows.Count;
                 countMpohoThapediso = countMpohoThapediso - 1;
                 lblNumOfMaeto.Text = countMpohoThapediso.ToString();
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
