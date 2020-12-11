using System;

namespace DesignPatternExamples.Template
{
    public class DifferentBankTransferService : MoneyTransferService
    {
        protected override void TransferInternal(MoneyTransferInformation information)
        {
            Console.WriteLine("Money transferred to a different bank");
        }
    }
}