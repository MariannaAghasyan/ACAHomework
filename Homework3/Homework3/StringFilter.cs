using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    /// <summary>
    /// Filter for String type attribute
    /// </summary>
    public class StringFilter : BaseFilter
    {
        /// <summary>
        /// Constracts filter for string
        /// </summary>
        /// <param name="subString"> sought substring</param>
        /// <param name="selector"> selector for string type field </param>
        public StringFilter(String subString, Func<Student, String> selector)
        {
            SubString = subString;
            Selector = selector;
        }

        /// <summary>
        /// Lambda function for string type filter
        /// </summary>
        /// <returns>filter's function</returns>
        public override Func<Student, Boolean> GetLambda()
        {
            return st => Selector(st).Contains(SubString);
        }

        /// <summary>
        /// sought substring
        /// </summary>
        public String SubString
        {
            get;
            private set;
        }

        /// <summary>
        /// selector function 
        /// </summary>
        public Func<Student, String> Selector
        {
            get;
            private set;
        }
    }
}
