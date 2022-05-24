using Xunit;

namespace MyLibrary.UnitTests
{
    public class UnitTests
    {
        [Fact]
        public void TestClass1()
        {
            const string expected = "1, 2, 3, 4, 5";
            var generator = new Class1();
            generator.SetRange(1, 5);
            var result = generator.GenerateOutput();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestOddNumbersGenerator()
        {
            const string expected = "1, 3, 5, 7, 9";
            var generator = new OddNumbersGenerator { Range = new Range(0, 10) };
            var result = generator.GenerateOutput();
            Assert.Equal(expected, result);
        }
    }
}
