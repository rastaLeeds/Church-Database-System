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
    public partial class TripsForm : Form
    {
        public TripsForm()
        {
            InitializeComponent();
        }

        private void btnSubmitTrip_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            // TODO: Modify the connection string and include any
            // additional required properties for your database.
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb";

            try
            {
                conn.Open();
                // Insert code to process data

                String my_querry = @"INSERT INTO tblTrips (SlipNo, dateOfTrip, VehicleOwner, VehicleType, VehicleRegNo, VehicleSize, NoOfPassenger, TripStartReadings, TripEndingReadings, DriverName, CustomerName, CustomerAddress, DestName, 
                         DestinationAddress, TransportAmount, AmountDueOrAdvance, AmountToBePaid, AmountPaid, TripType, TripDescrip) VALUES ('"+txtSlipNo.Text.Trim()+"', '"+dateTimePickerDoT.Text+"', '"+txtVowner.Text.Trim()+"', '"+txtVehicleType.Text.Trim()+"', '"+txtVRegNo.Text.Trim()+"', '"+numericUpDownVehicleSits.Value +"', '"+numericUpDownPass.Value +"', '"+txtStartingReadings.Text.Trim()+"', '"+txtEndingReadings.Text.Trim()+"', '"+txtVdriver.Text.Trim()+"', '"+txtTripChurchName.Text.Trim()+"', '"+
txtChurchAddress.Text.Trim()+"', '"+txtDestName.Text.Trim()+"', '"+txtDestAdres.Text.Trim()+"', '"+txtTransAmount.Text.Trim()+"', '"+txtAmountDue.Text.Trim()+"', '"+txtAmountToBeP.Text.Trim()+"', '"+txtAmountPaid.Text.Trim()+"', '"+cmbTripType.SelectedItem +"', '"+txtTripDescrip.Text.Trim()+"')";
            
                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Trip Added to Dababase successfuly!", "Added Success");
                conn.Close();
                txtSlipNo.Clear();
                //dateTimePickerDoT.;
                txtVowner.Clear();
                txtVehicleType.Clear();
                txtVRegNo.Clear();
                numericUpDownVehicleSits.ResetText();
                numericUpDownPass.ResetText();
                txtStartingReadings.Clear();
                txtEndingReadings.Clear();
                txtVdriver.Clear();
                txtTripChurchName.Clear();
                txtChurchAddress.Clear();
                txtDestName.Clear();
                txtDestAdres.Clear();
                txtTransAmount.Clear();
                txtAmountDue.Clear();
                txtAmountToBeP.Clear();
                txtAmountPaid.Clear();
                cmbTripType.ResetText();
                txtTripDescrip.Clear();
            
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Failed to connect to data source" + ex);
            }
        }

        private void TripsForm_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT tblTrips.* FROM tblTrips", con);
                sdr.Fill(ds);
                dataGridViewTrips.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }

        private void btnDisplyTrips_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");
                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT tblTrips.* FROM tblTrips", con);
                sdr.Fill(ds);
                dataGridViewTrips.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }

        private void btnSeachTripBy_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=churchDatabase.mdb");

            try
            {

                con.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter sdr = new OleDbDataAdapter(@"SELECT tblTrips.* FROM tblTrips WHERE [TripType] like ('" + txtSeachTrip.Text.ToString() + "')", con);
                sdr.Fill(ds);
                dataGridViewTrips.DataSource = ds.Tables[0];
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
    }
}
