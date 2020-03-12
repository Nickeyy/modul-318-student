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
    public partial class FStartGui : Form
    {
        public FStartGui()
        {
            InitializeComponent();

            
        }

        private void btnSearchConnection_Click(object sender, EventArgs e)
        {
            FSearchConnection connections = new FSearchConnection();
            connections.ShowDialog();
        }

        private void btnSearchStation_Click(object sender, EventArgs e)
        {
            FStationBoard station = new FStationBoard();
            station.ShowDialog();
        }
    }
}
