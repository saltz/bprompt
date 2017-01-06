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
using Newtonsoft;
using Newtonsoft.Json;


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
        FontysAPI connection;
        Schedule schedule;

        private void NavClick(object sender, EventArgs e)
        {
            NavigationCalculation();
            if (menuNav.SelectedIndex == 1)
            {
                GetAccess();
            }
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

        //tab0 main tab for travel info

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


        //tab1 roster tab 

        private void GetAccess()
        {
            // if (User.School.ToLower().Contains("fontys"){ }    //if statement to initialize fhict api (if there are more api's)
            if (connection == null) //app firststartup (creation of the connection object)
            {
                connection = new FontysAPI();
                lblError.Visible = false;
                webBrowser.Visible = true;
                webBrowser.Navigate(connection.RequestString);
            }
            else if (connection.TimeAllive == 0) //accesstoken has expired
            {
                lblError.Visible = false;
                webBrowser.Visible = true;
                webBrowser.Navigate(connection.RequestString);
            }
            else //accesstoken is granted and alive no need to request another
            {
                BuildingTheSchedule();
            }
        }

        private void WebBrowserNavigated(object sender, WebBrowserNavigatedEventArgs e) //everytime the webbrowser loads a page
        {
            string redirectURL = "https://i363215.iris.fhict.nl";
            if (webBrowser.Url.ToString().Contains(redirectURL) && !webBrowser.Url.ToString().Contains("https://identity.fhict.nl")) //browser redirected correctly
            {
                webBrowser.Visible = false;
                string response = webBrowser.Url.ToString();
                if (connection.GetToken(response) == true) //user granted sparky permission to schedule data
                {
                    TimeAlliveTimer.Start();
                    HttpWebRequest request = WebRequest.Create("https://api.fhict.nl/schedule/me") as HttpWebRequest;
                    request.Method = "GET";
                    request.ContentType = "text/json";
                    request.Headers.Add("Authorization: Bearer " + connection.AccessToken);
                    var responseData = request.GetResponse() as HttpWebResponse;
                    StreamReader reader = new StreamReader(responseData.GetResponseStream());
                    string json = reader.ReadToEnd();
                    schedule = new Schedule();
                    schedule.ReadingTheJson(json);
                    BuildingTheSchedule();
                }
                else //user denied access no school schedule for him
                {
                    webBrowser.Navigate("");
                    webBrowser.Visible = false;
                    lblError.Visible = true;
                }
            }
            else
            {
                //code cannot get here. or the user is a hacker
            }
        }


        //needs editing
        private void BuildingTheSchedule()
        {
            listBox1.Visible = true;
            foreach (Lesson lesson in schedule.Lessons)
            {
                listBox1.Items.Add(lesson.subject);
                listBox1.Items.Add(lesson.room);
                listBox1.Items.Add(lesson.teacherAbbreviation);
                listBox1.Items.Add(lesson.start);
                listBox1.Items.Add("-------------------");
            }
            listBox1.Refresh();
        }

        private void TickTock(object sender, EventArgs e) //countdown for timealive of the accesstoken
        {
            if (connection.TimeAllive > 0)
            {
                connection.TimeAllive = connection.TimeAllive - 1;
            }
            else
            {
                TimeAlliveTimer.Stop();
            }
        }
    }
}

/*comments for later purposes

catch (System.ArgumentException ex) { MessageBox.Show(ex.Message, ex.Source); } sample of how to display the errors


*/
