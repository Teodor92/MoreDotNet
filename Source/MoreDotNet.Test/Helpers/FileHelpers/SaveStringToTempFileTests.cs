namespace MoreDotNet.Tests.Helpers.FileHelpers
{
    using System;
    using System.IO;
    using System.IO.Abstractions.TestingHelpers;

    using MoreDotNet.Helpers;

    using Smocks;
    using Smocks.Matching;

    using Xunit;

    public class SaveStringToTempFileTests
    {
        private static readonly Random Random = new Random();

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("File content")]
        [InlineData("File\n \tcontent \b")]
        public void SaveStringToTempFile_StringToWrite_ShouldWriteCorrectDataToFile(string stringToWrite)
        {
            Smock.Run(context =>
            {
                // Arrange
                var fileSystem = new MockFileSystem();

                context.Setup(() => Path.GetTempFileName()).Returns(() => $@"C:\file-{Random.Next()}.tmp");
                context
                    .Setup(() => File.WriteAllText(It.IsAny<string>(), It.IsAny<string>()))
                    .Callback<string, string>((filePath, contents) => fileSystem.File.WriteAllText(filePath, contents));

                // Act
                var path = FileHelpers.SaveStringToTempFile(stringToWrite);

                // Assert
                Assert.True(fileSystem.File.Exists(path));
                Assert.Equal(stringToWrite ?? string.Empty, fileSystem.File.ReadAllText(path));
            });
        }
    }
}
