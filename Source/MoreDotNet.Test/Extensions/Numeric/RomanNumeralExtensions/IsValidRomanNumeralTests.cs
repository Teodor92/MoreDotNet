namespace MoreDotNet.Tests.Extensions.Numeric.RomanNumeralExtensions
{
    using MoreDotNet.Extensions.Numeric;
    using Xunit;

    public class IsValidRomanNumeralTests
    {
        [Fact]
        public void IsValidRomanNumeral_GivenI_ShouldReturnTrue()
        {
            Assert.True("I".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenII_ShouldReturnTrue()
        {
            Assert.True("II".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenIII_ShouldReturnTrue()
        {
            Assert.True("III".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenIV_ShouldReturnTrue()
        {
            Assert.True("IV".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenV_ShouldReturnTrue()
        {
            Assert.True("V".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenVI_ShouldReturnTrue()
        {
            Assert.True("VI".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenVII_ShouldReturnTrue()
        {
            Assert.True("VII".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenVIII_ShouldReturnTrue()
        {
            Assert.True("VIII".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenIX_ShouldReturnTrue()
        {
            Assert.True("IX".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenX_ShouldReturnTrue()
        {
            Assert.True("X".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenXII_ShouldReturnTrue()
        {
            Assert.True("XII".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenXVI_ShouldReturnTrue()
        {
            Assert.True("XVI".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenXXIX_ShouldReturnTrue()
        {
            Assert.True("XXIX".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenXLIV_ShouldReturnTrue()
        {
            Assert.True("XLIV".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenXLV_ShouldReturnTrue()
        {
            Assert.True("XLV".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenL_ShouldReturnTrue()
        {
            Assert.True("L".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenLXVIII_ShouldReturnTrue()
        {
            Assert.True("LXVIII".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenLXXXIII_ShouldReturnTrue()
        {
            Assert.True("LXXXIII".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenXCVII_ShouldReturnTrue()
        {
            Assert.True("XCVII".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenXCIX_ShouldReturnTrue()
        {
            Assert.True("XCIX".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenC_ShouldReturnTrue()
        {
            Assert.True("C".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenD_ShouldReturnTrue()
        {
            Assert.True("D".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenDI_ShouldReturnTrue()
        {
            Assert.True("DI".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenDCXLIX_ShouldReturnTrue()
        {
            Assert.True("DCXLIX".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenDCCXCVIII_ShouldReturnTrue()
        {
            Assert.True("DCCXCVIII".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenDCCCXCI_ShouldReturnTrue()
        {
            Assert.True("DCCCXCI".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenM_ShouldReturnTrue()
        {
            Assert.True("M".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenMIV_ShouldReturnTrue()
        {
            Assert.True("MIV".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenMVI_ShouldReturnTrue()
        {
            Assert.True("MVI".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenMXXIII_ShouldReturnTrue()
        {
            Assert.True("MXXIII".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenMMXIV_ShouldReturnTrue()
        {
            Assert.True("MMXIV".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenMMMCMXCIX_ShouldReturnTrue()
        {
            Assert.True("MMMCMXCIX".IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenEmptyString_ShouldReturnFalse()
        {
            Assert.False(string.Empty.IsValidRomanNumeral());
        }

        [Fact]
        public void IsValidRomanNumeral_GivenIIII_ShouldReturnFalse()
        {
            Assert.False("IIII".IsValidRomanNumeral());
        }
    }
}
