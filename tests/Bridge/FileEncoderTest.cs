using System.IO;
using DesignPatternExamples.Bridge;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.Bridge
{
    public class FileEncoderTest
    {

        [Ignore("This is just a client example, not working")]
        [Test]
        public void Encode_ShouldWriteToFile()
        {
            // Arrange
            var encoder = new FileEncoder(new CustomEncoder());

            //Act
            var encodedText = encoder.Encode(new FileInfo("./testfile"));
            
            //Assert
            Assert.NotNull(encodedText);
        }
    }
}