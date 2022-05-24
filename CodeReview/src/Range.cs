using System;

namespace MyLibrary
{
    public class Range : IRange
    {
        public int lower { get; private set; }
        public int upper { get; private set; }

        public Range(int lower, int upper)
        {
            if (lower <= upper)
            {
                this.lower = lower;
                this.upper = upper;
            }
            else
            {
                throw new ArgumentException("The lower value should be less than the upper value.");
            }
        }
    }
}