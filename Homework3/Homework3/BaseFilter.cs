using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    /// <summary>
    /// Represent filter for students
    /// </summary>
    public abstract class BaseFilter
    {
        public abstract Func<Student, Boolean> GetLambda();
    }
  
}

