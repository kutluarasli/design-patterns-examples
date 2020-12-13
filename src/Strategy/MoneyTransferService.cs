using System;

namespace DesignPatternExamples.Strategy
{
    public class MoneyTransferService
    {
        private readonly ITransferStrategy _transferStrategy;

        public MoneyTransferService(ITransferStrategy transferStrategy)
        {
            _transferStrategy = transferStrategy;
        }
        
        
        public void Transfer(MoneyTransferInformation information)
        {
            if (!CheckBalance(information.From))
            {
                throw InsufficientBalanceException();
            }
            
            _transferStrategy.Transfer(information);
            
            PrintReceipt(information);
        }

        private Exception InsufficientBalanceException()
        {
            throw new NotImplementedException();
        }

        private bool CheckBalance(string sourceAccount)
        {
            //TODO: Implement
            return true;
        }

        private void PrintReceipt(MoneyTransferInformation information)
        {
            //TODO: Printer
        }
    }
}