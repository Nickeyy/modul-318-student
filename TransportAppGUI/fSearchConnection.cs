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
            Cursor.Current = Cursors.WaitCursor;
            lvConnections.Items.Clear();
            if (cbStationFrom.AreStationFilled() && cbStationEnd.AreStationFilled())
            {
                Connections connections = transport.GetConnections(cbStationFrom.Text, cbStationEnd.Text, dtpDate.Text, dtpTime.Text);
                if (connections.ConnectionList.Count > 0)
                {
                    foreach (SwissTransport.Connection connection in connections.ConnectionList)
                    {
                        lvConnections.Items.Add(GetListViewItem(connection));
                    }
                }
                else
                {
                    MessageBox.Show("Es wurden keine Ergebnisse gefunden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSwitchStation_Click(object sender, EventArgs e)
        {
            string fromStation = cbStationFrom.Text;
            cbStationFrom.Text = cbStationEnd.Text;
            cbStationEnd.Text = fromStation;
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
