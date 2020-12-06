namespace DesignPatternExamples.FactoryMethod.Example3
{
    public class FileLoggerFactory : ILoggerFactory
    {
        private readonly string _fileName;

        public FileLoggerFactory(string fileName)
        {
            _fileName = fileName;
        }


        public ILogger CreateLogger()
        {
            return new FileLogger(_fileName);
        }
    }
}