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
    public partial class AssetManagement : Form
    {
        public AssetManagement()
        {
            InitializeComponent();
            
            gbTwo.Enabled = false;
            gbThree.Enabled = false;
            gbFour.Enabled = false;
            btnDeleteAsset.Enabled = false;
            btnExportAsset.Enabled = true;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            gbTwo.Enabled = true;
            gbThree.Enabled = false;
            gbFour.Enabled = false;

        }

        private void btnProceedNext_Click(object sender, EventArgs e)
        {
            gbTwo.Enabled = true;
            gbThree.Enabled = true;
            gbFour.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbTwo.Enabled = true;
            gbThree.Enabled = true;
            gbFour.Enabled = true;
        }
        //displaying results on datagridview 
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT AssetDescription AS [Asset Description], AssetCat AS [Asset Category], Condition, Quantity AS Qty, SerialNo AS [Serial Number], AssetHolder AS [Asset Holder], AssetCenter AS [Asset Center], 
                         NewAssetOrderCode AS [New Asset Order Code], Cost, OrderNo, DateOfPurchase AS [Date Of Purchase], SupplierName AS [Supplier Name], SupplierPrice, Adjustment, TransferedIn, TransferedOut, Additions, 
                         Disposal, DisposalDate AS [Disposal Date], DisposalAmountRecieved AS [Disposal Amount Recieved] FROM tblAssets", con);
                sdr.Fill(ds);
                DataGridViewAsset.DataSource = ds.Tables[0];

                int countBomme = DataGridViewAsset.Rows.Count;
                countBomme = countBomme - 1;
                lblTotalNumOfAssets.Text = countBomme.ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string condit = null;
            OleDbConnection conn = new OleDbConnection();
            // TODO: Modify the connection string and include any
            // additional required properties for your database.
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";

            try
            {
                conn.Open();
                // Insert code to process data

                if (rbtnGood.Checked)
                {
                    condit = "Good";
                }
                else if (rbtnBad.Checked)
                {
                    condit = "bad";

                }
                else if (rbtnFair.Checked)
                {
                    condit = "Fair";

                }
                String my_querry = @"INSERT INTO tblAssets (AssetDescription, AssetCat, Condition, Quantity, SerialNo, AssetHolder, AssetCenter, NewAssetOrderCode, Cost, OrderNo, DateOfPurchase, SupplierName, SupplierPrice, Adjustment, TransferedIn, TransferedOut, 
                         Additions, Disposal, DisposalDate, DisposalAmountRecieved) VALUES ('"+cmbAssetCat.SelectedItem.ToString()+"', '"+txtAssetDescrip.Text.ToString().ToUpper().Trim()+"', '"+condit.ToUpper()+"','"+ txtAssetQuantity.Text+"','"+txtSerialNo.Text.ToString().Trim()+"', '"+ cmbAssetHolder.SelectedItem.ToString() +"', '"+ cmbAssetCenter.SelectedItem.ToString() +"', '"+ txtAssetCode.Text.Trim() +"','"+ TotalPriceTextBox.Text+"','"+txtOrderNo.Text.Trim()+"','" + dateTimePickerPurcase.Text +"','" +txtSupplierName.Text.Trim().ToUpper()+"','"+ PriceTextBox.Text +"','" 
                 + txtAdjustments.Text.Trim()+"','"+ dateTimePickerTransfetredIn.Text +"','"+ dateTimePickerTransferedOut.Text +"','"+txtAdditions.Text.Trim()+"','"+txtDisposal.Text.Trim()+ "','" + dateTimePickerDisposal.Text +"','"+ DisAmountRemTextBox.Text.Trim()+"')";
                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Asset saved successfuly!","Added Success");
                conn.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Failed to connect to data source" + ex);
            }
        }

        private void btnSearchAsset_Click(object sender, EventArgs e)
        {
            DataGridViewAsset.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            DataGridViewAsset.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewAsset.MultiSelect = true;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");

            try
            {

                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT AssetDescription AS [Asset Description], AssetCat AS [Asset Category], Condition, Quantity AS Qty, SerialNo AS [Serial Number], AssetHolder AS [Asset Holder], AssetCenter AS [Asset Center], 
                         NewAssetOrderCode AS [New Asset Order Code], Cost, OrderNo, DateOfPurchase AS [Date Of Purchase], SupplierName AS [Supplier Name], SupplierPrice, Adjustment, TransferedIn, TransferedOut, Additions, 
                         Disposal, DisposalDate AS [Disposal Date], DisposalAmountRecieved AS [Disposal Amount Recieved] FROM tblAssets WHERE AssetDescription  like ('" + btnSearchAsset.Text.Trim() + "')", con);
                sdr.Fill(ds);
             //   DataGridViewAsset.DataSource = ds.Tables[0];

                int countBomme = DataGridViewAsset.Rows.Count;
                countBomme = countBomme - 1;
               // lblTotalNumOfBomme.Text = countBomme.ToString();
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

        private void btnExportAsset_Click(object sender, EventArgs e)
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
            for (int i = 1; i < DataGridViewAsset.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DataGridViewAsset.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < DataGridViewAsset.Rows.Count; i++)
            {
                for (int j = 0; j < DataGridViewAsset.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DataGridViewAsset.Rows[i].Cells[j].Value;
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

        private void AssetManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnDeleteAsset_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";
            string sql = @"DELETE AssetDescription AS [Asset Description], AssetCat AS [Asset Category], Condition, Quantity AS Qty, SerialNo AS [Serial Number], AssetHolder AS [Asset Holder], AssetCenter AS [Asset Center], 
                         NewAssetOrderCode AS [New Asset Order Code], Cost, OrderNo, DateOfPurchase AS [Date Of Purchase], SupplierName AS [Supplier Name], SupplierPrice, Adjustment, TransferedIn, TransferedOut, Additions, 
                         Disposal, DisposalDate AS [Disposal Date], DisposalAmountRecieved AS [Disposal Amount Recieved] FROM tblAssets WHERE AssetDescription  like ('" + btnSearchAsset.Text.Trim() + "')";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                OleDbDataAdapter adpt = new OleDbDataAdapter(cmd);
                adpt.DeleteCommand = con.CreateCommand();
                adpt.DeleteCommand.CommandText = sql;
                //AssetCode	AssetDescription	AssetCat	Condition	Quantity	SerialNo	AssetHolder	AssetCenter	NewAssetOrderCode	Cost	OrderNo	DateOfPurchase	SupplierName	SupplierPrice	Adjustment	TransferedIn	TransferedOut	Additions	Disposal	DisposalDate	DisposalAmountRecieved
//19	Office Equipment	STEEL CABINET (GREEN)	FAIR	01	N/A	Owned	Kganya Office	FN2KO10	+ - R300	N/A	N/A	DONATED	+ - R300	00.00	N/A	N/A	00.00	NO	N/A	NO
                if (MessageBox.Show("Are you sure you want to delete?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
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

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

    }
}
