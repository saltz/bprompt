using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyTheSmartClock
{
    class FontysAPI
    {
        //fields
        string requestString = "https://identity.fhict.nl/connect/authorize?client_id=i363215-spary&scope=fhict%20fhict_personal&response_type=token&redirect_uri=https://i363215.iris.fhict.nl/";
        string accessToken;
        int timeAllive = 0;

        //Properties
        public string RequestString { get { return requestString; } }
        public string AccessToken { get { return accessToken; } set { accessToken = value; } }
        public int TimeAllive { get { return timeAllive; } set { timeAllive = value; } }
        //functions
        public bool GetToken(string response)
        {
            string token = response.Substring(response.IndexOf("=") + 1);
            if (token.Contains("&"))
            {
                token = token.Substring(0, token.IndexOf("&"));
                if (token.Contains("access_denied"))
                {
                    return false;
                }
                else
                {
                    this.accessToken = token;
                    return true;
                }
            }
            else
            {
                if (token.Contains("access_denied"))
                {
                    return false;
                }
                else
                {
                    this.accessToken = token;
                    return true;
                }
            }
        }
    }
}
