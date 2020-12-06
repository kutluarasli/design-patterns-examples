using System;
using System.IO;

namespace DesignPatternExamples.FactoryMethod.Example3
{ 
    public class FileLogger: ILogger
    {
        private readonly string _fileName;

        public FileLogger(string fileName)
        {
            if(string.IsNullOrWhiteSpace(fileName)) throw new ArgumentNullException(nameof(fileName));
            
            _fileName = fileName;
        }
        
        public void LogError(string log)
        {
            File.AppendAllText(_fileName, log);
            
        }
    }
}