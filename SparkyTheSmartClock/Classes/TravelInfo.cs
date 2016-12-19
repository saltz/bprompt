using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyTheSmartClock
{
    class TravelInfo
    {
        private DateTime beginTimeSchool;
        private string livingPlace;

        public TravelInfo(DateTime beginTimeSchool, string livingPlace)
        {
            this.beginTimeSchool = beginTimeSchool;
            this.livingPlace = livingPlace;
        }

        public DateTime GetBeginTimeSchool()
        {
            return beginTimeSchool;
        }

        public string GetLivingPlace()
        {
            return livingPlace;
        }
    }
}
