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
    public partial class ConvertsForm : Form
    {
        public ConvertsForm()
        {
            InitializeComponent();
           

        }

        private void chckKamohelo_CheckedChanged(object sender, EventArgs e)
        {
            gbKamohelo.Enabled = true;
        }

        private void ConvertsForm_Load(object sender, EventArgs e)
        {
            gbConverts.Enabled = true;
            gbHlono.Enabled = true;
            gbKamohelo.Enabled = true;
            //
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            con.Open();
            try
            {

                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT        tblConverts.ConvertName AS [Convert Name], tblConverts.ConvertSurname AS [Convert Surname], tblConverts.DateOfConvertion AS [Date Of Conversion], 
                         tblHlohonolofatso.ChildNames AS [Hlonolofatso Chilld Name], tblHlohonolofatso.ChildSurname AS [Hlonolofatso Child Surname], tblHlohonolofatso.ChildDoB AS [Hlonolofatso Child Date Of Birth], 
                         tblHlohonolofatso.childGender AS [Child Gender], tblHlohonolofatso.ParentName AS [Parent Name], tblHlohonolofatso.ParentSurname AS [Parent Surname], 
                         tblHlohonolofatso.RelationToChild AS [Parent Relation To Child], tblHlohonolofatso.DateOfHlohonolofatso AS [Date Of Hlohonolofatso], tblKamohelo.KNames AS [Kamohelo Person Name], 
                         tblKamohelo.KSurname AS [Kamohelo Person Surname], tblKamohelo.DoKamohelo AS [Date Of Kahomelo], tblKamohelo.DateOfBaptisim AS [Date Of Baptism]
FROM            tblConverts, tblHlohonolofatso, tblKamohelo", con);
                sdr.Fill(ds);
                dataGridViewConvertsHlonoKamo.DataSource = ds.Tables[0];
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(" " + ex);

            }
            finally
            {
                con.Close();

            }
            //
            //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            con.Open();
            try
            {

                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT transName AS Name, transSurname AS Surname, TransGender AS Gender, TransferType AS [Type Of Transfer], TransDate AS [Transfer Date], TransChurchNamefrom AS [Church From], 
                         TransChurchNameTo AS [church To]
                           FROM  tblTransfers", con);
                sdr.Fill(ds);
                dataGridViewTransfers.DataSource = ds.Tables[0];
                //
                int countBomme = dataGridViewTransfers.Rows.Count;
                countBomme = countBomme - 1;
                lblNumOfTransfers.Text = countBomme.ToString();

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(" " + ex);

            }
            finally
            {
                con.Close();

            }
            //display kolobetso on formload
            //
          //  OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            con.Open();
            try
            {

                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT kolobetsoName AS [Names], koloSurname AS Surname, dateOfKolometso AS [Date Of Baptism], koloGender AS Gender
                                                            FROM tblKolobetso", con);
                sdr.Fill(ds);
                dataGridViewKolobetso.DataSource = ds.Tables[0];
                //
                int countBomme = dataGridViewKolobetso.Rows.Count;
                countBomme = countBomme - 1;
                lblTotalNumOfKolobetso.Text = countBomme.ToString();

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

        private void chckHlohonolofatso_CheckedChanged(object sender, EventArgs e)
        {
            gbHlono.Enabled = true;
        }

        private void chckConverts_CheckedChanged(object sender, EventArgs e)
        {
            gbConverts.Enabled = true;
        }
        //adding to converts to database
        private void btnSubmitConverts_Click(object sender, EventArgs e)
        {
          
            string ConvertName = txtConvertName.Text.Trim();
            string ConvertSurname = txtConvertSurname.Text.Trim();
            string DateOfconvertion = dateTimePickerConverts.Text.Trim();
            //not the best practice to include database this way 
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";
            conn.Open();
            try
            {
              
            //member table data insertion
            String my_querry = @"INSERT INTO tblConverts (ConvertName, ConvertSurname, DateOfConvertion) VALUES ('" + ConvertName + "', '" + ConvertSurname + "', '" + DateOfconvertion + "')";
            OleDbCommand cmd = new OleDbCommand(my_querry, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" " + ConvertName + " " + ConvertSurname + " Succesfully Added");
            txtConvertName.Text = "";
            txtConvertSurname.Text ="";

            //
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
            //mafu displayon form load

            //
           // OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            conn.Open();
            try
            {

                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT DeasName AS Name, DeasSurname AS Surname, DateOfPassing AS [Date Of Passing], DateOfBarial AS [Date Of Barial], ResAddress AS [Home Address], KganyaBookNo AS [Kganya No], 
                         KganyaMember AS [Kganya Member], DeasesGender AS Gender FROM tblDeases", conn);
                sdr.Fill(ds);
                dataGridViewMafu.DataSource = ds.Tables[0];
                //
                int countBomme = dataGridViewMafu.Rows.Count;
                countBomme = countBomme - 1;
                lblNumOfMafu.Text = countBomme.ToString();

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(" " + ex);

            }
            finally
            {
                conn.Close();

            }

            
        }

        private void btnAddHlono_Click(object sender, EventArgs e)
        { 
            string ChildName = txtChildName.Text.Trim();
            string ChildSurname = txtChildSurname.Text.Trim();
            string ChildDoB = dateTimePickerCDoB.Text.Trim();

            // //
            string childGender = null;
            if (rbtnFemale.Enabled == true)
            {
                childGender = "Female";
            }
            else if (rbtnFemale.Checked)
            {
                childGender = "Male";

            }
            string ParentName = txtParentName.Text.Trim();
            string ParentSurname = txtParentSurname.Text.Trim();
            string RelationToChild = cmbChildRelation.SelectedText.ToString();
            string DateOfHlonolofatso = dateTimePickerHlono.Text;
          
                //
            //not the best practice to include database this way 
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";
            conn.Open();
            try
            {
              
            //member table data insertion
            String my_querry = @"INSERT INTO tblHlohonolofatso (ChildNames, ChildSurname, ChildDoB, childGender, ParentName, ParentSurname, RelationToChild, DateOfHlohonolofatso)
                            VALUES ('"+ ChildName +"', '"+ ChildSurname +"', '"+ ChildDoB +"', '"+ childGender +"', '"+ ParentName +"', '"+ ParentSurname +"', '"+ RelationToChild +"', '"+ DateOfHlonolofatso +"')";
            OleDbCommand cmd = new OleDbCommand(my_querry, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" " + ChildName + " Succesfully Added");
           txtParentName.Text ="";
           txtParentSurname.Text="";
           cmbChildRelation.Text ="Select";
            txtChildName.Text ="";
            txtChildSurname.Text="";
            //string ChildDoB = dateTimePickerCDoB.Text.Trim();
            //string DateOfHlonolofatso = dateTimePickerHlono.Text;
          
                //

            }catch(OleDbException ex ){
                //
                MessageBox.Show(" " + ex);
                conn.Close();
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnAddKamohelo_Click(object sender, EventArgs e)
        {
            string Kname = txtKName.Text.Trim();
            string KSurname = txtKSurname.Text.Trim();
            string DateOfKamohelo = dateTimePickerKamohelo.Text.ToString();
            string DateOfBaptisim = dateTimePickerKamoheloBapt.Text.ToString();

            //not the best practice to include database this way 
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";
            conn.Open();
            try
            {

                //member table data insertion
                String my_querry = @"INSERT INTO tblKamohelo (KNames, KSurname, DoKamohelo, DateOfBaptisim)
                            VALUES ('" + txtKName + "', '" + KSurname + "', '" + DateOfKamohelo + "', '" + DateOfBaptisim + "')";
                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Succesfully Added to Kamohelo Database");
                //
                 txtKName.Text = "";
                 txtKSurname.Text = "";
           
            }
            catch (OleDbException ex)
            {
                //
                MessageBox.Show(" " + ex);
                conn.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnRefresh(object sender, EventArgs e)
        {            
//
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            con.Open();
            try
            {

                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT tblHlohonolofatso.ChildNames AS [Child Names], tblHlohonolofatso.ChildSurname AS [Child Surname], tblHlohonolofatso.ChildDoB AS [Child Date Of Birth], tblKamohelo.KNames AS [Kamohelo First Names], tblKamohelo.KSurname AS [Kamohelo Surnames], tblKamohelo.DoKamohelo AS [Date of Kamohelo], 
                         tblKamohelo.DateOfBaptisim AS [Kamohelo Date Of Baptisim], tblConverts.ConvertName AS [Convert Name], tblConverts.ConvertSurname AS [Convert Surname], tblConverts.DateOfConvertion AS [Date Of Convertion] FROM tblHlohonolofatso, tblKamohelo, tblConverts", con);
                sdr.Fill(ds);
                dataGridViewConvertsHlonoKamo.DataSource = ds.Tables[0];
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

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMofu_Click(object sender, EventArgs e)
        {
            string MofuName = txtNameOfMofu.Text.Trim();
            string MfuSurname = txtSurnameOfMofu.Text.Trim();
            string MofuGender = null;
            string isMofuKganyaMember = null;
            string DoPassing = dateTimePickerPassing.Text ;
            string MofuDoBarial = dateTimePickerBarial.Text;
            string MofuHomeAddress = txtHomeAddressOfMofu.Text.Trim();
            string kganyaNo = txtKganyaNo.Text.Trim();
            if (radioBtnKganya.Checked == true)
            {
                isMofuKganyaMember = "YES";
            }
            else if (radioBtnNonKganya.Checked == true)
            {
                isMofuKganyaMember = "No";
            }

            //gender
            if (radioBtnMofuMale.Checked == true)
            {
                MofuGender = "MALE";
            }
            else if (radioBtnMofuFemale.Checked == true)
            {
                MofuGender = "FEMALE";
            }

            //not the best practice to include database this way 
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";
            conn.Open();
            try
            {

                //member table data insertion
                String my_querry = @"INSERT INTO tblDeases
                         (DeasName, DeasSurname, DateOfPassing, DateOfBarial, ResAddress, KganyaBookNo, KganyaMember, DeasesGender)
                            VALUES ('" + MofuName + "', '" + MfuSurname + "', '" + DoPassing + "', '" + MofuDoBarial + "','" + MofuHomeAddress + "', '" + MofuDoBarial + "', '" + kganyaNo + "', '" + isMofuKganyaMember + "', '" + MofuGender + "')";
                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Succesfully Added to Mofu Database");
                //
                txtKName.Text = "";
                txtKSurname.Text = "";

            }
            catch (OleDbException ex)
            {
                //
                MessageBox.Show(" " + ex);
                conn.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDisplyaMafu_Click(object sender, EventArgs e)
        {
            //
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            con.Open();
            try
            {

                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT DeasName AS Name, DeasSurname AS Surname, DateOfPassing AS [Date Of Passing], DateOfBarial AS [Date Of Barial], ResAddress AS [Home Address], KganyaBookNo AS [Kganya No], 
                         KganyaMember AS [Kganya Member], DeasesGender AS Gender FROM tblDeases", con);
                sdr.Fill(ds);
                dataGridViewMafu.DataSource = ds.Tables[0];
                //
                int countBomme = dataGridViewMafu.Rows.Count;
                countBomme = countBomme - 1;
                lblNumOfMafu.Text = countBomme.ToString();

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

        private void btnExprtToExit_Click(object sender, EventArgs e)
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
            for (int i = 1; i < dataGridViewMafu.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewMafu.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewMafu.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewMafu.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewMafu.Rows[i].Cells[j].Value;
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

        private void btnAddTrans_Click(object sender, EventArgs e)
        {
            string transName = txtTransferName.Text.Trim();
            string transSurname = txttransferSurname.Text.Trim();
            string transfGender = "";
            string transType = "";
            string transDate = dateTimePickerTransfer.Text;
            string churchNameFrom = txtTransferChurchNameFrom.Text.Trim() ;
            string churchNameTo = txtTransferChurchNameTo.Text.Trim();
            if (radioBtnFemaleTrans.Checked == true)
            {
                transfGender = "Female";

            }
            else if (radioBtnMaleTrans.Checked == true)
            {
                transfGender = "Male";
            }

            if (chckTransferIn.Enabled == true)
            {
                //
                txtTransferChurchNameFrom.Enabled = true;
                transType = "Incoming Member";

            }
            else if (chckTransferIn.Enabled == true)
            {
                //
                txtTransferChurchNameFrom.Enabled = true;
            
            }
            if (chckTransferedOut.Enabled == true)
            {
                txtTransferChurchNameTo.Enabled = false;
                transType = "Outgoing Member";
                
            }
            //

            //not the best practice to include database this way 
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";
            conn.Open();
            try
            {

                //member table data insertion
                String my_querry = @"INSERT INTO tblTransfers
                         (transName, transSurname, TransGender, TransferType, TransDate, TransChurchNamefrom, TransChurchNameTo)
                            VALUES ('" + transName + "', '" + transSurname + "', '" + transfGender + "', '" + transType + "','" + transDate + "', '" + churchNameFrom + "', '" + churchNameTo + "')";
                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Succesfully Added to Mofu Database");
                //
                txtKName.Text = "";
                txtKSurname.Text = "";

            }
            catch (OleDbException ex)
            {
                //
                MessageBox.Show(" " + ex);
                conn.Close();
            }
            finally
            {
                conn.Close();
            }

        }

        private void chckTransferIn_CheckedChanged(object sender, EventArgs e)
        {
            string transType = "";

            if (chckTransferIn.Enabled == true)
            {
                //
                txtTransferChurchNameFrom.Enabled = true;
                transType = "Incoming Member";

            }
            else if (chckTransferIn.Enabled == true)
            {
                //
                txtTransferChurchNameFrom.Enabled = true;

            }
            if (chckTransferedOut.Enabled == true)
            {
                txtTransferChurchNameTo.Enabled = false;
                transType = "Outgoing Member";

            }
        }

        private void chckTransferedOut_CheckedChanged(object sender, EventArgs e)
        {
            string transType = "";

            if (chckTransferIn.Enabled == true)
            {
                //
                txtTransferChurchNameFrom.Enabled = true;
                transType = "Incoming Member";

            }
            else if (chckTransferIn.Enabled == false)
            {
                //
                txtTransferChurchNameFrom.Enabled = true;

            }
            if (chckTransferedOut.Enabled == true)
            {
                txtTransferChurchNameTo.Enabled = false;
                transType = "Outgoing Member";

            }
            else if (chckTransferedOut.Enabled == false)
            {
                txtTransferChurchNameTo.Enabled = true;

            }
        }

        private void btnExportTransToExcile_Click(object sender, EventArgs e)
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
            for (int i = 1; i < dataGridViewTransfers.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewTransfers.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewTransfers.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewTransfers.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewTransfers.Rows[i].Cells[j].Value;
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

        private void btnRefreshTrans_Click(object sender, EventArgs e)
        {
            //
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            con.Open();
            try
            {

                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT transName AS Name, transSurname AS Surname, TransGender AS Gender, TransferType AS [Type Of Transfer], TransDate AS [Transfer Date], TransChurchNamefrom AS [Church From], 
                         TransChurchNameTo AS [church To]
                           FROM  tblTransfers", con);
                sdr.Fill(ds);
                dataGridViewTransfers.DataSource = ds.Tables[0];
                //
                int countBomme = dataGridViewTransfers.Rows.Count;
                countBomme = countBomme - 1;
                lblNumOfTransfers.Text = countBomme.ToString();

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

        private void btnExportKolobetso_Click(object sender, EventArgs e)
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
            for (int i = 1; i < dataGridViewKolobetso.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewKolobetso.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewKolobetso.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewKolobetso.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewKolobetso.Rows[i].Cells[j].Value;
                }
            }
            //
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "New Members output";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }

        private void btnAddKolobetso_Click(object sender, EventArgs e)
        {
            string koloName = txtKoloName.Text.Trim();
            string koloSurname = txtKoloSurname.Text.Trim();
            string dateOfKolobetso = dateTimePickerDOKolo.Text;
            string koloGender = cmbGender.SelectedItem.ToString();

            //
            //not the best practice to include database this way 
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";
            conn.Open();
            try
            {

                //member table data insertion
                String my_querry = @"INSERT INTO tblKolobetso
                         (kolobetsoName, koloSurname, dateOfKolometso, koloGender)
                            VALUES ('" + koloName + "', '" + koloSurname + "', '" + dateOfKolobetso + "', '" + koloGender + "')";
                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" New Member Added Succesfully");
             

            }
            catch (OleDbException ex)
            {
                //
                MessageBox.Show(" " + ex);
                conn.Close();
            }
            finally
            {
                txtKoloName.Text="".Trim();
                txtKoloSurname.Text="".Trim();
                dateTimePickerDOKolo.Text ="";
                cmbGender.Text ="".ToString();
                conn.Close();
            }
        }

        private void btnDisplayKolo_Click(object sender, EventArgs e)
        {
            //
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
            con.Open();
            try
            {

                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT kolobetsoName AS [Names], koloSurname AS Surname, dateOfKolometso AS [Date Of Baptism], koloGender AS Gender
                                                            FROM tblKolobetso", con);
                sdr.Fill(ds);
                dataGridViewKolobetso.DataSource = ds.Tables[0];
                //
                int countBomme = dataGridViewKolobetso.Rows.Count;
                countBomme = countBomme - 1;
                lblTotalNumOfKolobetso.Text = countBomme.ToString();

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
    }
}
