using SwissTransport.Core;
using SwissTransport.Models;
using System.Collections;

namespace SwissConnections
{
    public partial class swissConnections : Form
    {
        //Aufruf auf die API
        ITransport transport = new Transport();
        public swissConnections()
        {
            InitializeComponent();
        }

        /****************************
         * Stationboard
         ***************************/

        //Beim anklicken der Combobox wird die comboBox_On_TextChange() aufgerufen.
        private void cmbSearchDepartures_Click(object sender, EventArgs e)
        {
            comboBox_On_TextChange(cmbSearchDepartures);
        }

        //Beim Click-Event von diesem Button wird eine Liste mit Abfahrten ausgegeben
        //von in einer Combobox engetragener Station.
        private void btnSearchStations_Click(object sender, EventArgs e)
        {
            try 
            { 
                StationBoardRoot stationBoardRoot = new StationBoardRoot();
                stationBoardRoot = transport.GetStationBoard(cmbSearchDepartures.Text, "id");
                foreach (var element in stationBoardRoot.Entries)
                {
                    dgvStationBoard.Rows.Add(cmbSearchDepartures.Text, element.To, DateTime.Parse(element.Stop.Departure.ToString()).ToShortTimeString(), element.Number);
                }
            } catch (ArgumentNullException)
            {
                MessageBox.Show("Please type in a location!");
            }
        }


        /****************************
         * Connection search
         ***************************/

        //Beim anklicken der Combobox wird die comboBox_On_TextChange() aufgerufen.
        private void cmbFromLocation_Click(object sender, EventArgs e)
        {
            comboBox_On_TextChange(cmbFromLocation);
        }

        //Beim anklicken der Combobox wird die comboBox_On_TextChange() aufgerufen.
        private void cmbToLocation_Click(object sender, EventArgs e)
        {
            comboBox_On_TextChange(cmbToLocation);
        }

        //Wenn man auf den "Search"-Button klickt werden passend zu den eingetragenen Daten, Verbindungen angezeigt.
        //Das Try-Catch fängt auf falls der User auf "Search" klickt und noch nichts eingetragen hat.
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

        //Bei diesem Event werden die Eingetragenen Stationen von "From" und "To" vertauscht.
        private void btnSwitchLocations_Click(object sender, EventArgs e)
        {
            string fromLocation = cmbFromLocation.Text;
            string toLocation = cmbToLocation.Text;
            cmbFromLocation.Text = toLocation;
            cmbToLocation.Text = fromLocation;
        }


        /****************************
         * General functions
         ***************************/

        //Diese Funktion sorgt für das Löschen der Items aus den Comboboxen
        //und ruft die "search"-Funktion auf.
        public void comboBox_On_TextChange(ComboBox cmb)
        {
            foreach (var item in new ArrayList(cmb.Items))
            {
                cmb.Items.Remove(item);
            }
            Cursor.Current = Cursors.Default;
            search(cmb);
        }

        //Diese Funktion ist dafür zuständig vorschläge der Stationen zu machen.
        //Die Exception fängt ab wenn der User keinen vorhandenen Namen eingibt.
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

        private void btnShareConnections_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.ShowDialog();
        }
    }
}