using Microsoft.EntityFrameworkCore;
public class BankAppDbContext:DbContext
{
    public BankAppDbContext(DbContextOptions<BankAppDbContext> options):base(options)
    {
        
    }
    public DbSet<Customer>  Customers{get;set;}
    public DbSet<Transaction> Transactions{get;set;}
}

