using Microsoft.AspNetCore.Mvc;
using BankApp.Models;
public class CustomersController:Controller
{
    private ProductMgmtDbContext productMgmtDbContext;
    public CustomersController(ProductMgmtDbContext productMgmtDbContext)
    {
        this.productMgmtDbContext=productMgmtDbContext;
    }
   [HttpGet]
    public IActionResult Create()
    {
return View();
    }
    [HttpPost]
    public IActionResult Create(Customer customer)
    {
        this.productMgmtDbContext.Add(customer);
        this.productMgmtDbContext.SaveChanges();
        return View("List",this.productMgmtDbContext.customers.ToList());
    }
    public IActionResult  List()
    {
        return View(this.productMgmtDbContext.customers.ToList());
    }
}
