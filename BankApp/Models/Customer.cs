public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string AccountType { get; set; }

    public string AccountNumber {get;set;}
    public string AccessCode{get;set;}
    public string DipositAmount{get;set;}
    
}

public class Transaction
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public decimal Amount { get; set; }
    public DateTime TransactionDate { get; set; }
    // Other properties and methods
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    
}

