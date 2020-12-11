using System;

namespace DesignPatternExamples.Template
{
    public class SameBankTransferService : MoneyTransferService
    {
        protected override void TransferInternal(MoneyTransferInformation information)
        {
            Console.WriteLine("Money transferred internally");
        }
    }
}