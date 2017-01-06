using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace SparkyTheSmartClock
{
    class Lesson //class for parsing json to objects
    {
        public IList<string> classes { get; set; }
        public string room { get; set; }
        public string subject { get; set; }
        public string teacherAbbreviation { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string uid { get; set; }
        public int hoursMask { get; set; }
    }
}
