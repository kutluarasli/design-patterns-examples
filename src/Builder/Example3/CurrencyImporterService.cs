namespace DesignPatternExamples.Builder.Example3
{
    public class CurrencyImporterService
    {
        internal ICurrencyProvider Provider { private get; set; }
        internal ICurrencyStorage Storage { private get; set; }
    
        public CurrencyImporterService(ICurrencyImporterServiceBuilder builder)
        {
            builder.BuildCurrencyProvider(this);
            builder.BuildCurrencyStorage(this);
        }

        public void Import()
        {
            var currencies = Provider.ExtractCurrencies();
            Storage.Save(currencies);
        }
    }
}