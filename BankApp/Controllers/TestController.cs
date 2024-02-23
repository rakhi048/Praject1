// using Microsoft.AspNetCore.Mvc;

// public class TransferController : Controller
// {
//     private readonly ProductMgmtDbContext _context;

//     public TransferController(ProductMgmtDbContext context)
//     {
//         _context = context;
//     }

//     [HttpPost]
//     public IActionResult Transfer(int fromAccountNumber, int toAccountNumber, decimal amount)
//     {
//        // var fromAccount = TransferDbContext.Acctounts.Find(fromAccountNumber);
//         //var toAccount = TransferDbContext.AccountNumber.Find(toAccountNumber);

//         if (fromAccount == null || toAccount == null)
//         {
//             return NotFound("One or both accounts not found.");
//         }

//         if (fromAccount.Balance < amount)
//         {
//             return BadRequest("Insufficient funds.");
//         }

//         // Perform the money transfer
//         fromAccount.Withdraw(amount);
//         toAccount.Deposit(amount);

//         // Save changes to the database
//         _context.SaveChanges();

//         return Ok("Money transferred successfully.");
//     }
// }

