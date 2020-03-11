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
        readonly Transport transport = new Transport();
        public fSearchConnection()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvConnections.Items.Clear();
            if (cbStationFrom.AreStationFilled() && cbStationEnd.AreStationFilled())
            {
                foreach (SwissTransport.Connection connection in transport.GetConnections(cbStationFrom.Text, cbStationEnd.Text, dtpDate.Text, dtpTime.Text).ConnectionList)
                {
                    lvConnections.Items.Add(GetListViewItem(connection));
                }
            }
        }


        private ListViewItem GetListViewItem(Connection connection)
        {
            string []  connections = { connection.From.Departure.ToString().Substring(0,10) ,connection.From.Departure.ToString().Substring(11,5), connection.From.Station.Name, connection.To.Station.Name, connection.To.Arrival.ToString().Substring(11, 5), connection.Duration.Substring(3, 5), connection.From.Platform};
            return new ListViewItem(connections);
        }

        private void cbStationEnd_TextUpdate(object sender, EventArgs e)
        {
            cbStationEnd.BackColor = SystemColors.Window;
            cbStationEnd.ClearStationNames();
            cbStationEnd.AddStationToCombobox(transport);
        }

        private void cbStationFrom_TextUpdate(object sender, EventArgs e)
        {
            cbStationFrom.BackColor = SystemColors.Window;
            cbStationFrom.ClearStationNames();
            cbStationFrom.AddStationToCombobox(transport);
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            SendMail sendMail = new SendMail();
            sendMail.Subject = "Fahrplan";

            foreach(ListViewItem connection in lvConnections.Items)
            {
                foreach(ListViewItem.ListViewSubItem subItem in connection.SubItems)
                {
                    sendMail.Body += subItem.Text;
                }
            }

            sendMail.sendMail();
        }
    }
}
