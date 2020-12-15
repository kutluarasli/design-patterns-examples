using System.IO;

namespace DesignPatternExamples.Bridge
{
    public class FileEncoder
    {
        private readonly IEncoder _encoder;

        public FileEncoder(IEncoder encoder)
        {
            _encoder = encoder;
        }
        
        public string Encode(FileInfo file)
        {
            using var fileStream = file.OpenRead();
            using var streamReader = new StreamReader(fileStream);
            var allContent = streamReader.ReadToEnd(); 
            return _encoder.Encode(allContent);
        }

        public void Decode(FileInfo file, string encodedText)
        {
            if (!file.Exists)
            {
                file.Create();
            }
            using var fileStream = file.OpenWrite();
            using var streamWriter = new StreamWriter(fileStream);
            var content = _encoder.Decode(encodedText);
            streamWriter.WriteLine(encodedText);
        }
        
    }
}