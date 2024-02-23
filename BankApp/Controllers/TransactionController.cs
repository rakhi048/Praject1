using Microsoft.AspNetCore.Mvc;

public class TransactionController : Controller
{
    private BankAppDbContext context;

    public TransactionController(BankAppDbContext context)
    {
        this.context = context;
    }

    [HttpPost]
    public IActionResult Transfer(int fromAccountId, int toAccountId, decimal amount)
    {
        var fromAccount = context.Transactions.Find(fromAccountId);
        var toAccount = context.Transactions.Find(toAccountId);

        if (fromAccount == null || toAccount == null)
        {
            return NotFound("One or both accounts not found.");
        }

        if (fromAccount.Amount < amount)
        {
            return BadRequest("Insufficient funds.");
        }

        // Perform the money transfer
        fromAccount.Withdraw(amount);
        toAccount.Deposit(amount);

        // Save changes to the database
        context.SaveChanges();

        return Ok("Money transferred successfully.");
    }
}

