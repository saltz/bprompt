using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyTheSmartClock
{
    class TravelInfo
    {
        private string url;
        private string urlDepartureTime;
        private string urlDepartureTrack;
        private string urlEstimatedArrivalTime;
        private string urlActualArrivalTime;
        private string urlTransfer;
        private string urlDelay;

        public TravelInfo(string url)
        {
            this.url = url;
            this.urlDepartureTime = url;
            this.urlDepartureTrack = url;
            this.urlEstimatedArrivalTime = url;
            this.urlActualArrivalTime = url;
            this.urlTransfer = url;
            this.urlDelay = url;
        }

        public string GetDepartureTime()
        {
            if (urlDepartureTime.IndexOf("<ActueleVertrekTijd>") != -1)
            {
                int start = urlDepartureTime.IndexOf("<ActueleVertrekTijd>") + 20;
                int end = urlDepartureTime.IndexOf("</ActueleVertrekTijd>") - 5;
                int difference = end - start;

                string answer = urlDepartureTime.Substring(start, difference);

                urlDepartureTime = urlDepartureTime.Substring(end + 25);

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
            if (urlDepartureTrack.IndexOf("<Spoor wijziging=\"false\">") != -1)
            {
                int start = urlDepartureTrack.IndexOf("<Spoor wijziging=\"false\">") + 25;
                int end = urlDepartureTrack.IndexOf("</Spoor>");
                int difference = end - start;

                string answer = urlDepartureTrack.Substring(start, difference);

                urlDepartureTrack = urlDepartureTrack.Substring(end + 500);

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
            if (urlEstimatedArrivalTime.IndexOf("<GeplandeAankomstTijd>") != -1)
            {
                int start = urlEstimatedArrivalTime.IndexOf("<GeplandeAankomstTijd>") + 22;
                int end = urlEstimatedArrivalTime.IndexOf("</GeplandeAankomstTijd>") - 5;
                int difference = end - start;

                string answer = urlEstimatedArrivalTime.Substring(start, difference);

                urlEstimatedArrivalTime = urlEstimatedArrivalTime.Substring(end + 25);

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
            if (urlDelay.IndexOf("<AankomstVertraging>") != -1)
            {
                int start = urlDelay.IndexOf("<AankomstVertraging>") + 20;
                int end = urlDelay.IndexOf("</AankomstVertraging>");
                int difference = end - start;

                string answer = urlDelay.Substring(start, difference);

                urlDelay = urlDelay.Substring(end + 25);

                return answer;
            }
            else
            {
                string invalid = "0";
                return invalid;
            }
        }

        public string GetActualArrivalTime()
        {
            if (urlActualArrivalTime.IndexOf("<ActueleAankomstTijd>") != -1)
            {
                int start = urlActualArrivalTime.IndexOf("<ActueleAankomstTijd>") + 21;
                int end = urlActualArrivalTime.IndexOf("</ActueleAankomstTijd>") - 5;
                int difference = end - start;

                string answer = urlActualArrivalTime.Substring(start, difference);

                urlActualArrivalTime = urlActualArrivalTime.Substring(end + 25);

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
            if (urlTransfer.IndexOf("<AantalOverstappen>") != -1)
            {
                int start = urlTransfer.IndexOf("<AantalOverstappen>") + 19;
                int end = urlTransfer.IndexOf("</AantalOverstappen");
                int difference = end - start;

                string answer = urlTransfer.Substring(start, difference);

                urlTransfer = urlTransfer.Substring(end + 25);

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
