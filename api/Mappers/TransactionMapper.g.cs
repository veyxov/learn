public partial class TransactionMapper : ITransactionMapper
{
    public TransactionDto Map(Transaction p1)
    {
        return p1 == null ? null : new TransactionDto()
        {
            Name = p1.Name,
            Amount = p1.Amount
        };
    }
}