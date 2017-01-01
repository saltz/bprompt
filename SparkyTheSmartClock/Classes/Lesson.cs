using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyTheSmartClock
{
    class Lesson
    {
        string room;
        string subject;
        string teacherAbberviation;
        DateTime start;
        DateTime end;
        int hoursMark;


        public string Room { get { return room; } set { room = value; } }
        public string Subject { get { return subject; } set { subject = value; } }
        public string TeacherAbbreviation { get { return teacherAbberviation; } set { teacherAbberviation = value; } }
        public DateTime Start { get { return start; } set { start = value; } }
        public DateTime End { get { return end; } set { end = value; } }
        public int HoursMark { get { return hoursMark; } set { hoursMark = value; } }



        public override string ToString()
        {
            return "room = " + room + "les = " + subject + "Teacher = " + teacherAbberviation + "Start = " + start + "End = " + end + "length = " + hoursMark;
        }
    }
}
