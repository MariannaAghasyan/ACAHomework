using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    /// <summary>
    /// Represent student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Contrsct student by given info.
        /// </summary>
        public Student(String name, 
                       String surname,
                       Int32 year,
                       Int32 knownLangCount,
                       String phone)
        {
            Name = name;
            Surname = surname;
            YearOfBirth = year;
            NumberOfKnownProgLang = knownLangCount;
            PhoneNumber = phone;
        }

        /// <summary>
        /// Constract student by given string array.
        /// </summary>
        /// <param name="text">student properties repersented in string</param>
        public Student(String[] text)
        {
            Name = text[0];
            Surname = text[1];
            YearOfBirth = Int32.Parse(text[2]);
            NumberOfKnownProgLang = Int32.Parse(text[3]);
            PhoneNumber = text[4];
        }

        /// <summary>
        /// student name
        /// </summary>
        public String Name
        {
            get;
            private set;
        }

        /// <summary>
        /// student surname
        /// </summary>
        public String Surname
        {
            get;
            private set;
        }

        /// <summary>
        /// student birth year
        /// </summary>
        public Int32 YearOfBirth
        {
            get;
            private set;
        }

        /// <summary>
        /// student's known programming languages count
        /// </summary>
        public Int32 NumberOfKnownProgLang
        {
            get;
            private set;
        }

        /// <summary>
        /// student phone number represented by string
        /// </summary>
        public String PhoneNumber
        {
            get;
            private set;
        }

        /// <summary>
        /// Convert student into string
        /// </summary>
        /// <returns> student's string </returns>
        public override string ToString()
        {
            return Name + '\t' +
                Surname + '\t' +
                YearOfBirth.ToString() + '\t' +
                NumberOfKnownProgLang.ToString() +  '\t' +
                PhoneNumber + '\n';
        }
    }
}
