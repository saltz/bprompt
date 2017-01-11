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
        DateTime departure;
        TimeSpan countDown;
        FontysAPI connection;
        Schedule schedule;
        string beginNextDay;
        bool mouseDrag = false;
        bool buttonClockCount = true;
        bool ampm = true;
        double xNewFirst = 75;
        double yNewFirst = 35;
        double xNewSeccond = 75;
        double yNewSeccond = 0;
        Pen penFirst = new Pen(Color.Red, 5);
        Pen penSeccond = new Pen(Color.Black, 5);
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
            string xml;
            string livingPlace = tbPlace.Text;
            string temp;
            double startTime;
            double arrivalTime;
            TravelInfo travelInfo;

            NsApiUrl = "http://webservices.ns.nl/ns-api-treinplanner?fromStation=" + livingPlace + "&toStation=Eindhoven" + "&dateTime=" + beginNextDay;

            using (WebClient wc = new WebClient()) // Get acces to the API and put the info in a string
            {
                wc.Credentials = new NetworkCredential("s_devries@live.nl", "dV9RLW82YRn-RJWezf-zr-Mtay-Z0Z2Ram2zPkqbs9qBd2GQzJcVNQ");
                xml = wc.DownloadString(NsApiUrl);
            }

            do
            {
                travelInfo = new TravelInfo(xml);

                try
                {
                    temp = beginNextDay.Substring((beginNextDay.IndexOf("T") + 1));
                    startTime = Convert.ToDouble(temp.Replace(':', ',')); // Putt start time of lessen in variable

                    // Minus 9min for traveltime from station ehv to fontys 
                    if (Convert.ToString(startTime).IndexOf(",") == -1)
                    {
                        startTime = startTime - 00.49;
                    }
                    else
                    {
                        startTime = startTime - 00.09;
                    }
                }
                catch (NullReferenceException)
                {
                    startTime = 1; // To get out of the Do-While loop if user is not logged in on Fontys
                    TimeCountDown.Stop();
                }

                arrivalTime = Convert.ToDouble(travelInfo.GetEstimatedArrivalTime().Replace(':', ',')); // Putt arrival time of train in variable

                if (arrivalTime < startTime)
                {
                    lbDelayDeparture.Visible = false;
                    lbDelayArrival.Visible = false;

                    // Put travel info in the labels
                    lbIntercitySprinter.Text = travelInfo.GetTravelMode();
                    lbTravelTime.Text = "Travel time: " + travelInfo.GetTravelTime();
                    lbTransporter.Text = "Transporter: " + travelInfo.GetTransporter();
                    lbDate.Text = "Date: " + travelInfo.GetDate();
                    lbDepartureTime.Text = travelInfo.GetEstimatedDepartureTime() + " Station " + travelInfo.GetDepartureName();
                    lbDepartureTrack.Text = "Track " + travelInfo.GetDepartureTrack();
                    lbDelayDeparture.Text = travelInfo.GetDelayDeparture();
                    lbArrivalTrack.Text = "Track " + travelInfo.GetArrivalTrack();
                    lbDelayArrival.Text = travelInfo.GetDelayArrival();
                    lbTransfer.Text = "Transfer: " + travelInfo.GetTransferInformation();

                    if (lbDelayDeparture.Text != "0")
                    {
                        lbDelayDeparture.Visible = true;
                    }

                    if (lbDelayArrival.Text != "0")
                    {
                        lbDelayArrival.Visible = true;
                    }

                    if (travelInfo.GetDepartureName() != "INVALID!")
                    {
                        lbArrivalTime.Text = travelInfo.GetEstimatedArrivalTime() + " Station Eindhoven";
                    }
                    else
                    {
                        lbArrivalTime.Text = "00:00 Station";
                    }

                    departure = travelInfo.GetActualDepartureTime(); // Departure time for the count down timer & School alarm

                    // Count down timer for the train  
                    TimeCountDown.Enabled = true;
                    TimeCountDown.Start();

                    UpdateCountDownTimer();
                }

                try
                {
                    int endOfTrip = xml.IndexOf("</ReisMogelijkheid>") + 19;
                    xml = xml.Substring(endOfTrip); // Delete one trip out of the xml
                }
                catch (ArgumentOutOfRangeException)
                {
                    arrivalTime = 25; // To get out of the Do-While loop if user didn't fill in his living place correctly 
                    TimeCountDown.Stop();
                }

            } while (arrivalTime < startTime);
        }

        private void UpdateCountDownTimer()
        {
            DateTime now = DateTime.Now;
            countDown = departure.Subtract(now);
            lbCountdown.Text = (countDown.Hours + (countDown.Days * 24)).ToString("00") + ":" + countDown.Minutes.ToString("00") + ":" + countDown.Seconds.ToString("00");
        }

        private void TimeCountDown_Tick(object sender, EventArgs e)
        {
            UpdateCountDownTimer();
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
                GetBeginTimeNextDay();
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
                    GetBeginTimeNextDay();
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

        private void GetBeginTimeNextDay()
        {
            int counter = 0;
            DateTime now = DateTime.Now;
            string beginHourToday = "";

            foreach (Lesson l in schedule.Lessons) // Get start hour today
            {
                if (l.start.Contains(now.ToString("yyyy-MM-dd")) && counter == 0)
                {
                    beginHourToday = l.start;
                    int T = beginHourToday.IndexOf('T') + 1;
                    beginHourToday = beginHourToday.Substring(T, 2);
                    counter++;
                }
                else if (counter == 0) // If today is no school
                {
                    beginHourToday = "1";
                    counter++;
                }
            }

            if (now.Hour >= Convert.ToInt32(beginHourToday)) // After start time today you will see the train info for the next school day
            {
                now = DateTime.Today.AddDays(1);
            }

            foreach (Lesson l in schedule.Lessons)
            {
                if (l.start.Contains(now.ToString("yyyy-MM-dd")) && counter == 1)
                {
                    beginNextDay = l.start;
                    beginNextDay = beginNextDay.Substring(0, (beginNextDay.LastIndexOf(':')));
                    counter++;
                }
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


        //tab2 settings tab

        private void MouseMoveAlarm(object sender, MouseEventArgs e)
        {
            if (mouseDrag && buttonClockCount)
            {
                double xclick = e.X;
                double yclick = e.Y;
                xclick -= 75;
                yclick -= 75;
                int hour = 0;

                xNewFirst = xclick / ((Math.Sqrt((xclick * xclick) + (yclick * yclick)) / 40));
                yNewFirst = yclick / ((Math.Sqrt((xclick * xclick) + (yclick * yclick)) / 40));
                try
                {
                    if (xNewFirst >= 0)
                    {
                        double newpoint = Math.Sqrt((xNewFirst * xNewFirst) + ((-40 - yNewFirst) * (-40 - yNewFirst))) / 2;
                        double rotation = Math.Asin(newpoint / 40);
                        hour = Convert.ToInt32(Math.Round((rotation * (180 / Math.PI) * 2) / (180 / 5.5), 0));
                    }
                    else
                    {
                        double newpoint = Math.Sqrt((xNewFirst * xNewFirst) + ((-40 + yNewFirst) * (-40 + yNewFirst))) / 2;
                        double rotation = Math.Asin(newpoint / 40);
                        hour = Convert.ToInt32(Math.Round(((rotation * (180 / Math.PI) * 2) / (180 / 5.5)) + (5.5), 0));
                    }
                }
                catch
                {

                }
                lbHour.Text = Convert.ToString(hour);
                yNewFirst += 75;
                xNewFirst += 75;
                pbAlarm.Invalidate();
            }

            else if (mouseDrag && buttonClockCount == false)
            {
                double xclick = e.X;
                double yclick = e.Y;
                xclick -= 75;
                yclick -= 75;
                int minutes = 0;

                xNewSeccond = xclick / ((Math.Sqrt((xclick * xclick) + (yclick * yclick)) / 75));
                yNewSeccond = yclick / ((Math.Sqrt((xclick * xclick) + (yclick * yclick)) / 75));
                try
                {
                    if (xNewSeccond >= 0)
                    {
                        double newpoint = Math.Sqrt((xNewSeccond * xNewSeccond) + ((-75 - yNewSeccond) * (-75 - yNewSeccond))) / 2;
                        double rotation = Math.Asin(newpoint / 75);
                        minutes = Convert.ToInt32((rotation * (180 / Math.PI) * 2) / (180 / 29.5));
                    }
                    else
                    {
                        double newpoint = Math.Sqrt((xNewSeccond * xNewSeccond) + ((-75 + yNewSeccond) * (-75 + yNewSeccond))) / 2;
                        double rotation = Math.Asin(newpoint / 75);
                        minutes = Convert.ToInt32(((rotation * (180 / Math.PI) * 2) / (180 / 29.5)) + (30));
                    }
                }
                catch
                {

                }

                lbMinute.Text = Convert.ToString(minutes);
                yNewSeccond += 75;
                xNewSeccond += 75;
                pbAlarm.Invalidate();
            }
        }

        private void MouseDownAlarm(object sender, MouseEventArgs e)
        {
            mouseDrag = true;
        }

        private void MouseUpAlarm(object sender, MouseEventArgs e)
        {
            mouseDrag = false;
        }

        private void PaintClock(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point outerpointfirst = new Point(Convert.ToInt32(xNewFirst), Convert.ToInt32(yNewFirst));
            Point outerpointseccond = new Point(Convert.ToInt32(xNewSeccond), Convert.ToInt32(yNewSeccond));
            Point centerpoint = new Point(75, 75);
            g.DrawLine(penSeccond, centerpoint, outerpointseccond);
            g.DrawLine(penFirst, centerpoint, outerpointfirst);
        }

        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            if (buttonClockCount)
            {
                btnSetAlarm.Text = "Confirm minutes";
                penFirst.Color = Color.Black;
                penSeccond.Color = Color.Red;
                buttonClockCount = false;
            }
            else
            {
                btnSetAlarm.Text = "Confirm Hour";
                penFirst.Color = Color.Red;
                penSeccond.Color = Color.Black;
                buttonClockCount = true;
            }
            pbAlarm.Invalidate();
        }

        private void AmPmClick(object sender, EventArgs e)
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
            string alarmSet = lbHour.Text + ":" + lbMinute.Text + ":00 " + btnAmPm.Text;
            DateTime currentAlarm = Convert.ToDateTime(alarmSet);
            CurrentAlarms.Add(currentAlarm);
            TimeCheckAlarm.Start();
            xNewFirst = 75;
            yNewFirst = 35;
            xNewSeccond = 75;
            yNewSeccond = 0;
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

        private void btnSetSchoolAlarm_Click(object sender, EventArgs e)
        {
            // Make sure the departure time is correct
            if (departure.Date == DateTime.Today.Date && lbCountdown.Text == "00:00:00" || departure.Day == 1 && departure.Month == 1 && departure.Year == 0001)
            {
                MessageBox.Show("Log in with your Fontys account and fill in a correct living place and show the travel info");
            }
            else // Departure time is correct
            {
                string prepTimeString = "";
                int prepTimeInt = Convert.ToInt32(nudPrepTime.Value);

                if (prepTimeInt == 0) // If no prep time is filled in
                {
                    MessageBox.Show("Please fill in your estimated prep time");
                }
                else
                {
                    if (prepTimeInt != 0 && prepTimeInt < 60) // If prep time is within 1 hour
                    {
                        prepTimeString = "00:" + prepTimeInt.ToString() + ":00";
                    }
                    else if (prepTimeInt >= 60 && prepTimeInt < 120) // If prep time is between 1 and 2 hours
                    {
                        prepTimeInt = prepTimeInt - 60;
                        prepTimeString = "01:" + prepTimeInt.ToString() + ":00";
                    }
                    else if (prepTimeInt >= 120 && prepTimeInt < 180) // If prep time is between 2 and 3 hours
                    {
                        prepTimeInt = prepTimeInt - 120;
                        prepTimeString = "02:" + prepTimeInt.ToString() + ":00";                        
                    }
                    else if (prepTimeInt >= 180 && prepTimeInt < 240) // If prep time is between 3 and 4 hours
                    {
                        prepTimeInt = prepTimeInt - 180;
                        prepTimeString = "03:" + prepTimeInt.ToString() + ":00";
                    }

                    DateTime prepTimeDateTime = Convert.ToDateTime(prepTimeString);
                    TimeSpan schoolAlarm = departure.Subtract(prepTimeDateTime);

                    string alarm = schoolAlarm.Hours.ToString("00") + ":" + schoolAlarm.Minutes.ToString("00") + ":" + schoolAlarm.Seconds.ToString("00");
                    MessageBox.Show("School alarm set on: " + alarm);
                }
            }
        }
    }
}

/*comments for later purposes

catch (System.ArgumentException ex) { MessageBox.Show(ex.Message, ex.Source); } sample of how to display the errors


*/
