namespace MoreDotNet.Tests.Extensions.Common.ConvertibleExtensions
{
    using System.Drawing;
    using MoreDotNet.Extensions.Common;
    using Xunit;

    public class ToOrDefaultTests
    {
        [Fact]
        public void ToOrDefault_ConversionSucceeded_ShouldChangeTheObjectType()
        {
            var value = 10;
            var result = value.ToOrDefault<string>();

            Assert.IsType(typeof(string), result);
            Assert.Equal("10", result);
        }

        [Fact]
        public void ToOrDefault_ConversionFails_ShouldReturnDefaultOfT()
        {
            var value = 10;
            var result = value.ToOrDefault<Color>();

            Assert.IsType(typeof(Color), result);
            Assert.Equal(default(Color), result);
        }

        [Fact]
        public void ToOrDefault_WithOutParam_ConversionSucceeded_ShouldChangeTheObjectType()
        {
            var value = 10;
            string newValue;
            var result = value.ToOrDefault<string>(out newValue);

            Assert.True(result);
            Assert.IsType(typeof(string), newValue);
            Assert.Equal("10", newValue);
        }

        [Fact]
        public void ToOrDefault_WithOutParam_ConversionFails_ShouldReturnDefaultOfT()
        {
            var value = 10;
            Color newValue;
            var result = value.ToOrDefault<Color>(out newValue);

            Assert.False(result);
            Assert.IsType(typeof(Color), newValue);
            Assert.Equal(default(Color), newValue);
        }
    }
}
