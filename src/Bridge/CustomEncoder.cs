namespace DesignPatternExamples.Bridge
{
    public class CustomEncoder: IEncoder
    {
        public string Encode(string text)
        {
            return text;
        }

        public string Decode(string encodedText)
        {
            return encodedText;
        }
    }
}