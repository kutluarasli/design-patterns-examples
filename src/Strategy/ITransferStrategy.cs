namespace DesignPatternExamples.Strategy
{
    public interface ITransferStrategy
    {
        void Transfer(MoneyTransferInformation information);
    }
}