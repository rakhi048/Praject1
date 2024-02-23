using Microsoft.AspNetCore.Mvc;
using BankApp.Models;
public class CustomersController:Controller
{
    private BankAppDbContext bankAppDbContextContext;
    public CustomersController(BankAppDbContext bankAppDbContextContext)
    {
        this.bankAppDbContextContext=bankAppDbContextContext;
    }
   [HttpGet]
    public IActionResult Create()
    {
return View();
    }
    [HttpPost]
    public IActionResult Create(Customer customer)
    {
        this.bankAppDbContextContext.Add(customer);
        this.bankAppDbContextContext.SaveChanges();
        return View("List",this.bankAppDbContextContext.Customers.ToList());
    }
    public IActionResult  List()
    {
        return View(this.bankAppDbContextContext.Customers.ToList());
    }
}
