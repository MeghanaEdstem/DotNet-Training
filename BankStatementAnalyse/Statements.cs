public class Statements
{
    public List<BankTransactions> transactions { get; set; } = new List<BankTransactions>();

    public void BankStatement()
    {
        string[] test = File.ReadAllLines(@"C:\Users\MEGHANA\source\repos\HelloWorld\BankStatementAnalyse\test.csv");
        foreach (string item in test)
        {
            string[] list = item.Split(",");

            DateTime transactionDate = DateTime.Parse(list[0]);
            double amount = double.Parse(list[1]);
            string discription = list[2];

            var statement = new BankTransactions()
            {
                TransactionDate = transactionDate,
                Amount = amount,
                Discription = discription
            };

            transactions.Add(statement);
        }
    }
    
    public double BankBalance()
    {
        double balance = 0.0;
        foreach (var item in transactions)
        {
            balance += item.Amount;
        }
        return balance;
    }

    public double NetBalance(int month)
    {
        double netBalance = 0.0;
        foreach (var item in transactions)
        {
            if (item.TransactionDate.Month == month)
            {
                netBalance += item.Amount;
            }
        }
        return netBalance;
    }

    public void PrintBankTransactions()
    {
        foreach (var item in transactions)
        {
            Console.WriteLine(item);
        }
    }
}
