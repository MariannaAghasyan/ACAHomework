using System;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    static class DataIO
    {
        /// <summary>
        /// Constracts Student List from given file.
        /// </summary>
        /// <returns>Student's list</returns>
        static public List<Student> DataInput()
        {
            IEnumerable<String> text = File.ReadLines(@"data\Students.xls");

            List<Student> students = new List<Student>();

            foreach (String st in text.Skip(1))
            {
                students.Add(new Student(st.Split('\t')));
            }

            return students;
        }

        /// <summary>
        /// Create file from given student's list
        /// </summary>
        /// <param name="students">student's list</param>
        static public void DataOutput(List<Student> students)
        {
            String text = "";
            foreach (Student st in students)
            {
                text += st.ToString();
            }
            File.WriteAllText(@"data\output.xls", text);
        }

        /// <summary>
        /// Projects each student onto Name
        /// </summary>
        static public Func<Student, String> NameSelector = st => st.Name;

        /// <summary>
        /// Projects each student onto surname
        /// </summary>
        static public Func<Student, String> SurnameSelector = st => st.Surname;

        /// <summary>
        /// Projects each student onto year of birth
        /// </summary>
        static public Func<Student, Int32> YearSelector = st => st.YearOfBirth;

        /// <summary>
        /// Projects each student onto number of known Programming Languages
        /// </summary>
        static public Func<Student, Int32> KnownSelector = st => st.NumberOfKnownProgLang;

        /// <summary>
        /// Projects each student onto phone number
        /// </summary>
        static public Func<Student, String> PhoneSelector = st => st.PhoneNumber;

        /// <summary>
        /// Constrcats Filters list from given file.
        /// </summary>
        /// <returns>Filter's list </returns>
        static public List<BaseFilter> FilterInput()
        {
            IEnumerable<String> text = File.ReadLines(@"data\Filters.xls");

            List<BaseFilter> filters = new List<BaseFilter>();
            String[][] currentRow = new String[5][];

            Int32 i = 0;

            foreach (String f in text)
            {
                currentRow[i] = f.Split('\t');
                i++;
            }
            
            filters.Add(new StringFilter(currentRow[0][0],NameSelector));

            filters.Add(new StringFilter(currentRow[1][0], SurnameSelector));

            filters.Add(new RangeFilter(Int32.Parse(currentRow[2][0]),
                                        Int32.Parse(currentRow[2][1]),
                                        YearSelector));

            filters.Add(new RangeFilter(Int32.Parse(currentRow[3][0]),
                                        Int32.Parse(currentRow[3][1]),
                                        KnownSelector));

            filters.Add(new StringFilter(currentRow[4][0], PhoneSelector));


            return filters;
        }


    }
}
