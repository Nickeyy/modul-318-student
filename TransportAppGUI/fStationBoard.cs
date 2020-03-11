using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace TransportAppGUI
{
    public partial class fStationBoard : Form
    {
        readonly Transport transport = new Transport();
        public fStationBoard()
        {
            InitializeComponent();
        }

        private void btnSearchStation_Click(object sender, EventArgs e)
        {
            lvStationBoard.Items.Clear();
            if (cbStation.AreStationFilled())
            {
                foreach (SwissTransport.StationBoard stationBoard in transport.GetStationBoard(cbStation.Text, "").Entries)
                {
                    lvStationBoard.Items.Add(GetListViewItem(stationBoard));
                }
            } 
        }

        private ListViewItem GetListViewItem(StationBoard stationBoard)
        {
            string[] stationBoards = { stationBoard.Stop.Departure.TimeOfDay.ToString(), stationBoard.To, stationBoard.Category + stationBoard.Number };
            return new ListViewItem(stationBoards);
        }

        private void cbStation_TextUpdate(object sender, EventArgs e)
        {
            cbStation.BackColor = SystemColors.Window;
            cbStation.ClearStationNames();
            cbStation.AddStationToCombobox(transport);
        }
    }
}
