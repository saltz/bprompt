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
                else
                {
                    throw new ArgumentException("Maak alleen gebruik van letters aub", "Field FirstName"); //return error when (if) requirment is incorrect
                }
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
                else
                {
                    throw new ArgumentException("Maak alleen gebruik van letters aub", "Field SurName"); //temp
                }
            }
        }

        public string School { get { return school; } set { school = value; } }
        public string StreetName { get { return streetName; } set { streetName = value; } }
        public int HouseNumber { get { return houseNumber; } set { houseNumber = value; } }

        public int PostcodeNumber
        {
            get { return postcodeNumber; }
            set
            {
                if (value.ToString().Length == 4)
                {
                    postcodeNumber = value;
                }
                else
                {
                    throw new ArgumentException("Voer aub alleen de 4 cijfers in", "Field PostcodeNumbers"); //temp
                }
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
                else
                {
                    throw new ArgumentException("voer aub alleen de 2 letters in", "Field PostcodeLetters"); //temp
                }
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
        public User() { } //empty contrsuctor

        public User(string firstname, string surname, string school) //user info only
        {
            Firstname = firstname;
            Surname = surname;
            School = school;
        }

        public User(string firstname, string surname, string school, string strname, int hsnmbr, int ptcode, string ptltrs) //all in-one 
        {
            Firstname = firstname;
            Surname = surname;
            School = school;
            StreetName = strname;
            HouseNumber = hsnmbr;
            PostcodeNumber = ptcode;
            PostcodeLetters = ptltrs;
        }
    }
}
