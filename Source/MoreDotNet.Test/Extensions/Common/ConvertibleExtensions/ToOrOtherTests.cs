namespace MoreDotNet.Tests.Extensions.Common.ConvertibleExtensions
{
    using System.Drawing;
    using MoreDotNet.Extensions.Common;
    using Xunit;

    public class ToOrOtherTests
    {
        private const string Other = "other";

        [Fact]
        public void ToOrOther_ConversionSucceeded_ShouldChangeTheObjectType()
        {
            var value = 10;
            var result = value.ToOrOther<string>(Other);

            Assert.IsType(typeof(string), result);
            Assert.Equal("10", result);
        }

        [Fact]
        public void ToOrOther_ConversionFails_ShouldReturnOtherValue()
        {
            var value = 10;
            var result = value.ToOrOther<Color>(Color.Chartreuse);

            Assert.IsType(typeof(Color), result);
            Assert.Equal(Color.Chartreuse, result);
        }

        [Fact]
        public void ToOrOther_WithOutParam_ConversionSucceeded_ShouldChangeTheObjectType()
        {
            var value = 10;
            string newValue;
            var result = value.ToOrOther<string>(out newValue, Other);

            Assert.True(result);
            Assert.IsType(typeof(string), newValue);
            Assert.Equal("10", newValue);
        }

        [Fact]
        public void ToOrOther_WithOutParam_ConversionFails_ShouldReturnDefaultOfT()
        {
            var value = 10;
            Color newValue;
            var result = value.ToOrOther<Color>(out newValue, Color.BurlyWood);

            Assert.False(result);
            Assert.IsType(typeof(Color), newValue);
            Assert.Equal(Color.BurlyWood, newValue);
        }
    }
}
