using System.Collections.Generic;

namespace DesignPatternExamples.Builder.Example3
{
    public interface ICurrencyStorage
    {
        public void Save(List<Currency> currencies);
    }
}