using System;
using System.Text;

namespace MyLibrary
{
    /// <summary>
    /// Generate odd numbers in ascending order within a range
    /// </summary>
    public class OddNumbersGenerator : INumbersGenerator
    {
        public IRange Range { get; set; }

        public string GenerateOutput()
        {
            var builder = new StringBuilder();
            var min = Range.lower.IsOdd() ? Range.lower : Range.lower + 1;
            var max = Range.upper.IsOdd() ? Range.upper : Range.upper - 1;
            for (var i = min; i <= max; i++)
            {
                builder.Append(i.IsOdd() ? i.ToString() : ", ");
            }

            return builder.ToString();
        }
    }
}