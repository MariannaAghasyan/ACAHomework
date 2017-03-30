using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseFilter> filters = DataIO.FilterInput();

            List<Student> students = DataIO.DataInput();
            List <Student> filterdStudents = new List<Student>();
            
            foreach (Student st in students)
            {
                Boolean include = true;

                foreach (BaseFilter bf in filters)
                {
                    if (!bf.GetLambda()(st))
                    {
                        include = false;
                        break;
                    }
                }

                if (include)
                {
                    filterdStudents.Add(st);
                }
            }
            //
            DataIO.DataOutput(filterdStudents);
        }

    }
}
