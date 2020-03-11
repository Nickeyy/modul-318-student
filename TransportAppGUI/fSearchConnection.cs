using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportAppGUI
{
    public partial class fSearchConnection : Form
    {
        private ITransport transport;
        public fSearchConnection()
        {
            InitializeComponent();
            transport = new SwissTransport.Transport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //SearchConnections("Sursee", "Luzern");
            lvConnections.Items.Clear();

            foreach (SwissTransport.Connection connection in transport.GetConnections(cbStartStation.Text,cbEndStation.Text, dtpDate.Text, dtpTime.Text).ConnectionList)
            {
                lvConnections.Items.Add(GetListViewItem(connection));
            }
        }

        private ListViewItem GetListViewItem(Connection connection)
        {
            string []  connections = { connection.From.Departure.ToString().Substring(0,10) ,connection.From.Departure.ToString().Substring(11,5), connection.From.Station.Name, connection.To.Station.Name, connection.To.Arrival.ToString().Substring(11, 5), connection.Duration.Substring(3, 5), connection.From.Platform};
            return new ListViewItem(connections);
        }

        private void cbStartStation_TextUpdate(object sender, EventArgs e)
        {
            ClearStationNames(cbStartStation);
            AddStationToCombobox(cbStartStation);
        }

        private void cbEndStation_TextUpdate(object sender, EventArgs e)
        {
            ClearStationNames(cbEndStation);
            AddStationToCombobox(cbEndStation);
        }

        private void ClearStationNames(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.SelectionStart = comboBox.Text.Length;
            comboBox.SelectionLength = 0;
        }

        private void AddStationToCombobox(ComboBox comboBox)
        {
            comboBox.DroppedDown = true;

                foreach (Station station in transport.GetStations(comboBox.Text).StationList)
                {
                    if (station.Name != null && station.Id != null)
                    {
                    comboBox.Items.Add(station.Name);
                    }
                }
        }
    }
}
