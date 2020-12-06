namespace DesignPatternExamples.Builder.Example2
{
    public class DefaultCurrencyImporterServiceBuilder : ICurrencyImporterServiceBuilder
    {
        private readonly CurrencyImporterService _currencyImporterService;

        public DefaultCurrencyImporterServiceBuilder()
        {
            _currencyImporterService = new CurrencyImporterService();
        }
        
        public void BuildCurrencyProvider()
        {
            _currencyImporterService.Provider = new CentralBankCurrencyProvider();
        }

        public void BuildCurrencyStorage()
        {
            _currencyImporterService.Storage = new MongoCurrencyStorage();
        }

        public CurrencyImporterService GetResult()
        {
            return _currencyImporterService;
        }
    }
}