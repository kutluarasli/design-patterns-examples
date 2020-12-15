namespace DesignPatternExamples.Bridge
{
    public interface IEncoder
    {
        string Encode(string text);
        string Decode(string encodedText);
    }
}