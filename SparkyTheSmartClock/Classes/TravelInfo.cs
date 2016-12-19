using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyTheSmartClock
{
    class TravelInfo
    {
        private string xml;
        private string xmlDepartureTime;
        private string xmlDepartureTrack;
        private string xmlEstimatedArrivalTime;
        private string xmlActualArrivalTime;
        private string xmlTransfer;
        private string xmlDelay;

        public TravelInfo(string xml) // Constructor
        {
            this.xml = xml;
            this.xmlDepartureTime = xml;
            this.xmlDepartureTrack = xml;
            this.xmlEstimatedArrivalTime = xml;
            this.xmlActualArrivalTime = xml;
            this.xmlTransfer = xml;
            this.xmlDelay = xml;
        }

        public string GetDepartureTime()
        {
            if (xmlDepartureTime.IndexOf("<ActueleVertrekTijd>") != -1)
            {
                int start = xmlDepartureTime.IndexOf("<ActueleVertrekTijd>") + 20;
                int end = xmlDepartureTime.IndexOf("</ActueleVertrekTijd>") - 5;
                int difference = end - start;

                string answer = xmlDepartureTime.Substring(start, difference); // Get the needed info

                int endOfTrip = xmlDepartureTime.IndexOf("</ReisMogelijkheid>") + 19;
                xmlDepartureTime = xmlDepartureTime.Substring(endOfTrip); // Delete the current trip out of the string

                return answer;
            }
            else
            {
                string invalid = "INVALID INFORMATION!";
                return invalid;
            }
        }

        public string GetDepartureTrack()
        {
            if (xmlDepartureTrack.IndexOf("<Spoor wijziging=\"false\">") != -1 || xmlDepartureTrack.IndexOf("<Spoor wijziging=\"true\">") != -1)
            {
                int start;

                if (xmlDepartureTrack.IndexOf("<Spoor wijziging=\"true\">") != -1 && xmlDepartureTrack.IndexOf("<Spoor wijziging=\"false\">") < xmlDepartureTrack.IndexOf("<Spoor wijziging=\"true\">"))
                {
                    start = xmlDepartureTrack.IndexOf("<Spoor wijziging=\"false\">") + 25;
                }
                else if (xmlDepartureTrack.IndexOf("<Spoor wijziging=\"true\">") == -1)
                {
                    start = xmlDepartureTrack.IndexOf("<Spoor wijziging=\"false\">") + 25;
                }
                else
                {
                    start = xmlDepartureTrack.IndexOf("<Spoor wijziging=\"true\">") + 24;
                }

                int end = xmlDepartureTrack.IndexOf("</Spoor>");
                int difference = end - start;

                string answer = xmlDepartureTrack.Substring(start, difference); // Get the needed info

                int endOfTrip = xmlDepartureTrack.IndexOf("</ReisMogelijkheid>") + 19;
                xmlDepartureTrack = xmlDepartureTrack.Substring(endOfTrip); // Delete the current trip out of the string

                return answer;
            }
            else
            {
                string invalid = "INVALID INFORMATION!";
                return invalid;
            }
        }

        public string GetEstimatedArrivalTime()
        {
            if (xmlEstimatedArrivalTime.IndexOf("<GeplandeAankomstTijd>") != -1)
            {
                int start = xmlEstimatedArrivalTime.IndexOf("<GeplandeAankomstTijd>") + 22;
                int end = xmlEstimatedArrivalTime.IndexOf("</GeplandeAankomstTijd>") - 5;
                int difference = end - start;

                string answer = xmlEstimatedArrivalTime.Substring(start, difference); // Get the needed info

                int endOfTrip = xmlEstimatedArrivalTime.IndexOf("</ReisMogelijkheid>") + 19;
                xmlEstimatedArrivalTime = xmlEstimatedArrivalTime.Substring(endOfTrip); // Delete the current trip out of the string

                return answer;
            }
            else
            {
                string invalid = "INVALID INFORMATION!";
                return invalid;
            }
        }

        public string GetDelayInformation()
        {
            if (xmlDelay.IndexOf("<AankomstVertraging>") != -1 && xmlDelay.IndexOf("<AankomstVertraging>") < xmlDelay.IndexOf("</ReisMogelijkheid>"))
            {
                int start = xmlDelay.IndexOf("<AankomstVertraging>") + 20;
                int end = xmlDelay.IndexOf("</AankomstVertraging>");
                int difference = end - start;

                string answer = xmlDelay.Substring(start, difference); // Get the needed info

                int endOfTrip = xmlDelay.IndexOf("</ReisMogelijkheid>") + 19;
                xmlDelay = xmlDelay.Substring(endOfTrip); // Delete the current trip out of the string

                return answer;
            }
            else
            {
                if (xmlDelay.IndexOf("</ReisMogelijkheid>") != -1)
                {
                    int endOfTrip = xmlDelay.IndexOf("</ReisMogelijkheid>") + 19;
                    xmlDelay = xmlDelay.Substring(endOfTrip);
                }

                string invalid = "0";
                return invalid;
            }
        }

        public string GetActualArrivalTime()
        {
            if (xmlActualArrivalTime.IndexOf("<ActueleAankomstTijd>") != -1)
            {
                int start = xmlActualArrivalTime.IndexOf("<ActueleAankomstTijd>") + 21;
                int end = xmlActualArrivalTime.IndexOf("</ActueleAankomstTijd>") - 5;
                int difference = end - start;

                string answer = xmlActualArrivalTime.Substring(start, difference); // Get the needed info

                int endOfTrip = xmlActualArrivalTime.IndexOf("</ReisMogelijkheid>") + 19;
                xmlActualArrivalTime = xmlActualArrivalTime.Substring(endOfTrip); // Delete the current trip out of the string

                return answer;
            }
            else
            {
                string invalid = "INVALID INFORMATION!";
                return invalid;
            }
        }

        public string GetTransferInformation()
        {
            if (xmlTransfer.IndexOf("<AantalOverstappen>") != -1)
            {
                int start = xmlTransfer.IndexOf("<AantalOverstappen>") + 19;
                int end = xmlTransfer.IndexOf("</AantalOverstappen");
                int difference = end - start;

                string answer = xmlTransfer.Substring(start, difference); // Get the needed info

                int endOfTrip = xmlTransfer.IndexOf("</ReisMogelijkheid>") + 19; 
                xmlTransfer = xmlTransfer.Substring(endOfTrip); // Delete the current trip out of the string

                return answer;
            }
            else
            {
                string invalid = "INVALID INFORMATION!";
                return invalid;
            }
        }
    }
}
