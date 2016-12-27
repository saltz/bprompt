using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace SparkyTheSmartClock
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        //global variables
        double mousepositionX;
        double mousepositionY;
        string NsApiUrl;

        private void NavClick(object sender, EventArgs e)
        {
            NavigationCalculation();
        }

        private void MoveCapture(object sender, MouseEventArgs e)
        { mousepositionX = e.X; mousepositionY = e.Y; }

        private void NavigationCalculation()
        {
            double x1 = 0;
            double x2 = 0;
            double r = 32.5;
            mousepositionY -= 42.5;

            x1 = (Math.Sqrt((r * r) - (mousepositionY * mousepositionY)) * -1) + 175;
            x2 = Math.Sqrt((r * r) - (mousepositionY * mousepositionY)) + 195;

            if (mousepositionX < x1)
            {
                menuNav.SelectedIndex = 1;
            }
            else
            {
                if (mousepositionX > x1 && mousepositionX < x2)
                {
                    menuNav.SelectedIndex = 0;
                }
                else if (mousepositionX > x2)
                {
                    menuNav.SelectedIndex = 2;
                }
            }
        }

        private void btCalculateTravelTime_Click(object sender, EventArgs e)
        {
            lbDelayDeparture.Visible = false;
            lbDelayArrival.Visible = false;

            string xml;
            string livingPlace = tbPlace.Text;

            NsApiUrl = "http://webservices.ns.nl/ns-api-treinplanner?fromStation=" + livingPlace + "&toStation=Eindhoven"; //+ "&dateTime=" + travelinfo.GetBeginTimeSchool() (2016-12-20T12:00);

            using (WebClient wc = new WebClient()) // Get acces to the API and put the info in a string
            {
                wc.Credentials = new NetworkCredential("s_devries@live.nl", "dV9RLW82YRn-RJWezf-zr-Mtay-Z0Z2Ram2zPkqbs9qBd2GQzJcVNQ");
                xml = wc.DownloadString(NsApiUrl);
            }

            TravelInfo travelInfo = new TravelInfo(xml);

            // Put travel info in the labels
            lbIntercitySprinter.Text = travelInfo.GetTravelMode();
            lbTravelTime.Text = "Travel time: " + travelInfo.GetTravelTime();
            lbTransporter.Text = "Transporter: " + travelInfo.GetTransporter();
            lbDate.Text = "Date: " + travelInfo.GetDate();
            lbDepartureTime.Text = travelInfo.GetEstimatedDepartureTime() + " Station " + travelInfo.GetDepartureName();
            lbDepartureTrack.Text = "Track " + travelInfo.GetDepartureTrack();
            lbDelayDeparture.Text = travelInfo.GetDelayDeparture();

            if (lbDelayDeparture.Text != "0")
            {
                lbDelayDeparture.Visible = true;
            }

            if (travelInfo.GetDepartureName() != "INVALID!")
            {
                lbArrivalTime.Text = travelInfo.GetEstimatedArrivalTime() + " Station Eindhoven";
            }
            else
            {
                lbArrivalTime.Text = "00:00 Station";
            }

            lbArrivalTrack.Text = "Track " + travelInfo.GetArrivalTrack();
            lbDelayArrival.Text = travelInfo.GetDelayArrival();

            if (lbDelayArrival.Text != "0")
            {
                lbDelayArrival.Visible = true;
            }

            lbTransfer.Text = "Transfer: " + travelInfo.GetTransferInformation();
        }
    }
}
