public class BankTransactions
{
    public DateTime TransactionDate { get; set; }
    public double Amount { get; set; }
    public string Discription { get; set; }

    public override string ToString()
    {
        return $"transaction {{ date = {TransactionDate.ToShortDateString}, amount = {Amount}, description = {Discription} }}";
    }
}