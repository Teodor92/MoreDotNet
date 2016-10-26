namespace MoreDotNet.Tests.Extensions.Numeric.RomanNumeralExtensions
{
    using MoreDotNet.Extensions.Numeric;
    using Xunit;

    public class ToRomanNumeralStringTests
    {
        [Fact]
        public void ToRomanNumeralString_Given1_ShouldReturnI()
        {
            var expected = "I";
            var input = 1;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

    }
}
