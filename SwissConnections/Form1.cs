using SwissTransport.Core;
using SwissTransport.Models;
using SwissTransport;

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

        private void cmbSearchDepartures_TextChanged(object sender, EventArgs e)
        {
            cmbSearchDepartures.DroppedDown = true;
            cmbSearchDepartures.Items.Clear();
            search(cmbSearchDepartures);
        }

        private void cmbSearchDepartures_SelectedValueChanged(object sender, EventArgs e)
        {
            StationBoardRoot stationBoardRoot = new StationBoardRoot();
            //stationBoardRoot = transport.GetStationBoard();
            foreach (var element in stationBoardRoot.Entries)
            {
                DataGridViewRow row1 = (DataGridViewRow)dgvConnections.Rows[0].Clone();
                row1.Cells[0].Value = stationBoardRoot.Station.Name;
            }
        }

        /*
         * Connection search
         */

        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            if (tbxFromLocation.Text != null && tbxToLocation.Text != null)
            {
                try {
                    dgvConnections.Rows.Clear();
                    Connections Connections = transport.GetConnections(tbxFromLocation.Text, tbxToLocation.Text);

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

        /*
         * General classes
         */

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