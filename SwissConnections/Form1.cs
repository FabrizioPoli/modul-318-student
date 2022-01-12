using SwissTransport.Core;
using SwissTransport.Models;
using System.Collections;

namespace SwissConnections
{
    public partial class LandingPage : Form
    {
        ITransport transport = new Transport();
        public LandingPage()
        {
            InitializeComponent();
        }

        /****************************
         * Stationboard
         ***************************/

        private void cmbSearchDepartures_Click(object sender, EventArgs e)
        {
            comboBox_On_TextChange(cmbSearchDepartures);
        }

        private void btnSearchStations_Click(object sender, EventArgs e)
        {
            StationBoardRoot stationBoardRoot = new StationBoardRoot();
            stationBoardRoot = transport.GetStationBoard(cmbSearchDepartures.Text, "");
            foreach (var element in stationBoardRoot.Entries)
            {
                DataGridViewRow row1 = (DataGridViewRow)dgvConnections.Rows[0].Clone();
                row1.Cells[0].Value = element.Name;
            }
        }
        
        /****************************
         * Connection search
         ***************************/

        private void cmbFromLocation_Click(object sender, EventArgs e)
        {
            comboBox_On_TextChange(cmbFromLocation);
        }
        private void cmbToLocation_Click(object sender, EventArgs e)
        {
            comboBox_On_TextChange(cmbToLocation);
        }

        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            if (cmbFromLocation.Text != null && cmbToLocation.Text != null)
            {
                try {
                    dgvConnections.Rows.Clear();
                    Connections Connections = transport.GetConnections(cmbFromLocation.Text, cmbToLocation.Text, dtpConnectionDate.Value.Date, dtpTimePicker.Value);

                    foreach (Connection connection in Connections.ConnectionList)
                    { 
                            DataGridViewRow row = (DataGridViewRow)dgvConnections.Rows[0].Clone();
                            row.Cells[0].Value = connection.From.Station.Name;
                            row.Cells[1].Value = connection.To.Station.Name;
                            row.Cells[2].Value = connection.From.Departure;
                            row.Cells[3].Value = connection.To.Arrival;
                            dgvConnections.Rows.Add(row);    
                    }
                } catch (ArgumentNullException)
                {
                    MessageBox.Show("Please type in a location!"); 
                }
                
            }
        }

        /****************************
         * General functions
         ***************************/

        public void comboBox_On_TextChange(ComboBox cmb)
        {
            foreach (var item in new ArrayList(cmb.Items))
            {
                cmb.Items.Remove(item);
            }
            Cursor.Current = Cursors.Default;
            search(cmb);
        }

        public void search(ComboBox cmb)
        {
            try
            {
                Stations station = new Stations();
                station = transport.GetStations(cmb.Text);
                foreach (var stat in station.StationList)
                {
                    if (stat.Id != null)
                    {
                        cmb.Items.Add(stat.Name);
                    }
                }
            }
            catch (Exception)
            {
                cmbSearchDepartures.Items.Add("No Result");
            }
        }
    }
}