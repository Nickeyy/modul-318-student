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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnSearchConnection_Click(object sender, EventArgs e)
        {
            SearchConnection connections = new SearchConnection();
            connections.ShowDialog();
        }

        private void BtnSearchStation_Click(object sender, EventArgs e)
        {
            StationBoard station = new StationBoard();
            station.ShowDialog();
        }
    }
}
