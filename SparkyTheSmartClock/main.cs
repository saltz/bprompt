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

        //globals ruben nakijken bitte
        bool mousedrag = false;
        bool buttonclockcount = true;
        bool ampm = true;
        double xnewfirst = 75;
        double ynewfirst = 35;
        double xnewseccond = 75;
        double ynewseccond = 0;
        int minutes = 0;
        int hour = 0;
        Pen penfirst = new Pen(Color.Red, 5);
        Pen penseccond = new Pen(Color.Black, 5);
        List<DateTime> CurrentAlarms = new List<DateTime>();

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
                gettime();// <------------------------------------------------------------------------------------------------------------- sven here
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
                    gettime(); //getting first lesson <------------------------------------------------------------------------------------------------ sven here
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

        //tab2 rubens tabje

        private void MouseMoveAlarm(object sender, MouseEventArgs e)
        {
            if (mousedrag && buttonclockcount)
            {
                double xclick = e.X;
                double yclick = e.Y;
                xclick -= 75;
                yclick -= 75;

                xnewfirst = xclick / ((Math.Sqrt((xclick * xclick) + (yclick * yclick)) / 40));
                ynewfirst = yclick / ((Math.Sqrt((xclick * xclick) + (yclick * yclick)) / 40));
                try
                {
                    if (xnewfirst >= 0)
                    {
                        double newpoint = Math.Sqrt((xnewfirst * xnewfirst) + ((-40 - ynewfirst) * (-40 - ynewfirst))) / 2;
                        double rotation = Math.Asin(newpoint / 40);
                        hour = Convert.ToInt32(Math.Round((rotation * (180 / Math.PI) * 2) / (180 / 5.5), 0));
                    }
                    else
                    {
                        double newpoint = Math.Sqrt((xnewfirst * xnewfirst) + ((-40 + ynewfirst) * (-40 + ynewfirst))) / 2;
                        double rotation = Math.Asin(newpoint / 40);
                        hour = Convert.ToInt32(Math.Round(((rotation * (180 / Math.PI) * 2) / (180 / 5.5)) + (5.5), 0));
                    }
                }
                catch
                {

                }
                lbHour.Text = Convert.ToString(hour);
                ynewfirst += 75;
                xnewfirst += 75;
                pbAlarm.Invalidate();
            }

            else if (mousedrag && buttonclockcount == false)
            {

                double xclick = e.X;
                double yclick = e.Y;
                xclick -= 75;
                yclick -= 75;
                xnewseccond = xclick / ((Math.Sqrt((xclick * xclick) + (yclick * yclick)) / 75));
                ynewseccond = yclick / ((Math.Sqrt((xclick * xclick) + (yclick * yclick)) / 75));
                try
                {
                    if (xnewseccond >= 0)
                    {
                        double newpoint = Math.Sqrt((xnewseccond * xnewseccond) + ((-75 - ynewseccond) * (-75 - ynewseccond))) / 2;
                        double rotation = Math.Asin(newpoint / 75);
                        minutes = Convert.ToInt32((rotation * (180 / Math.PI) * 2) / (180 / 29.5));
                    }
                    else
                    {
                        double newpoint = Math.Sqrt((xnewseccond * xnewseccond) + ((-75 + ynewseccond) * (-75 + ynewseccond))) / 2;
                        double rotation = Math.Asin(newpoint / 75);
                        minutes = Convert.ToInt32(((rotation * (180 / Math.PI) * 2) / (180 / 29.5)) + (30));
                    }
                }
                catch
                {

                }

                lbMinute.Text = Convert.ToString(minutes);
                ynewseccond += 75;
                xnewseccond += 75;
                pbAlarm.Invalidate();
            }
        }

        private void MouseDownAlarm(object sender, MouseEventArgs e)
        {
            mousedrag = true;
        }

        private void MouseUpAlarm(object sender, MouseEventArgs e)
        {
            mousedrag = false;
        }

        private void PaintClock(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point outerpointfirst = new Point(Convert.ToInt32(xnewfirst), Convert.ToInt32(ynewfirst));
            Point outerpointseccond = new Point(Convert.ToInt32(xnewseccond), Convert.ToInt32(ynewseccond));
            Point centerpoint = new Point(75, 75);
            g.DrawLine(penseccond, centerpoint, outerpointseccond);
            g.DrawLine(penfirst, centerpoint, outerpointfirst);
        }

        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            if (buttonclockcount)
            {
                btnSetAlarm.Text = "Confirm minutes";
                penfirst.Color = Color.Black;
                penseccond.Color = Color.Red;
                buttonclockcount = false;
            }
            else
            {
                btnSetAlarm.Text = "Confirm Hour";
                penfirst.Color = Color.Red;
                penseccond.Color = Color.Black;
                buttonclockcount = true;
            }
            pbAlarm.Invalidate();
        }

        private void AmPmclick(object sender, EventArgs e)
        {
            if (ampm)
            {
                btnAmPm.Text = "PM";
                ampm = false;
            }
            else
            {
                btnAmPm.Text = "AM";
                ampm = true;
            }
        }

        private void btnConfirmAlarm_Click(object sender, EventArgs e)
        {
            string alarmset = lbHour.Text + ":" + lbMinute.Text + ":00 " + btnAmPm.Text;
            DateTime currentalarm = Convert.ToDateTime(alarmset);
            CurrentAlarms.Add(currentalarm);
            TimeCheckAlarm.Start();
            xnewfirst = 75;
            ynewfirst = 35;
            xnewseccond = 75;
            ynewseccond = 0;
            lbHour.Text = "0";
            lbMinute.Text = "0";
            MessageBox.Show("Alarm succefully added");
            pbAlarm.Invalidate();
        }

        private void btnCurrentAlarms_Click(object sender, EventArgs e)
        {
            foreach (DateTime alarm in CurrentAlarms)
            {
                int truefalse = DateTime.Now.CompareTo(alarm);
                MessageBox.Show(Convert.ToString(truefalse) + " " + alarm.ToString());
            }
        }

        private void AlarmCheck(object sender, EventArgs e)
        {
            int alarmindex = 0;
            try
            {
                foreach (DateTime alarm in CurrentAlarms)
                {
                    int truefalse = DateTime.Now.CompareTo(alarm);
                    if (truefalse > 0)
                    {
                        CurrentAlarms.RemoveAt(alarmindex);
                        MessageBox.Show("ALARMMM FUUUUUUCK");
                    }
                    else
                    {
                        alarmindex++;
                    }
                }
            }
            catch
            {

            }
        }

        private void gettime()
        {
            int counter = 0;
            foreach (Lesson l in schedule.Lessons)
            {
                if(l.start.Contains("2017-01-10") && counter == 0)
                {
                    MessageBox.Show(l.start + l.subject + l.teacherAbbreviation);
                    counter++;
                }
            }

        }
    }
}

/*comments for later purposes

catch (System.ArgumentException ex) { MessageBox.Show(ex.Message, ex.Source); } sample of how to display the errors


*/
