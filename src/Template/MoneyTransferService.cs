using System;

namespace DesignPatternExamples.Template
{
    public abstract class MoneyTransferService
    {
        public void Transfer(MoneyTransferInformation information)
        {
            if (!CheckBalance(information.From))
            {
                throw InsufficientBalanceException();
            }
            
            TransferInternal(information);
            PrintReceipt(information);
        }

        protected abstract void TransferInternal(MoneyTransferInformation information);

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