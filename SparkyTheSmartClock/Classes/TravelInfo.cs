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

        public TravelInfo(string xml) // Constructor
        {
            this.xml = xml;
        }

        public string GetDepartureTime()
        {
            if (xml.IndexOf("<ActueleVertrekTijd>") != -1)
            {
                int start = xml.IndexOf("<ActueleVertrekTijd>") + 20;
                int end = xml.IndexOf("</ActueleVertrekTijd>") - 5;
                int difference = end - start;

                string answer = xml.Substring(start, difference); // Get the needed info

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
            if (xml.IndexOf("<Spoor wijziging=\"false\">") != -1 || xml.IndexOf("<Spoor wijziging=\"true\">") != -1)
            {
                int start;

                if (xml.IndexOf("<Spoor wijziging=\"true\">") != -1 && xml.IndexOf("<Spoor wijziging=\"false\">") < xml.IndexOf("<Spoor wijziging=\"true\">"))
                {
                    start = xml.IndexOf("<Spoor wijziging=\"false\">") + 25;
                }
                else if (xml.IndexOf("<Spoor wijziging=\"true\">") == -1)
                {
                    start = xml.IndexOf("<Spoor wijziging=\"false\">") + 25;
                }
                else
                {
                    start = xml.IndexOf("<Spoor wijziging=\"true\">") + 24;
                }

                int end = xml.IndexOf("</Spoor>");
                int difference = end - start;

                string answer = xml.Substring(start, difference); // Get the needed info

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
            if (xml.IndexOf("<GeplandeAankomstTijd>") != -1)
            {
                int start = xml.IndexOf("<GeplandeAankomstTijd>") + 22;
                int end = xml.IndexOf("</GeplandeAankomstTijd>") - 5;
                int difference = end - start;

                string answer = xml.Substring(start, difference); // Get the needed info

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
            if (xml.IndexOf("<AankomstVertraging>") != -1 && xml.IndexOf("<AankomstVertraging>") < xml.IndexOf("</ReisMogelijkheid>"))
            {
                int start = xml.IndexOf("<AankomstVertraging>") + 20;
                int end = xml.IndexOf("</AankomstVertraging>");
                int difference = end - start;

                string answer = xml.Substring(start, difference); // Get the needed info

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
            if (xml.IndexOf("<ActueleAankomstTijd>") != -1)
            {
                int start = xml.IndexOf("<ActueleAankomstTijd>") + 21;
                int end = xml.IndexOf("</ActueleAankomstTijd>") - 5;
                int difference = end - start;

                string answer = xml.Substring(start, difference); // Get the needed info

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
            if (xml.IndexOf("<AantalOverstappen>") != -1)
            {
                int start = xml.IndexOf("<AantalOverstappen>") + 19;
                int end = xml.IndexOf("</AantalOverstappen");
                int difference = end - start;

                string answer = xml.Substring(start, difference); // Get the needed info

                int endOfTrip = xml.IndexOf("</ReisMogelijkheid>") + 19; 
                xml = xml.Substring(endOfTrip); // Delete the current trip out of the string

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
