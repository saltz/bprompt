using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace SparkyTheSmartClock
{
    class TravelInfo
    {
        private string xml;
        private string xmlArrivalTrack;

        public TravelInfo(string xml) // Constructor
        {
            this.xml = xml;
            //int endOfTrip = this.xml.IndexOf("</ReisMogelijkheid>") + 19;
            //this.xml = this.xml.Substring(endOfTrip); // Delete one trip out of the xml
            this.xmlArrivalTrack = xml;
            //int endOfTrip2 = this.xmlArrivalTrack.IndexOf("</ReisMogelijkheid>") + 19;
            //this.xmlArrivalTrack = this.xmlArrivalTrack.Substring(endOfTrip2); // Delete one trip out of the xmlArrivalTrack
        }

        public string GetDate()
        {
            if (xml.IndexOf("<GeplandeVertrekTijd>") != -1)
            {
                int start = xml.IndexOf("<GeplandeVertrekTijd>") + 21;
                int end = xml.IndexOf("</GeplandeVertrekTijd>") - 14;
                int difference = end - start;

                string answer = xml.Substring(start, difference); // Get the needed info

                return answer;
            }
            else
            {
                string invalid = "";
                return invalid;
            }
        }

        public string GetEstimatedDepartureTime()
        {
            if (xml.IndexOf("<GeplandeVertrekTijd>") != -1)
            {
                int start = xml.IndexOf("<GeplandeVertrekTijd>") + 32;
                int end = xml.IndexOf("</GeplandeVertrekTijd>") - 8;
                int difference = end - start;

                string answer = xml.Substring(start, difference); // Get the needed info

                return answer;
            }
            else
            {
                string invalid = "00:00";
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
                string invalid = "";
                return invalid;
            }
        }

        public string GetArrivalTrack()
        {
            if (xmlArrivalTrack.IndexOf("<Spoor wijziging=\"false\">") != -1 || xmlArrivalTrack.IndexOf("<Spoor wijziging=\"true\">") != -1)
            {
                int endOfTrip = xmlArrivalTrack.IndexOf("<Naam>Eindhoven</Naam>") + 22;
                xmlArrivalTrack = xmlArrivalTrack.Substring(endOfTrip); // Delete the current trip out of the xmlTrack

                int start;

                if (xmlArrivalTrack.IndexOf("<Spoor wijziging=\"true\">") != -1 && xmlArrivalTrack.IndexOf("<Spoor wijziging=\"false\">") < xmlArrivalTrack.IndexOf("<Spoor wijziging=\"true\">"))
                {
                    start = xmlArrivalTrack.IndexOf("<Spoor wijziging=\"false\">") + 25;
                }
                else if (xmlArrivalTrack.IndexOf("<Spoor wijziging=\"true\">") == -1)
                {
                    start = xmlArrivalTrack.IndexOf("<Spoor wijziging=\"false\">") + 25;
                }
                else
                {
                    start = xmlArrivalTrack.IndexOf("<Spoor wijziging=\"true\">") + 24;
                }

                int end = xmlArrivalTrack.IndexOf("</Spoor>");
                int difference = end - start;

                string answer = xmlArrivalTrack.Substring(start, difference); // Get the needed info

                return answer;
            }
            else
            {
                string invalid = "";
                return invalid;
            }
        }

        public string GetEstimatedArrivalTime()
        {
            if (xml.IndexOf("<GeplandeAankomstTijd>") != -1)
            {
                int start = xml.IndexOf("<GeplandeAankomstTijd>") + 33;
                int end = xml.IndexOf("</GeplandeAankomstTijd>") - 8;
                int difference = end - start;

                string answer = xml.Substring(start, difference); // Get the needed info

                return answer;
            }
            else
            {
                string invalid = "00:00";
                return invalid;
            }
        }

        public string GetDelayDeparture()
        {
            if (xml.IndexOf("<VertrekVertraging>") != -1 && xml.IndexOf("<VertrekVertraging>") < xml.IndexOf("<Naam>"))
            {
                int start = xml.IndexOf("<VertrekVertraging>") + 19;
                int end = xml.IndexOf("</VertrekVertraging>");
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

        public string GetDelayArrival()
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

        public string GetDepartureName()
        {
            if (xml.IndexOf("<Naam>") != -1)
            {
                int start = xml.IndexOf("<Naam>") + 6;
                int end = xml.IndexOf("</Naam>");
                int difference = end - start;

                string answer = xml.Substring(start, difference); // Get the needed info

                return answer;
            }
            else
            {
                string invalid = "INVALID!";
                return invalid;
            }
        }

        public string GetTravelMode()
        {
            if (xml.IndexOf("<VervoerType>") != -1)
            {
                int start = xml.IndexOf("<VervoerType>") + 13;
                int end = xml.IndexOf("</VervoerType>");
                int difference = end - start;

                string answer = xml.Substring(start, difference); // Get the needed info

                return answer;
            }
            else
            {
                string invalid = "";
                return invalid;
            }
        }

        public string GetTravelTime()
        {
            if (xml.IndexOf("<ActueleReisTijd>") != -1)
            {
                int start = xml.IndexOf("<ActueleReisTijd>") + 17;
                int end = xml.IndexOf("</ActueleReisTijd>");
                int difference = end - start;

                string answer = xml.Substring(start, difference); // Get the needed info

                return answer;
            }
            else
            {
                string invalid = "";
                return invalid;
            }
        }

        public string GetTransporter()
        {
            if (xml.IndexOf("<Vervoerder>") != -1)
            {
                int start = xml.IndexOf("<Vervoerder>") + 12;
                int end = xml.IndexOf("</Vervoerder>");
                int difference = end - start;

                string answer = xml.Substring(start, difference); // Get the needed info

                return answer;
            }
            else
            {
                string invalid = "";
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

                return answer;
            }
            else
            {
                string invalid = "";
                return invalid;
            }
        }
    }
}
