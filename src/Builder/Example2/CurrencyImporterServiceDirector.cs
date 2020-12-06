namespace DesignPatternExamples.Builder.Example2
{
    public class CurrencyImporterServiceDirector
    {
        private readonly ICurrencyImporterServiceBuilder _builder;

        public CurrencyImporterServiceDirector(ICurrencyImporterServiceBuilder builder)
        {
            _builder = builder;
        }

        public CurrencyImporterService GetCurrencyImporterService()
        {
            _builder.BuildCurrencyProvider();
            _builder.BuildCurrencyStorage();
            return _builder.GetResult();
        }
    }
}