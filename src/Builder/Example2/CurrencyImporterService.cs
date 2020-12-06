namespace DesignPatternExamples.Builder.Example2
{
    public class CurrencyImporterService
    {
        internal ICurrencyProvider Provider { private get; set; }
        internal ICurrencyStorage Storage { private get; set; }
    
        internal CurrencyImporterService()
        {
        }    

        public void Import()
        {
            var currencies = Provider.ExtractCurrencies();
            Storage.Save(currencies);
        }
    }
}