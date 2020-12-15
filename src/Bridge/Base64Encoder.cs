using System;
using System.Text;

namespace DesignPatternExamples.Bridge
{
    public class Base64Encoder : IEncoder
    {
        public string Encode(string text)
        {
            var textBuffer = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(textBuffer);
        }

        public string Decode(string encodedInput)
        {
            var textBuffer = Convert.FromBase64String(encodedInput);
            return Encoding.UTF8.GetString(textBuffer);
        }
    }
}