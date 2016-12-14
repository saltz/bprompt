using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SparkyTheSmartClock
{
    class User
    {

        //fields

        //user info
        string firstname;
        string surname;
        string school;

        //user adres
        string streetName;
        int houseNumber;
        int postcodeNumber;
        string postcodeLetters;

        //properties
        public string Firstname
        {
            get { return firstname; }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    firstname = value;
                }
                else { }
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    surname = value;
                }
                else { }
            }
        }

        public string School { set; get; }
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public int PostcodeNumber
        {
            get { return postcodeNumber; }
            set
            {
                if (value.ToString().Length == 4)
                {
                    postcodeNumber = value;
                }
                else { }
            }
        }

        public string PostcodeLetters
        {
            get { return postcodeLetters; }
            set
            {
                if (Regex.IsMatch(value, @"^[A-Z]+$") && value.Length == 2)
                {
                    postcodeLetters = value;
                }
                else { }
            }
        }

        public string Adres
        {
            get
            {
                return postcodeLetters + postcodeNumber + houseNumber;
            }
        }

        //functions




        //constructors

        public User(string firstname, string surname, string school)
        {
            this.firstname = firstname;
            this.surname = surname;
            this.school = school;
        }
    }
}
