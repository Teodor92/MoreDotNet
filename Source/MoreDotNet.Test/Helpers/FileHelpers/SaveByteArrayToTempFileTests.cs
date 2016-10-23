namespace MoreDotNet.Tests.Helpers.FileHelpers
{
    using System;
    using System.IO;
    using System.IO.Abstractions.TestingHelpers;

    using MoreDotNet.Helpers;

    using Smocks;
    using Smocks.Matching;

    using Xunit;

    public class SaveByteArrayToTempFileTests
    {
        private static readonly Random Random = new Random();

        [Fact]
        public void SaveByteArrayToTempFile_NullBytesToWrite_ShouldThrow()
        {
            // Arrange
            byte[] data = null;

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => FileHelpers.SaveByteArrayToTempFile(data));
        }

        [Theory]
        [InlineData(new byte[] { })]
        [InlineData(new byte[] { 1 })]
        [InlineData(new byte[] { 1, 0 })]
        [InlineData(new byte[] { 1, 0, 241, 222, 123 })]
        [InlineData(new byte[] { 1, 0, 124, 225, 165, 229, 11, 69, 0, 1 })]
        public void SaveByteArrayToTempFile_NonNullBytesToWrite_ShouldWriteCorrectDataToFile(byte[] bytesToWrite)
        {
            Smock.Run(context =>
            {
                // Arrange
                var fileSystem = new MockFileSystem();

                context.Setup(() => Path.GetTempFileName()).Returns(() => $@"C:\file-{Random.Next()}.tmp");
                context
                    .Setup(() => File.WriteAllBytes(It.IsAny<string>(), It.IsAny<byte[]>()))
                    .Callback<string, byte[]>((filePath, contents) => fileSystem.File.WriteAllBytes(filePath, contents));

                // Act
                var path = FileHelpers.SaveByteArrayToTempFile(bytesToWrite);

                // Assert
                Assert.True(fileSystem.File.Exists(path));
                Assert.Equal(bytesToWrite, fileSystem.File.ReadAllBytes(path));
            });
        }

    }
}
