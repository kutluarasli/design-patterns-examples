using System;

namespace DesignPatternExamples.Strategy
{
    public class SameBankTransferStrategy : ITransferStrategy
    {
        public void Transfer(MoneyTransferInformation information)
        {
            Console.WriteLine("Money transferred internally");
        }
    }
}