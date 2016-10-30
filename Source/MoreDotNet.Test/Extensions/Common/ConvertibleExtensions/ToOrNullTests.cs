namespace MoreDotNet.Tests.Extensions.Common.ConvertibleExtensions
{
    using System.Drawing;
    using MoreDotNet.Extensions.Common;
    using Xunit;

    public class ToOrNullTests
    {
        [Fact]
        public void ToOrNull_ConversionSucceeded_ShouldChangeTheObjectType()
        {
            var value = 10;
            var result = value.ToOrNull<string>();

            Assert.IsType(typeof(string), result);
            Assert.Equal("10", result);
        }

        [Fact]
        public void ToOrNull_ConversionFails_ShouldReturnNull()
        {
            var value = 10;
            var result = value.ToOrNull<Assert>();

            Assert.Null(result);
        }

        [Fact]
        public void ToOrNull_WithOutParam_ConversionSucceeded_ShouldChangeTheObjectType()
        {
            var value = 10;
            string newValue;
            var result = value.ToOrNull<string>(out newValue);

            Assert.True(result);
            Assert.IsType(typeof(string), newValue);
            Assert.Equal("10", newValue);
        }

        [Fact]
        public void ToOrNull_WithOutParam_ConversionFails_ShouldReturnNull()
        {
            var value = 10;
            Assert newValue;
            var result = value.ToOrNull<Assert>(out newValue);

            Assert.False(result);
            Assert.Null(newValue);
        }
    }
}
