namespace DesignPatternExamples.Builder.Example3
{
    public class DefaultCurrencyImporterServiceBuilder : ICurrencyImporterServiceBuilder
    {
        public void BuildCurrencyProvider(CurrencyImporterService currencyImporterService)
        {
            currencyImporterService.Provider = new CentralBankCurrencyProvider();
        }

        public void BuildCurrencyStorage(CurrencyImporterService currencyImporterService)
        {
            currencyImporterService.Storage = new MongoCurrencyStorage();
        }
    }
}