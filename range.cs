using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // ●	Create a generic class named Range<T> where T represents the type of values.
    // ●	Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.
    internal class range<T> where T : IComparable<T>
    {
        #region ●	Create a generic class named Range<T> where T represents the type of values.

        public T min { get; set; }
        public T max { get; set; }

        #endregion

        public range(T _min, T _max)
        {
            max = _max;
            min = _min;
        }

        #region ●	Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.

        public bool IsInRange(T input)
        {
            return input.CompareTo(min) > 0 && input.CompareTo(max) < 0;
        }
        #endregion

        #region ●	Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).

        public T Length()
        {
            dynamic Max = max;
            dynamic Min = min;
            return Max - Min;
        }
        #endregion
    }
}
