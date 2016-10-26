namespace MoreDotNet.Tests.Extensions.Numeric.RomanNumeralExtensions
{
    using MoreDotNet.Extensions.Numeric;
    using Xunit;

    public class ParseRomanNumeralTests
    {
        [Fact]
        public void ParseRomanNumeral_GivenI_ShouldReturn1()
        {
            var expected = 1;
            var input = "I";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenII_ShouldReturn2()
        {
            var expected = 2;
            var input = "II";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenIII_ShouldReturn3()
        {
            var expected = 3;
            var input = "III";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenIV_ShouldReturn4()
        {
            var expected = 4;
            var input = "IV";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenV_ShouldReturn5()
        {
            var expected = 5;
            var input = "V";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenVI_ShouldReturn6()
        {
            var expected = 6;
            var input = "VI";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenVII_ShouldReturn7()
        {
            var expected = 7;
            var input = "VII";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenVIII_ShouldReturn8()
        {
            var expected = 8;
            var input = "VIII";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenIX_ShouldReturn9()
        {
            var expected = 9;
            var input = "IX";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenX_ShouldReturn10()
        {
            var expected = 10;
            var input = "X";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenXII_ShouldReturn12()
        {
            var expected = 12;
            var input = "XII";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenXVI_ShouldReturn16()
        {
            var expected = 16;
            var input = "XVI";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenXXIX_ShouldReturn29()
        {
            var expected = 29;
            var input = "XXIX";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenXLIV_ShouldReturn44()
        {
            var expected = 44;
            var input = "XLIV";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenXLV_ShouldReturn45()
        {
            var expected = 45;
            var input = "XLV";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenL_ShouldReturn50()
        {
            var expected = 50;
            var input = "L";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenLXVIII_ShouldReturn68()
        {
            var expected = 68;
            var input = "LXVIII";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenLXXXIII_ShouldReturn83()
        {
            var expected = 83;
            var input = "LXXXIII";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenXCVII_ShouldReturn97()
        {
            var expected = 97;
            var input = "XCVII";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenXCIX_ShouldReturn99()
        {
            var expected = 99;
            var input = "XCIX";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenC_ShouldReturn100()
        {
            var expected = 100;
            var input = "C";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenD_ShouldReturn500()
        {
            var expected = 500;
            var input = "D";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenDI_ShouldReturn501()
        {
            var expected = 501;
            var input = "DI";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenDCXLIX_ShouldReturn649()
        {
            var expected = 649;
            var input = "DCXLIX";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenDCCXCVIII_ShouldReturn798()
        {
            var expected = 798;
            var input = "DCCXCVIII";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenDCCCXCI_ShouldReturn891()
        {
            var expected = 891;
            var input = "DCCCXCI";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenM_ShouldReturn1000()
        {
            var expected = 1000;
            var input = "M";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenMIV_ShouldReturn1004()
        {
            var expected = 1004;
            var input = "MIV";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenMVI_ShouldReturn1006()
        {
            var expected = 1006;
            var input = "MVI";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenMXXIII_ShouldReturn1023()
        {
            var expected = 1023;
            var input = "MXXIII";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenMMXIV_ShouldReturn2014()
        {
            var expected = 2014;
            var input = "MMXIV";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseRomanNumeral_GivenMMMCMXCIX_ShouldReturn3999()
        {
            var expected = 3999;
            var input = "MMMCMXCIX";
            var actual = input.ParseRomanNumeral();
            Assert.Equal(expected, actual);
        }
    }
}
