public class Transaction
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public decimal Amount { get; set; }
    public DateTime TransactionDate { get; set; }
    
   

    public void Deposit(decimal amount)
    {
        Amount += amount;
    }
    public void Withdraw(decimal amount)
    {
        Amount -= amount;
    }
}
