namespace DesignPatternExamples.Builder.Example3
{
    public interface ICurrencyImporterServiceBuilder
    {
        void BuildCurrencyProvider(CurrencyImporterService currencyImporterService);
        void BuildCurrencyStorage(CurrencyImporterService currencyImporterService);
    }
}