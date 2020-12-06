using System.Collections.Generic;

namespace DesignPatternExamples.Builder.Example3
{
    public interface ICurrencyProvider
    {
        public List<Currency> ExtractCurrencies();
    }
}