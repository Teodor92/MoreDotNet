namespace MoreDotNet.Tests.Extensions.Common.ConvertibleExtensions
{
    using MoreDotNet.Extensions.Common;
    using Xunit;

    public class ToTests
    {
        [Fact]
        public void To_ChangesTypeOfObject()
        {
            var value = 10;
            var result = value.To<string>();

            Assert.IsType(typeof(string), result);
            Assert.Equal("10", result);
        }
    }
}