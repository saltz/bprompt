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

                int endOfTrip = urlDepartureTime.IndexOf("</ReisMogelijkheid>") + 19;
                urlDepartureTime = urlDepartureTime.Substring(endOfTrip);

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
            if (urlDepartureTrack.IndexOf("<Spoor wijziging=\"false\">") != -1 || urlDepartureTrack.IndexOf("<Spoor wijziging=\"true\">") != -1)
            {
                int start;

                if (urlDepartureTrack.IndexOf("<Spoor wijziging=\"true\">") != -1 && urlDepartureTrack.IndexOf("<Spoor wijziging=\"false\">") < urlDepartureTrack.IndexOf("<Spoor wijziging=\"true\">"))
                {
                    start = urlDepartureTrack.IndexOf("<Spoor wijziging=\"false\">") + 25;
                }
                else if (urlDepartureTrack.IndexOf("<Spoor wijziging=\"true\">") == -1)
                {
                    start = urlDepartureTrack.IndexOf("<Spoor wijziging=\"false\">") + 25;
                }
                else
                {
                    start = urlDepartureTrack.IndexOf("<Spoor wijziging=\"true\">") + 24;
                }

                int end = urlDepartureTrack.IndexOf("</Spoor>");
                int difference = end - start;

                string answer = urlDepartureTrack.Substring(start, difference);

                int endOfTrip = urlDepartureTrack.IndexOf("</ReisMogelijkheid>") + 19;
                urlDepartureTrack = urlDepartureTrack.Substring(endOfTrip);

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

                int endOfTrip = urlEstimatedArrivalTime.IndexOf("</ReisMogelijkheid>") + 19;
                urlEstimatedArrivalTime = urlEstimatedArrivalTime.Substring(endOfTrip);

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
            if (urlDelay.IndexOf("<AankomstVertraging>") != -1 && urlDelay.IndexOf("<AankomstVertraging>") < urlDelay.IndexOf("</ReisMogelijkheid>"))
            {
                int start = urlDelay.IndexOf("<AankomstVertraging>") + 20;
                int end = urlDelay.IndexOf("</AankomstVertraging>");
                int difference = end - start;

                string answer = urlDelay.Substring(start, difference);

                int endOfTrip = urlDelay.IndexOf("</ReisMogelijkheid>") + 19;
                urlDelay = urlDelay.Substring(endOfTrip);

                return answer;
            }
            else
            {
                int endOfTrip = urlDelay.IndexOf("</ReisMogelijkheid>") + 19;
                urlDelay = urlDelay.Substring(endOfTrip);
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

                int endOfTrip = urlActualArrivalTime.IndexOf("</ReisMogelijkheid>") + 19;
                urlActualArrivalTime = urlActualArrivalTime.Substring(endOfTrip);

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

                int endOfTrip = urlTransfer.IndexOf("</ReisMogelijkheid>") + 19;
                urlTransfer = urlTransfer.Substring(endOfTrip);

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
