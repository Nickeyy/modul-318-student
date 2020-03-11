using SwissTransport;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportAppGUI
{
    class DropDownComboBox : ComboBox
    {

        public void ClearStationNames()
        {
            Items.Clear();
            Items.Add("");
            SelectionStart = Text.Length;
            SelectionLength = 0;
        }

        public void AddStationToCombobox(Transport transport)
        {
            DroppedDown = true;

            foreach (Station station in transport.GetStations(Text).StationList)
            {
                if (station.Name != null && station.Id != null)
                {
                    Items.Add(station.Name);
                }
            }
        }
        public bool AreStationFilled()
        {
            bool returnValue = true;
            
            if (Text == null || Text.Length <= 0)
            {
                BackColor = Color.FromArgb(255, 92, 92);
                returnValue = false;
            }
            return returnValue;
        }

    }
}
