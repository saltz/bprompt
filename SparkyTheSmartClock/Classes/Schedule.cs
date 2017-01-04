using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SparkyTheSmartClock
{
    class Schedule
    {
        List<Lesson> lessons = new List<Lesson>();

        public List<Lesson> Lessons { get { return lessons; } }


        public void AddLesson(Lesson lesson)
        {
            lessons.Add(lesson);
        }
    }
}
