using System;

namespace DesignPatternExamples.Strategy
{
    public class DifferentBankTransferStrategy : ITransferStrategy
    {
        public void Transfer(MoneyTransferInformation information)
        {
            Console.WriteLine("Money transferred to a different bank");
        }
    }
}