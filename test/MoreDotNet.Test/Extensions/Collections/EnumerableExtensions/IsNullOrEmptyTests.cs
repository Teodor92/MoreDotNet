﻿namespace MoreDotNet.Test.Extensions.Collections.EnumerableExtensions
{
    using MoreDotNet.Extensions.Collections;

    using Xunit;

    public class IsNullOrEmptyTests
    {
        [Fact]
        public void IsNullOrEmpty_NonEmptyEnumerableGiven_ShouldReturnFalse()
        {
            var input = new[] { 1, 2, 3 };
            var actual = input.IsNullOrEmpty();
            Assert.False(actual);
        }

        [Fact]
        public void IsNullOrEmpty_EmptyEnumerableGiven_ShouldReturnTrue()
        {
            var input = new int[0];
            var actual = input.IsNullOrEmpty();
            Assert.True(actual);
        }

        [Fact]
        public void IsNullOrEmpty_NullEnumerableGiven_ShouldReturnTrue()
        {
            int[] input = null;
            var actual = input.IsNullOrEmpty();
            Assert.True(actual);
        }
    }
}