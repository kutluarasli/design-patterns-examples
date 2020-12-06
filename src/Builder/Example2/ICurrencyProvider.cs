using System.Collections.Generic;

namespace DesignPatternExamples.Builder.Example2
{
    public interface ICurrencyProvider
    {
        public List<Currency> ExtractCurrencies();
    }
}