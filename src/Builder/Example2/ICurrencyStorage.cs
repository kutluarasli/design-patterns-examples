using System.Collections.Generic;

namespace DesignPatternExamples.Builder.Example2
{
    public interface ICurrencyStorage
    {
        public void Save(List<Currency> currencies);
    }
}