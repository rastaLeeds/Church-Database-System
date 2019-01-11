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
    public partial class weddingForm : Form
    {
        public weddingForm()
        {
            InitializeComponent();
        }

        private void btnSubmitWedding_Click(object sender, EventArgs e)
        {
            //
            string GroomName = txtGroomName.Text.Trim();
            string GroomSurname = txtGroomSurname.Text.Trim();
            string BrideName = txtBrideName.Text.Trim();
            string BrideSurname = txtBrideName.Text.Trim();
            string districtName = txtDistrictName.Text.Trim();
            string officiatedDate = dateTimePickerOfficiatedDate.Text.Trim();
            string officiatedBy = txtOfficiator.Text.Trim();
            string officiatorPosition = cmbOfficiatorPosition.SelectedItem.ToString();
            //INSERT INTO tblWedding
            // (GroomName, GroomSurname, BrideName, BrideSurname, DistrictName, OfficiatedDate, OfficiatedBy, OficiaterPosition) VALUES ('+ GroomName +"','"+GroomSurname+"','"+BrideName+"','"+BrideSurname+"','"+districtName+"','"+officiatedDate+"','"+officiatedBy+"','"+officiatorPosition+"')
            
                            //not the best practice to include database this way 
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";
            try
            {

                    conn.Open();
                    String my_querry = @"INSERT INTO tblWedding (GroomName, GroomSurname, BrideName, BrideSurname, DistrictName, OfficiatedDate, OfficiatedBy, OficiaterPosition) VALUES ('"+ GroomName +"','"+GroomSurname+"','"+BrideName+"','"+BrideSurname+"','"+districtName+"','"+officiatedDate+"','"+officiatedBy+"','"+officiatorPosition+"')";
                    OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                    cmd.ExecuteNonQuery();
                MessageBox.Show("Wedding record added successfully");
                //clearing 
                GroomName = "";
                 GroomSurname = "";
                BrideName = "";
                BrideSurname = "";
                districtName = "";
                 dateTimePickerOfficiatedDate.ResetText();
                officiatedBy = "";
                cmbOfficiatorPosition.ResetText();
                //
                cmd.Dispose();
                conn.Close();
            }catch(OleDbException ex){
                //
                MessageBox.Show(" "+ ex);

            }
        }

        private void weddingForm_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT GroomName AS [Groom Name], GroomSurname AS [Groom Surname], BrideName AS [Bride Name], BrideSurname AS [Bride Surname], 
                            DistrictName AS [District Name], OfficiatedDate AS [Officiated Date], 
                         OfficiatedBy AS [Officiated By], OficiaterPosition AS [Oficiator Position] FROM tblWedding", con);
                sdr.Fill(ds);
                dataGridViewWeddings.DataSource = ds.Tables[0];
                sdr.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }

        private void btnSeachWedding_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");

            try
            {

                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT GroomName AS [Groom Name], GroomSurname AS [Groom Surname], BrideName AS [Bride Name], BrideSurname AS [Bride Surname],
                                    DistrictName AS [District Name], OfficiatedDate AS [Officiated Date], 
                                    OfficiatedBy AS [Officiated By], OficiaterPosition AS [Oficiator Position] FROM tblWedding WHERE [GroomName] like ('" + btnSeachWedding.Text.ToString() + "') OR [BrideName] like ('" + btnSeachWedding.Text.ToString() + "')", con);
                sdr.Fill(ds);
                dataGridViewWeddings.DataSource = ds.Tables[0];
                sdr.Dispose();
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

        private void btnEditW_Click(object sender, EventArgs e)
        {
            //UPDATE tblWedding SET  GroomName =, GroomSurname =, BrideName =, BrideSurname =, DistrictName =, OfficiatedDate =, OfficiatedBy =, OficiaterPosition =
            //WHERE (tblWedding.OfficiatedDate = tblWedding.GroomName) OR (tblWedding.OfficiatedDate = tblWedding.GroomName)
        }
    }
}
