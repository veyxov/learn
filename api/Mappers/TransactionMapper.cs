using Mapster;

[Mapper]
public interface ITransactionMapper
{
    TransactionDto Map(Transaction transaction);
}
