using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class RangeFilter : BaseFilter
    {
        /// <summary>
        /// Constracts Range filter by given range bounds and seletor
        /// </summary>
        /// <param name="lowBound"> Range lower bound </param>
        /// <param name="upBound"> range uper bound </param>
        /// <param name="selector"> selector </param>
        public RangeFilter(Int32 lowBound,
                    Int32 upBound,
                    Func<Student, Int32> selector)
        {
            LowBound = lowBound;
            UpBound = upBound;
            Selector = selector;
        }

        /// <summary>
        /// Lambda function for string type filter
        /// </summary>
        /// <returns>filter's function</returns>
        public override Func<Student, Boolean> GetLambda()
        {
            return st => (LowBound <= Selector(st) && Selector(st) <= UpBound);
        }

        /// <summary>
        /// Range lowerbound
        /// </summary>
        public Int32 LowBound
        {
            get;
            private set;
        }

        /// <summary>
        /// Range uperBound
        /// </summary>
        public Int32 UpBound
        {
            get;
            private set;
        }

        /// <summary>
        /// seletor function
        /// </summary>
        public Func<Student, Int32> Selector
        {
            get;
            private set;
        }
    };
}
