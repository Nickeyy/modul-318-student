using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace TransportAppGUI
{
    public partial class StationBoard : Form
    {
        readonly Transport transport = new Transport();
        public StationBoard()
        {
            InitializeComponent();
        }

        private void BtnSearchStation_Click(object sender, EventArgs e)
        {
            StationBoardRoot stationBoardRoot;
            Cursor.Current = Cursors.WaitCursor;
            lvStationBoard.Items.Clear();
            if (cbStation.AreStationFilled())
            {
                stationBoardRoot = transport.GetStationBoard(cbStation.Text, "");
                if(stationBoardRoot.Entries.Count > 0)
                {
                    foreach (SwissTransport.StationBoard stationBoard in stationBoardRoot.Entries)
                    {
                        lvStationBoard.Items.Add(GetListViewItem(stationBoard));
                    }
                }
                else
                {
                    MessageBox.Show("Es wurden keine Ergebnisse gefunden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } 
        }

        private ListViewItem GetListViewItem(SwissTransport.StationBoard stationBoard)
        {
            string[] stationBoards = { stationBoard.Stop.Departure.TimeOfDay.ToString(), stationBoard.To, stationBoard.Category + stationBoard.Number };
            return new ListViewItem(stationBoards);
        }

        private void CbStation_TextUpdate(object sender, EventArgs e)
        {
            cbStation.BackColor = SystemColors.Window;
            cbStation.ClearStationNames();
            cbStation.AddStationToCombobox(transport);
        }

        private void BtnShowMap_Click(object sender, EventArgs e)
        {
            Station station;
            if (cbStation.AreStationFilled())
            {
                station = transport.GetStations(cbStation.Text).StationList.First();
                Process.Start("https://www.google.com/maps/search/?api=1&query=" + station.Coordinate.XCoordinate.ToString().Replace(",",".") + "," + station.Coordinate.YCoordinate.ToString().Replace(",","."));
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
