namespace DesignPatternExamples.Builder.Example2
{
    public interface ICurrencyImporterServiceBuilder
    {
        void BuildCurrencyProvider();
        void BuildCurrencyStorage();
        
        CurrencyImporterService GetResult();
    }
}