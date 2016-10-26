namespace MoreDotNet.Tests.Extensions.Numeric.RomanNumeralExtensions
{
    using System;
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

        [Fact]
        public void ToRomanNumeralString_Given2_ShouldReturnII()
        {
            var expected = "II";
            var input = 2;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given3_ShouldReturnIII()
        {
            var expected = "III";
            var input = 3;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given4_ShouldReturnIV()
        {
            var expected = "IV";
            var input = 4;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given5_ShouldReturnV()
        {
            var expected = "V";
            var input = 5;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given6_ShouldReturnVI()
        {
            var expected = "VI";
            var input = 6;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given7_ShouldReturnVII()
        {
            var expected = "VII";
            var input = 7;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given8_ShouldReturnVIII()
        {
            var expected = "VIII";
            var input = 8;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given9_ShouldReturnIX()
        {
            var expected = "IX";
            var input = 9;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given10_ShouldReturnX()
        {
            var expected = "X";
            var input = 10;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given12_ShouldReturnXII()
        {
            var expected = "XII";
            var input = 12;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given16_ShouldReturnXVI()
        {
            var expected = "XVI";
            var input = 16;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Give29_ShouldReturnXXIX()
        {
            var expected = "XXIX";
            var input = 29;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Give44_ShouldReturnXLIV()
        {
            var expected = "XLIV";
            var input = 44;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given45_ShouldReturnXLV()
        {
            var expected = "XLV";
            var input = 45;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given50_ShouldReturnL()
        {
            var expected = "L";
            var input = 50;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given68_ShouldReturnLXVIII()
        {
            var expected = "LXVIII";
            var input = 68;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given83_ShouldReturnLXXXIII()
        {
            var expected = "LXXXIII";
            var input = 83;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given97_ShouldReturnXCVII()
        {
            var expected = "XCVII";
            var input = 97;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given99_ShouldReturnXCIX()
        {
            var expected = "XCIX";
            var input = 99;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given100_ShouldReturnC()
        {
            var expected = "C";
            var input = 100;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given500_ShouldReturnD()
        {
            var expected = "D";
            var input = 500;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given501_ShouldReturnDI()
        {
            var expected = "DI";
            var input = 501;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given649_ShouldReturnDCXLIX()
        {
            var expected = "DCXLIX";
            var input = 649;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given798_ShouldReturnDCCXCVIII()
        {
            var expected = "DCCXCVIII";
            var input = 798;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given891_ShouldReturnDCCCXCI()
        {
            var expected = "DCCCXCI";
            var input = 891;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given1000_ShouldReturnM()
        {
            var expected = "M";
            var input = 1000;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given1004_ShouldReturnMIV()
        {
            var expected = "MIV";
            var input = 1004;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given1006_ShouldReturnMVI()
        {
            var expected = "MVI";
            var input = 1006;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given1023_ShouldReturnMXXIII()
        {
            var expected = "MXXIII";
            var input = 1023;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given2014_ShouldReturnMMXIV()
        {
            var expected = "MMXIV";
            var input = 2014;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given3999_ShouldReturnMMMCMXCIX()
        {
            var expected = "MMMCMXCIX";
            var input = 3999;
            var actual = input.ToRomanNumeralString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToRomanNumeralString_Given0_ShouldThrowArgumentOutOfRangeException()
        {
            var input = 0;
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToRomanNumeralString());
        }

        [Fact]
        public void ToRomanNumeralString_Given4000_ShouldThrowArgumentOutOfRangeException()
        {
            var input = 4000;
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToRomanNumeralString());
        }
    }
}
