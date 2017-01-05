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
        //fields
        List<Lesson> lessons = new List<Lesson>();
        string lessonString;
        int startPoint = 0;
        int endPoint = 0;

        //properties
        public List<Lesson> Lessons { get { return lessons; } }


        //methods
        public void ReadingTheJson(string inputString) //reading the json string 
        {
            for (int i = 0; i < inputString.Length; i++) //looping trough all the indiviual chars in the json string
            {
                char x = inputString[i];
                if (x == '{')
                {
                    startPoint = i;
                }
                else if (x == '}')
                {
                    endPoint = (i - startPoint);
                    lessonString = inputString.Substring(startPoint, endPoint); //substring the indivual lesson
                    if (lessonString.Contains("description")) // lessons with descriptions get another cut here (description is always empty so....)
                    {
                        lessonString = lessonString.Substring(0, lessonString.IndexOf("description") - 2);
                        lessonString = lessonString + "}";
                        Lesson lesson = JsonConvert.DeserializeObject<Lesson>(lessonString);
                        lessons.Add(lesson);
                    }
                    else if (lessonString.Contains("updatedAt")) // some lessons dont have descriptions get cut here.
                    {
                        lessonString = lessonString.Substring(0, lessonString.IndexOf("updatedAt") - 2);
                        lessonString = lessonString + "}";
                        Lesson lesson = JsonConvert.DeserializeObject<Lesson>(lessonString);
                        lessons.Add(lesson);
                    }
                    else
                    {
                        // if the code gets here something went wrong.
                    }
                }
            }
        }
    }
}
