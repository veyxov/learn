public class Transaction
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Amount { get; set; } = 0.0m;
    public DateTime Date { get; set; } = DateTime.Now;
    public bool IsIncome { get; set; } = false;
}

public class TransactionDto
{
    public string Name { get; set; }
    public decimal Amount { get; set; }
}
